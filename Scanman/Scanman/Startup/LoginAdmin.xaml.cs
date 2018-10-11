using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Scanman
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginAdmin : Page
    {
        public LoginAdmin()
        {
            this.InitializeComponent();
        }
        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            var grid = this.Frame.Parent as Grid;
            var page = grid.Parent as LoginControl;
            var mainframe = page.Parent as Frame;
            mainframe.Navigate(typeof(AdminConsolePage));
        }

        private void LoginCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginHome));
        }
    }
}
