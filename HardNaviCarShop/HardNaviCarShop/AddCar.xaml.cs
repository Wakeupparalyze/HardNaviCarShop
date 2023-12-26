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
	public partial class AddCar : ContentPage
	{
		public Type SelectedType { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public string Info { get; set; }
		public List<Type> Types { get; set; } 
		public AddCar ()
		{
			InitializeComponent();
			Types = DBInstance.GetInstance().GetAllTypes();
			BindingContext = this;
		}

        private void Add(object sender, EventArgs e)
        {
			if (Name != null || SelectedType.Id != 0 || Info != null || Price != 0)
			{
				DBInstance.GetInstance().AddCar(new Car
				{
					Name = Name,
					Info = Info,
					Price= Price,
					IDType = SelectedType.Id
				});
			}
        }
    }
}