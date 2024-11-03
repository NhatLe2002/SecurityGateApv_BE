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
    public class VisitCardStatusUpdaterService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<VisitCardStatusUpdaterService> _logger;

        public VisitCardStatusUpdaterService(IServiceProvider serviceProvider, ILogger<VisitCardStatusUpdaterService> logger)
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
                    await UpdateVisitCardStatusesAsync();
                    Console.WriteLine("Visit card status updated successfully");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while updating visit card statuses.");
                }
                Console.WriteLine("Visit card status updated");

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
        private async Task UpdateVisitCardStatusesAsync()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                try
                {
                    var visitCardRepo = scope.ServiceProvider.GetRequiredService<IVisitCardRepo>();
                    var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                    var visitCardsToUpdate = await visitCardRepo.FindAsync(vc => vc.ExpiryDate <= DateTime.Now 
                        && vc.VisitCardStatus == VisitCardStatusEnum.Issue.ToString(),
                            int.MaxValue,1
                        );
                    Console.Write(visitCardsToUpdate.Count());
                    foreach (var visitCard in visitCardsToUpdate)
                    {
                        visitCard.UpdateVisitCardStatusBackgroundWoker(VisitCardStatusEnum.Expired.ToString());
                        await visitCardRepo.UpdateAsync(visitCard);
                    }

                    //await unitOfWork.CommitAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while updating visit card statuses in the database.");
                    throw; // Re-throw the exception to be caught by the outer try-catch block
                }
            }
        }
    }
}
