using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChestionarApp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text) && String.IsNullOrEmpty(GLOBALS.Nivel))
            {
                Name.Background = Brushes.Red;
                rb1.Background = Brushes.Red;
                rb2.Background = Brushes.Red;
                rb3.Background = Brushes.Red;
                rb4.Background = Brushes.Red;
                MessageBox.Show("Please type your name and select the level");
            }
            else if (String.IsNullOrEmpty(Name.Text))
            {
                Name.Background = Brushes.Red;
                MessageBox.Show("Please type your name");
            }
            else if (String.IsNullOrEmpty(GLOBALS.Nivel))
            {
                rb1.Background = Brushes.Red;
                rb2.Background = Brushes.Red;
                rb3.Background = Brushes.Red;
                rb4.Background = Brushes.Red;
                MessageBox.Show("Please select the Level");
            }
            else
            {
                GLOBALS.Nume = this.Name.Text;
                Page p2 = new Page2();
                this.NavigationService.Navigate(p2);
            }
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            //nivelGlobal.Text = (String)rb.Content; ///trimit datele de pe radiobutton pe textbox
            GLOBALS.Nivel = (String)rb.Content;
        }
    }
}
