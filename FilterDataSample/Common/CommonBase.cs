using System.ComponentModel;

namespace FilterDataSample.Common
{
    /// <summary>
    /// This class implements the INotifyPropertyChanged Event Procedure
    /// </summary>
    public class CommonBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            // Only raise event if handler is connected
            // Raise the PropertyChanged event.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
