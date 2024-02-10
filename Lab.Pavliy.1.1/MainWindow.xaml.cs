using Lab.Pavliy._1._1.mod;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab.Pavliy._1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Root root;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double coefficientA = Convert.ToDouble(a.Text);
            double coefficientB = Convert.ToDouble(b.Text);
            double coefficientC = Convert.ToDouble(c.Text);

            
            Root root;
            if (coefficientA == 0)
            {
                root = new Linear(coefficientB, coefficientC);
            }
            else
            {
                root = new Square(coefficientA, coefficientB, coefficientC);
            }

            ResFirst.Text = $"Roots: {root.CalculateRoots()}";
        }
    }
}