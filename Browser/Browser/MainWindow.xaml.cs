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

namespace Browser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            webBrowser.Width = this.Width;
            webBrowser.Height = this.Height;
        }

        private void IimportantButton_Click(object sender, RoutedEventArgs e)
        {
            importantComboBox.Items.Add(webBrowser.Source);
        }

        private void ImportantComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            webBrowser.Source = new Uri(importantComboBox.SelectedItem.ToString());
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
                webBrowser.Source = new Uri(adressTextBox.Text);
        }
    }
}
