namespace DataGridFormatting
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;

    /// <summary>
    /// Interaction logic for PrecisionAdjuster.xaml
    /// </summary>
    public partial class PrecisionAdjuster : UserControl
    {
        public static readonly DependencyProperty PrecisionProperty = DependencyProperty.Register(
            "Precision",
            typeof(int),
            typeof(PrecisionAdjuster),
            new PropertyMetadata(default(int)));

        public int Precision
        {
            get { return (int)GetValue(PrecisionProperty); }
            set { SetValue(PrecisionProperty, value); }
        }

        public PrecisionAdjuster()
        {
            InitializeComponent();

            DataContext = new PrecisionAdjusterViewModel();

            Binding binding = new Binding("Precision") { Mode = BindingMode.TwoWay };
            SetBinding(PrecisionProperty, binding);
        }
    }
}
