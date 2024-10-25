using SecurityGateApv.Domain.Interfaces.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Notifications
{
    public class NotificationsService : INotifications
    {
        private readonly NotificationHub _notificationHub;

        public NotificationsService(NotificationHub notificationHub)
        {
            _notificationHub = notificationHub;
        }
        public async Task SendMessage()
        {
            await _notificationHub.SendMessage();
        }
    }
}
