using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HardNaviCarShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTypes : ContentPage, INotifyPropertyChanged
    {
        private List<Type> types;

        public List<Type> Types 
        { 
            get => types;
            set
            {
                types = value;
                OnPropertyChanged();
            } 
        }
        public Type SelectedType { get; set; }
        public PageTypes()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected override void OnAppearing()
        {
            Types = DBInstance.GetInstance().GetAllTypes();
        }

        protected override void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private async void Add(object sender, EventArgs e)
        {
            AddType add = new AddType();
            await Navigation.PushAsync(add);
        }

        private void Edit(object sender, EventArgs e)
        {

        }
    }
}