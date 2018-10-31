using ScrollControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScrollControl.CustomCells
{
    public class RedGreenCellTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate _redCell;
        private readonly DataTemplate _greenCell;

        public RedGreenCellTemplateSelector()
        {
            _redCell = new DataTemplate(typeof(RedCell));
            _greenCell = new DataTemplate(typeof(GreenCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as GreenRedModel;

            return model.IsRedCell ? _redCell : _greenCell;
        }
    }
}
