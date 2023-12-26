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
    public partial class PageCars : ContentPage, INotifyPropertyChanged
    {
        private List<Car> cars = new List<Car>();

        public List<Car> Cars 
        { 
            get => cars;
            set 
            { 
                cars = value;
                OnPropertyChanged();
            }
        }
        public PageCars()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected override void OnAppearing()
        {
            Cars = new List<Car>();
            Cars = DBInstance.GetInstance().GetAllCars();
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private async void Add(object sender, EventArgs e)
        {
            AddCar add = new AddCar();
            await Navigation.PushAsync(add);
        }

        private async void EditCar(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Car car = button.BindingContext as Car;
            if (car == null)
                return;
            await Shell.Current.GoToAsync($"Cars?SelectedCarId={car.Id}");
        }
    }
}