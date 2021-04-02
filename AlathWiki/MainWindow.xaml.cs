#region header

// AlathWiki - MainWindow.xaml.cs
// 
// Created by: Alistair J R Young (avatar) at 2021/04/02 1:51 AM.

#endregion

#region using

using System.Windows;

using ArkaneSystems.AlathWiki.Core;

#endregion

namespace ArkaneSystems.AlathWiki.Desktop
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            this.InitializeComponent ();
        }

        // When the Window is loaded...
        private async void OnWindowLoaded (object sender, RoutedEventArgs e)
        {
            // Load the initial page.
            await this.WikiPage.EnsureCoreWebView2Async ();
            this.WikiPage.NavigateToString (htmlContent: HtmlResources.InitialPage);
        }
    }
}
