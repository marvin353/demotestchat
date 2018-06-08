using System;
using System.Collections.Generic;
using DemoChat.ViewModels;
using Xamarin.Forms;

namespace DemoChat.Views
{
    public partial class MainChatPageMonkey : ContentPage
    {

        MainPageViewModel vm;

        public MainChatPageMonkey()
        {
            InitializeComponent();
            Title = "Chat";
            BindingContext = vm = new MainPageViewModel();


            vm.ListMessages.CollectionChanged += (sender, e) =>
            {
                var target = vm.ListMessages[vm.ListMessages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };
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
