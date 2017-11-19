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

namespace App1
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

        private void Button_Click_Parent(object sender, RoutedEventArgs e)
        {
            Frame toParent = Window.Current.Content as Frame;
            toParent.Navigate(typeof(ParentPage));
            //this.Frame.Navigate(typeof(ParentPage), null);
        }

        private void Button_Click_Teacher(object sender, RoutedEventArgs e)
        {
            Frame toTeacher = Window.Current.Content as Frame;
            toTeacher.Navigate(typeof(TeacherPage));
        }

        private void Button_Click_Friend(object sender, RoutedEventArgs e)
        {
            Frame toFriend = Window.Current.Content as Frame;
            toFriend.Navigate(typeof(FriendPage));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
