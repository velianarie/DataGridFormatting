namespace DataGridFormatting
{
    using System.ComponentModel;
    using System.Windows.Input;
    using CommonLibrary;

    public class PrecisionAdjusterViewModel : INotifyPropertyChanged
    {
        private int precision;

        public PrecisionAdjusterViewModel()
        {
            Precision = 2;
            ReducePrecision = new DelegatingCommand(OnReducePrecision);
            IncreasePrecision = new DelegatingCommand(OnIncreasePrecision);
        }

        public int Precision
        {
            get { return precision; }
            set 
            { 
                precision = value;
                OnPropertyChanged("Precision");
            }
        }

        public ICommand ReducePrecision { get; set; }

        public ICommand IncreasePrecision { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnReducePrecision()
        {
            if (Precision > 0)
            {
                Precision--;
            }
        }

        private void OnIncreasePrecision()
        {
            Precision++;
        }
    }
}
