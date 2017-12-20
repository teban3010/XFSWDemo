using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFSWDemo.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { if (_isBusy == value) return; _isBusy = value; OnPropertyChanged(nameof(IsBusy)); }
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
