using System.ComponentModel;

namespace Infrastructure
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel() { }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
