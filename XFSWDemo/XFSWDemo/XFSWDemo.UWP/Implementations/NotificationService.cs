using XFSWDemo.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationService))]
namespace XFSWDemo.UWP
{
    public class NotificationService : INotificationService
    {
        public void Notify(string message)
        {
            //var toast = Toast.MakeText(Application.Context, message, ToastLength.Long);
            //toast.Show();
        }
    }
}