
using Android.App;
using Android.Widget;
using XFSWDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationService))]
namespace XFSWDemo.Droid
{
    public class NotificationService : INotificationService
    {
        public void Notify(string message)
        {
            var toast = Toast.MakeText(Application.Context, message, ToastLength.Long);
            toast.Show();
        }
    }
}