using System;
using System.Globalization;
using System.Windows.Input;
using DemoChat.Models;
using MvvmHelpers;
using Xamarin.Forms;

namespace DemoChat.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Message> ListMessages { get; }
        public ICommand SendCommand { get; set; }


        public MainPageViewModel()
        {

            ListMessages = new ObservableRangeCollection<Message>();

            SendCommand = new Command(() =>
            {
                if (!String.IsNullOrWhiteSpace(OutText))
                {
                    var message = new Message
                    {
                        Text = OutText,
                        IsTextIn = false,
                        IsInfoMessage = false,
                        MessageDateTime = DateTime.Now
                    };

                    var messageIn = new Message
                    {
                        Text = OutText,
                        IsTextIn = true,
                        IsInfoMessage = false,
                        MessageDateTime = DateTime.Now
                    };

                    var messageInfo = new Message
                    {
                        Text = "Der Nutzer möchte nicht kontaktiert werden",
                        IsTextIn = false,
                        IsInfoMessage = true,
                    };


                    ListMessages.Add(message);
                    ListMessages.Add(messageIn);
                    ListMessages.Add(messageInfo);
                    OutText = "";
                }

            });
            
        }


        public string OutText
        {
            get { return _outText; }
            set { SetProperty(ref _outText, value); }
        }
        string _outText = string.Empty;
    }
}
