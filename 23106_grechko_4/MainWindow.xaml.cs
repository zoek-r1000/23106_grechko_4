using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace _23106_grechko_4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormatButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

            string trimmedInput = Regex.Replace(input, @"s+", " ");

            string formatted = string.Join(" ", trimmedInput.Split(' ').Select(word =>
            {
                if (word.Length > 0)
                {
                    return char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
                return "";
            }));

            formatted = formatted.Replace("  ", "это_пробел");

            OutputTextBox.Text = formatted;
        }
    }
}
