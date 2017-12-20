using UIKit;
using XFSWDemo.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationService))]
namespace XFSWDemo.iOS
{
    public class NotificationService : INotificationService
    {
        public void Notify(string message)
        {
            //Create Alert            
            var okAlertController = UIAlertController.Create("Notification", message, UIAlertControllerStyle.Alert);

            //Add Action            
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            if (UIApplication.SharedApplication.KeyWindow != null)
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(okAlertController, true, null);
        }
    }
}