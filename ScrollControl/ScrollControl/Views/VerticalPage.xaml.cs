using ScrollControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollControl.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerticalPage : ContentPage
	{
		public VerticalPage ()
		{
			InitializeComponent ();

            BindingContext = new ListViewModel();
		}
	}
}