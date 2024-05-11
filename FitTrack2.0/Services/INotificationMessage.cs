using Syncfusion.Blazor.Notifications;

namespace FitTrack2._0.Services
{
    public interface INotificationMessage
    {
        public ToastModel toastModelSuccessfull { get; set; }

        public ToastModel toastModelFailed { get; set; }
    }
}
