using DemoChat.CustomCells;
using DemoChat.Models;
using Xamarin.Forms;

namespace DemoChat
{
    public class SelectorDataTemplate : DataTemplateSelector
    {
        private readonly DataTemplate textInDataTemplate;
        private readonly DataTemplate textOutDataTemplate;
        private readonly DataTemplate InformationMessageDataTemplate;


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Message;
            if (messageVm == null)
                return null;
            if (messageVm.IsInfoMessage == true)
            {
                return this.InformationMessageDataTemplate;
            }
            else
            {
                return messageVm.IsTextIn ? this.textInDataTemplate : this.textOutDataTemplate;
            }
        }


        public SelectorDataTemplate()
        {
            this.textInDataTemplate = new DataTemplate(typeof(TextInViewCell));
            this.textOutDataTemplate = new DataTemplate(typeof(TextOutViewCell));
            this.InformationMessageDataTemplate = new DataTemplate(typeof(InformationMessageViewCell));
        }

    }
}
