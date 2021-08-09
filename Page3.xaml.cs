using System;
using System.Windows;
using System.Windows.Controls;

namespace ChestionarApp
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            numelefinal.Text = "Felicitari " + GLOBALS.Nume + "!";
            scor.Text = "Ai obtinut " + GLOBALS.score.ToString() + " puncte.";
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
