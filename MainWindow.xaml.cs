namespace DataGridFormatting
{
    using System.Collections.ObjectModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataGridSource = new ObservableCollection<ItemRate>
            {
                new ItemRate("AAA", 3.0123456789), 
                new ItemRate("BBB", 1.8478913937), 
                new ItemRate("CCC", 2.3891383276),
                new ItemRate("DDD", 1.2334392431)
            };

            InitializeComponent();
        }

        public ObservableCollection<ItemRate> DataGridSource { get; set; }
    }
}
