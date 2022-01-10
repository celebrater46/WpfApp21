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
using CefSharp.Internals;

namespace WpfApp21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitBrowser();
        }

        private void InitBrowser()
        {
            naviPanel.DataContext = browser;
            back.Command = browser.BackCommand;
            forward.Command = browser.ForwardCommand;

            browser.BrowserSettings.AcceptLanguageList = "en-EN";
        }

        private void GoButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                return;
            }

            if (browser.IsLoaded)
            {
                browser.Load(address.Text);
            }
            else
            {
                browser.Address = address.Text;
            }
        }
    }
}
