using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace WPF_textfinder
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                TextRange doc = new TextRange(rtb_text.Document.ContentStart, rtb_text.Document.ContentEnd);
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                        doc.Load(fs, DataFormats.Rtf);
                    else if (Path.GetExtension(ofd.FileName).ToLower() == ".txt")
                        doc.Load(fs, DataFormats.Text);
                    else
                        doc.Load(fs, DataFormats.Xaml);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void SearchInTxt(string fileLocation, string keyWord)
        {
            string str = File.ReadAllText(fileLocation);

            var splitText = str.Split(new Char[] { ' ', '.', ',', ':', '\t' }).ToList();

            foreach (string s in splitText)
            {
                if (s.Trim() != "" && Regex.IsMatch(s, keyWord))
                {
                    TextRange textRange = new TextRange(rtb_text.Document.ContentStart, rtb_text.Document.ContentEnd);

                    textRange.Load(splitText[splitText.IndexOf(keyWord) + 1] + " " + splitText[splitText.IndexOf(keyWord) + 3]);
                    break;
                }
            }
        }
    }
}
