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
using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Globalization;

namespace Class_Work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string file_name = null;
        string text_buffer = null;
        public MainWindow()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click1_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;
            if (open.ShowDialog() ?? false)
            {
                System.IO.StreamReader reader =
                System.IO.File.OpenText(open.FileName);
                text_box1.AppendText(reader.ReadToEnd());
                file_name = open.FileName;
                reader.Close();
            }
        }
        private void MenuItem_Click1_2(object sender, RoutedEventArgs e)
        {
            var tmp = new TextRange(text_box1.Document.ContentStart, text_box1.Document.ContentEnd);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(file_name);
            sw.WriteLine(tmp.Text);
            sw.Close();
        }
        private void MenuItem_Click1_3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() ?? false)
            {
                var tmp = new TextRange(text_box1.Document.ContentStart, text_box1.Document.ContentEnd);
                System.IO.StreamWriter writer = new System.IO.StreamWriter(save.FileName);
                writer.Write(tmp.Text);
                writer.Close();
            }
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
              
        }
        private void MenuItem_Click2_1(object sender, RoutedEventArgs e)
        {

        }
        
        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click3_1(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text_box1.HorizontalAlignment = HorizontalAlignment.Left;
            //this.text_box.TextAlignment = TextAlignment.Left;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.text_buffer = text_box1.Selection.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text_box1.Selection.Text = this.text_buffer; ;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.text_buffer = "";
            text_box1.Selection.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text_box1.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //this.text_box.TextAlignment = TextAlignment.Right;
            text_box1.HorizontalAlignment = HorizontalAlignment.Right;
        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    int L = text_box.GetLineIndexFromCharacterIndex(text_box.CaretIndex);
        //    int C = text_box.CaretIndex - text_box.GetLineIndexFromCharacterIndex(L);
        //    this.LNum.Text = L.ToString(); this.Cnum.Text = C.ToString(); 
        //}

        private void text_box1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int C = Math.Max(new TextRange(text_box1.CaretPosition.GetLineStartPosition(0),
                text_box1.CaretPosition).Text.Length + 1, 1);
            this.Cnum.Text = C.ToString();
        }

        public void ChangeLang()
        {
            FIleCl.Header = LangResource.File;
            OpenCl.Header = LangResource.Open;
            SaveCl.Header = LangResource.Save;
            SavAsCl.Header = LangResource.Save_as;
            EditCl.Header = LangResource.Edit;
            FormatCl.Header = LangResource.Format;
        }

        private void LanguageSetting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (LanguageSetting.SelectedIndex)
            {
                case 0:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                    ChangeLang();
                    break;
                case 1:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                    ChangeLang();
                    break;
                case 2:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
                    ChangeLang();
                    break;
                case 3:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
                    ChangeLang();
                    break;
                default:
                    break;
            }
        }
    }
}
