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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Split
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
         
            this.InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mySplit.IsPaneOpen = !mySplit.IsPaneOpen;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainAppFrame.CanGoBack)
            {
                MainAppFrame.GoBack();
            }
        }
        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainAppFrame.CanGoForward)
            {
                MainAppFrame.GoForward();
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            switch (lb.SelectedIndex)
            {
                case 0:
                    {
                        MainAppFrame.Navigate(typeof(Pages.Page1));
                        break;
                    }
                case 1:
                    {
                        MainAppFrame.Navigate(typeof(Pages.Page2));
                        break;
                    }
                case 2:
                    {
                        MainAppFrame.Navigate(typeof(Pages.Page3));
                        break;
                    }
            }
        }
    }
}
