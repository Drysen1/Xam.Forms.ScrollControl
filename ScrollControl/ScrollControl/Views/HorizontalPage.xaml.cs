using ScrollControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollControl
{
	public partial class HorizontalPage : ContentPage
	{
		public HorizontalPage()
		{
			InitializeComponent();
            BindingContext = new ListViewModel();
		}
	}
}
