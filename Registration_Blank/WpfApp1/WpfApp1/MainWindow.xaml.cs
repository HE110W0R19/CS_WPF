using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LanguageButton.Content.ToString() == "EN")
            {
                LanguageButton.Content = Resource.EN;
                UNL.Content = Resource.User_name;
                PWN.Content = Resource.Password;
                EML.Content = Resource.Email;
                CEL.Content = Resource.Confirm_email;
                Sign_Up_button.Content = Resource.SIGN_UP;
                Context.Content = Resource.Sign_up_with_you_email_addres;
            }
            else if(LanguageButton.Content.ToString() == "RU")
            {
                LanguageButton.Content = RuResource.RU;
                UNL.Content = RuResource.Имя_пользователя;
                PWN.Content = RuResource.Пароль;
                EML.Content = RuResource.Эл_Почта;
                CEL.Content = RuResource.Подтверждение_эл_почты;
                Sign_Up_button.Content = RuResource.ВХОД;
                Context.Content = RuResource.Регестрация_через_эл_почту;
            }
        }
    }
}
