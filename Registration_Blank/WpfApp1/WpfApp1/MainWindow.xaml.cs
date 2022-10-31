using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void UserNsme_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.UserNsme.Text.Length != 0)
                UNL.Content = "";
            else
                UNL.Content = "User name";
        }

        private void UserEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.UserEmail.Text.Length != 0)
                EML.Content = "";
            else
                EML.Content = "Email";
        }

        private void Confirm_Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.Confirm_Email.Text.Length != 0)
                CEL.Content = "";
            else
                CEL.Content = "Confirm email";
        }

        private void EnterPass(object sender, KeyEventArgs e)
        {
            if (this.UserPasword.Password.Length != 0)
                PWN.Content = "";
            else
                PWN.Content = "Password";
        }

        private void DateSelecting(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
