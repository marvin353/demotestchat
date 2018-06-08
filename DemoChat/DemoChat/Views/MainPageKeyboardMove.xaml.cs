using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DemoChat.ViewModels;

namespace DemoChat.Views
{
    public partial class MainPageKeyboardMove : ContentPage
    {
        MainPageViewModel vm;
        public MainPageKeyboardMove()
        {
            InitializeComponent();

            BindingContext = vm = new MainPageViewModel();

            vm.ListMessages.CollectionChanged += (sender, e) =>
            {
                var target = vm.ListMessages[vm.ListMessages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            DisplayAlert("Test", "Tap is working.", "OK");
        }

        void MyListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MessagesListView.SelectedItem = null;
        }

        void MyListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagesListView.SelectedItem = null;

        }
    }
}




/*
namespace KeyboardOverlapDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            DisplayAlert("Test", "Tap is working.", "OK");
        }
    }
}
*/