using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HardNaviCarShop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddType : ContentPage
	{
		public string Name { get; set; }
		public AddType ()
		{
			InitializeComponent ();
			BindingContext = this;
		}

        private void Add(object sender, EventArgs e)
        {
			DBInstance.GetInstance().AddType(new Type
			{
				Name = Name
			});
        }
    }
}