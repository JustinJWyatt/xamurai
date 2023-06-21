using Xamarin.Forms;

namespace Xamurai.DataTemplateSelectors
{
    public class CarDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CarView { get; set; }
        public DataTemplate NonCarView { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Car)item).Make == CarMake.Mercedes ? NonCarView : CarView;
        }
    }
}
