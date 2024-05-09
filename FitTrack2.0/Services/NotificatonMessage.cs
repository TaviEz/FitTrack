using Syncfusion.Blazor.Notifications;

namespace FitTrack2._0.Services
{
    public class NotificatonMessage
    {
        ToastModel toastModelSuccessfull = new ToastModel
        {
            Title = "Success!",
            CssClass = "e-toast-success",
        };

        ToastModel toastModelFailed = new ToastModel
        {
            Title = "Failed!",
            CssClass = "e-toast-danger",
        };
    }
}
