using Syncfusion.Blazor.Notifications;

namespace FitTrack2._0.Services
{
    public class NotificatonMessage: INotificationMessage
    {
        public ToastModel toastModelSuccessfull { get; set; } = new ToastModel
        {
            Title = "Success!",
            CssClass = "e-toast-success",
        };

        public ToastModel toastModelFailed { get; set; } = new ToastModel
        {
            Title = "Failed!",
            CssClass = "e-toast-danger",
        };
    }
}
