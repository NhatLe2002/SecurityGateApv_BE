using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SecurityGateApv.Domain.Enums;
using SecurityGateApv.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.BackgroundWorker
{
    public class VisitStatusUpdaterService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<VisitStatusUpdaterService> _logger;

        public VisitStatusUpdaterService(IServiceProvider serviceProvider, ILogger<VisitStatusUpdaterService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await UpdateVisitStatusesAsync();
                    Console.WriteLine("Visit status updated succes");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while updating visit statuses.");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                //Console.WriteLine("Visit status updated");
            }
        }

        private async Task UpdateVisitStatusesAsync()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                try
                {
                    var visitRepo = scope.ServiceProvider.GetRequiredService<IVisitRepo>();
                    var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                    var visitsToUpdate = await visitRepo.FindAsync(v => v.ExpectedEndTime <= DateTime.Now && v.VisitStatus == "Test",
                        int.MaxValue,1
                    );
                    //Console.Write(visitsToUpdate.FirstOrDefault().VisitName);
                    foreach (var visit in visitsToUpdate)
                    {
                        visit.UpdateStatusBackGroundWoker(VisitStatusEnum.Cancel.ToString());
                        await visitRepo.UpdateAsync(visit);
                    }

                    await unitOfWork.CommitAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while updating visit statuses in the database.");
                    throw; // Re-throw the exception to be caught by the outer try-catch block
                }
            }
        }
    }
}
