using System;
using System.Collections;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollControl.Controls
{
    public class ScrollViewControl : ScrollView
    {
        public static readonly BindableProperty ItemsSourceProperty =
           BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(ScrollViewControl), default(IEnumerable));

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly BindableProperty ItemTemplateProperty =
            BindableProperty.Create("ItemTemplate", typeof(DataTemplate), typeof(ScrollViewControl), default(DataTemplate));

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public event EventHandler<ItemTappedEventArgs> ItemSelected;

        public static readonly BindableProperty SelectedCommandProperty =
            BindableProperty.Create("SelectedCommand", typeof(ICommand), typeof(ScrollViewControl), null);

        public ICommand SelectedCommand
        {
            get { return (ICommand)GetValue(SelectedCommandProperty); }
            set { SetValue(SelectedCommandProperty, value); }
        }

        public static readonly BindableProperty SelectedCommandParameterProperty =
            BindableProperty.Create("SelectedCommandParameter", typeof(object), typeof(ScrollViewControl), null);

        public object SelectedCommandParameter
        {
            get { return GetValue(SelectedCommandParameterProperty); }
            set { SetValue(SelectedCommandParameterProperty, value); }
        }

        public static readonly BindableProperty ShouldFlexProperty =
        BindableProperty.Create("ShouldFlex", typeof(bool), typeof(ScrollViewControl), false);

        public bool ShouldFlex
        {
            get { return (bool)GetValue(ShouldFlexProperty); }
            set { SetValue(ShouldFlexProperty, value); }
        }

        public void Render()
        {
            if (ItemTemplate == null || ItemsSource == null)
                return;


            if(ShouldFlex)
            {
                var layout = new FlexLayout();

                layout.Direction = FlexDirection.Row;
                layout.Wrap = FlexWrap.Wrap;
                layout.AlignContent = FlexAlignContent.Start;
                layout.JustifyContent = FlexJustify.SpaceBetween;

                foreach (var item in ItemsSource)
                {
                    var viewCell = CreateViewCell(item);
                    layout.Children.Add(viewCell.View);
                }

                Content = layout;
            }
            else
            {
                var layout = new StackLayout();
                layout.Orientation = Orientation == ScrollOrientation.Vertical ? StackOrientation.Vertical : StackOrientation.Horizontal;

                foreach (var item in ItemsSource)
                {
                    var viewCell = CreateViewCell(item);
                    layout.Children.Add(viewCell.View);
                }

                Content = layout;
            }
        }

        private ViewCell CreateViewCell(object item)
        {
            var command = SelectedCommand ?? new Command((obj) =>
            {
                var args = new ItemTappedEventArgs(ItemsSource, item);
                ItemSelected?.Invoke(this, args);
            });
            var commandParameter = SelectedCommandParameter ?? item;

            var viewCell = ItemTemplate.CreateContent() as ViewCell;
            viewCell.View.BindingContext = item;
            viewCell.View.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = command,
                CommandParameter = commandParameter,
                NumberOfTapsRequired = 1
            });

            return viewCell;
        }
    }
}
