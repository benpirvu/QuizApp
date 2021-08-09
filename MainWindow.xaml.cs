using System.Windows;
using System.Windows.Controls;
namespace ChestionarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Page p1 = new Page1();
            myframe.NavigationService.Navigate(p1);

        }

    }
}
