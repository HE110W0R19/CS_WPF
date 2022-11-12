using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PhoneBook
{
    partial class MainWindow
    {
        public class UserInfo
        {
            string fName = "";
            string lName = "";
            string Name = "";
            string Email = "";
            string Phone = "";
            string From = "";
            public UserInfo(string fN, string lN, string E, string P, int FromIndex)
            {
                this.fName = fN; this.lName = lN;
                this.Name = $"{fName} {lName}";
                this.Email = E;
                switch (FromIndex)
                {
                    case 0:
                        this.Phone += "+7 ";
                        this.From = "Russia";
                        break;
                    case 1:
                        this.Phone += "+375 ";
                        this.From = "Belorussia";
                        break;
                    case 2:
                        this.Phone += "+32 ";
                        this.From = "Belgium";
                        break;
                    case 3:
                        this.Phone += "+1264 ";
                        this.From = "England";
                        break;
                    case 4:
                        this.Phone += "+93 ";
                        this.From = "Afghanistan";
                        break;
                    case 5:
                        this.Phone += "+244 ";
                        this.From = "Angola";
                        break;
                    case 6:
                        this.Phone += "+880 ";
                        this.From = "Bangladesh";
                        break;
                    default:
                        break;
                }
                this.Phone += P;
            }
            public string name => Name;
            public string email => Email;
            public string phone => Phone;
            public string from => From;
        }
        public class CustomItem
        {
            public Canvas AllInfoBlock;
            public Label NameLabel;
            public Label EmailLabel;
            public Label PhoneLablel;
            public Button EditButton;
            public Button DeleteButton;
            public CustomItem(UserInfo UI)
            {
                AllInfoBlock = new Canvas();

                NameLabel = new Label();
                NameLabel.Width = 125;
                NameLabel.Height = 23;
                NameLabel.FontWeight = FontWeights.Bold;
                Canvas.SetLeft(NameLabel, 0);

                EmailLabel = new Label();
                EmailLabel.Width = 125;
                EmailLabel.Height = 23;
                Canvas.SetLeft(EmailLabel, 125);

                PhoneLablel = new Label();
                PhoneLablel.Width = 125;
                PhoneLablel.Height = 23;
                Canvas.SetLeft(PhoneLablel, 250);

                EditButton = new Button();
                EditButton.Width = 40;
                EditButton.Height = 23;
                Canvas.SetLeft(EditButton, 380);

                DeleteButton = new Button();
                DeleteButton.Width = 40;
                DeleteButton.Height = 23;
                Canvas.SetLeft(DeleteButton, 425);

                NameLabel.Content = UI.name;
                EmailLabel.Content = UI.email;
                PhoneLablel.Content = UI.phone;
                EditButton.Content = "Edit";
                DeleteButton.Content = "Delete";
            }
            public void AddInfo(ref ListBox list)
            {
                AllInfoBlock = new Canvas();
                ListBoxItem tmp = new ListBoxItem();
                tmp.Height = 25;
                tmp.Width = 505;
                AllInfoBlock.Children.Add(DeleteButton);
                AllInfoBlock.Children.Add(EditButton);
                AllInfoBlock.Children.Add(PhoneLablel);
                AllInfoBlock.Children.Add(EmailLabel);
                AllInfoBlock.Children.Add(NameLabel);
                tmp.VerticalContentAlignment = VerticalAlignment.Top;
                tmp.Content = AllInfoBlock;
                list.Items.Add(tmp);
            }
            public void EditButtonClick()
            {

            }
            public void DeleteButtonClick()
            {

            }
        }

        List<UserInfo> users = new List<UserInfo>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllUsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NameInfoLab.Content = users[AllUsersList.SelectedIndex].name;
            this.PhoneInfoLab.Content = users[AllUsersList.SelectedIndex].phone;
            this.EmailInfoLab.Content = users[AllUsersList.SelectedIndex].email;
            this.CountryInfoLab.Content = users[AllUsersList.SelectedIndex].from;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var UI = new UserInfo(FirstnameTB.Text, LastNameTB.Text, PersonalEmailTB.Text, PhoneNumberTB.Text, CountryPhoneCB.SelectedIndex);
            var CI = new CustomItem(UI);
            CI.AddInfo(ref AllUsersList);
            users.Add(UI);
        }

        public void CheckSaveButtonStatus()
        {
            if (this.FirstnameTB.Text.Length != 0 && this.LastNameTB.Text.Length != 0 && PersonalEmailTB.Text.Contains("@") != false && CountryPhoneCB.SelectedIndex >= 0)
            {
                switch (this.CountryPhoneCB.SelectedIndex)
                {
                    case 0:
                        if (this.PhoneNumberTB.Text.Length == 9) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 1:
                        if (this.PhoneNumberTB.Text.Length == 9) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 2:
                        if (this.PhoneNumberTB.Text.Length == 8) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 3:
                        if (this.PhoneNumberTB.Text.Length == 6) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 4:
                        if (this.PhoneNumberTB.Text.Length == 7) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 5:
                        if (this.PhoneNumberTB.Text.Length >= 2) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    case 6:
                        if (this.PhoneNumberTB.Text.Length == 8) { this.SaveButton.IsEnabled = true; } else this.SaveButton.IsEnabled = false;
                        break;
                    default:
                        break;
                }
            }
            else
                this.SaveButton.IsEnabled = false;
        }
        
        private void CanselButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PersonalEmailTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckSaveButtonStatus();
        }

        private void LastNameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckSaveButtonStatus();
        }

        private void PhoneNumberTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckSaveButtonStatus();
        }

        private void CountryPhoneCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckSaveButtonStatus();
        }
    }
}
