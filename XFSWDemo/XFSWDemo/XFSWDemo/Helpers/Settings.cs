using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace XFSWDemo.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string APIKey = "settings_key";
        private static readonly string APIDefault = "https://swapi.co/api/";

        #endregion


        public static string API
        {
            get
            {
                return AppSettings.GetValueOrDefault(APIKey, APIDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(APIKey, value);
            }
        }

    }
}
