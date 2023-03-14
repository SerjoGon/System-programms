using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace WPF_text_parser
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem()
                {
                    Header = drive,
                    Tag = drive
                };
                item.Items.Add(null);
                item.Expanded += Folder_Expanded;
                FolderTree.Items.Add(item);
            }
        }
        #region FolderExtended
        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;
            if (item.Items.Count != 1 || item.Items[0] != null) return;
            item.Items.Clear();
            var fullPath = (string)item.Tag;
            #region folderGet
            var directories = new List<string>();
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch (Exception ex) { }
            directories.ForEach(directoryPath =>
            {
                var subitem = new TreeViewItem()
                {
                    Header = GetFileFolderName(directoryPath),
                    Tag = directoryPath
                };
                subitem.Items.Add(null);
                subitem.Expanded += Folder_Expanded;
                item.Items.Add(subitem);
            });
            #endregion
            #region GetFiles
            var files = new List<string>();
            try
            {
                var fs = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                    files.AddRange(fs);
            }
            catch (Exception ex) { }
            files.ForEach(filePath =>
            {
                var subitem = new TreeViewItem()
                {
                    Header = GetFileFolderName(filePath),
                    Tag = filePath
                };
                item.Items.Add(subitem);
            });
            #endregion

        }
        #endregion
        public static string GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
                return string.Empty;
            var normPath = path.Replace('/', '\\');
            var lastindex = normPath.LastIndexOf('\\');
            if (lastindex <= 0)
                return path;
            return path.Substring(lastindex + 1);
        }
        public void Converter()
        {
            try
            {
            string path = FolderTree.SelectedItem.ToString();
            TextRange doc = new TextRange(rtb_1.Document.ContentStart, rtb_1.Document.ContentEnd);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                doc.Load(fs, DataFormats.Text);
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Converter();
        }
    }
}
