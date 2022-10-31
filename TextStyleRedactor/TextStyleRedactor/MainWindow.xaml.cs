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

namespace TextStyleRedactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int StartIndex = 0;
        int EndIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 3; i <= 60; i += 3)
            {
                FontSizeBox.Items.Add(i.ToString());
            }
        }

        private void ButtonBold_Click(object sender, RoutedEventArgs e)
        {
            this.StartIndex += 1; this.EndIndex += 2;
            TextPointer S = AllTextBox.Document.ContentStart.GetPositionAtOffset(StartIndex, LogicalDirection.Forward);
            TextPointer E = AllTextBox.Document.ContentStart.GetPositionAtOffset(EndIndex, LogicalDirection.Forward);
            AllTextBox.Selection.Select(S, E);
            TextSelection tmp = AllTextBox.Selection;
            if (!tmp.IsEmpty)
            {
                tmp.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }

        private void ButtonItalic_Click(object sender, RoutedEventArgs e)
        {
            this.StartIndex += 1; this.EndIndex += 2;
            TextPointer S = AllTextBox.Document.ContentStart.GetPositionAtOffset(StartIndex, LogicalDirection.Forward);
            TextPointer E = AllTextBox.Document.ContentStart.GetPositionAtOffset(EndIndex, LogicalDirection.Forward);
            AllTextBox.Selection.Select(S, E);
            TextSelection tmp = AllTextBox.Selection;
            if (!tmp.IsEmpty)
            {
                tmp.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            }
        }

        private void ButtonUnderline_Click(object sender, RoutedEventArgs e)
        {
            this.StartIndex += 1; this.EndIndex += 2;
            TextPointer S = AllTextBox.Document.ContentStart.GetPositionAtOffset(StartIndex, LogicalDirection.Forward);
            TextPointer E = AllTextBox.Document.ContentStart.GetPositionAtOffset(EndIndex, LogicalDirection.Forward);
            AllTextBox.Selection.Select(S, E);
            TextSelection tmp = AllTextBox.Selection;
            if (!tmp.IsEmpty)
            {
                tmp.ApplyPropertyValue(TextDecoration.LocationProperty, TextDecorations.Underline);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FontSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FontColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (StartText.Text.Length != 0)
                this.StartIndex = Convert.ToInt32(StartText.Text);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (Stoptext.Text.Length != 0)
                this.EndIndex = Convert.ToInt32(Stoptext.Text);
        }
    }
}
