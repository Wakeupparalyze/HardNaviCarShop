using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Xamarin.Forms;

namespace HardNaviCarShop
{
    public class DB
    {
        public List<Car> GetAllCars()
        {
            return new List<Car>(App.DB.Cars).ToList();
        }
        
        public List<Type> GetAllTypes()
        {
            return new List<Type>(App.DB.Types).ToList();
        }

        public void AddCar(Car car)
        {
            App.DB.Cars.Add(car);
            App.DB.SaveChanges();
        }
        
        public void AddType(Type type)
        {
            App.DB.Types.Add(type);
            App.DB.SaveChanges();
        }

        public Car FindCarForId(int id)
        {
            return App.DB.Cars.FirstOrDefault(s => s.Id == id);
        }
        
        public Type FindTypeForId(int id)
        {
            return App.DB.Types.FirstOrDefault(s => s.Id == id);
        }

        public void RemoveCar(Car car)
        {
            App.DB.Cars.Remove(car);
            App.DB.SaveChanges();
        }
        
        public void RemoveType(Type type)
        {
            App.DB.Types.Remove(type);
            App.DB.SaveChanges();
        }

        public void EditCar(Car newEditCar)
        {
            Car oldCarToEdit = FindCarForId(newEditCar.Id);
            App.DB.Entry(oldCarToEdit).CurrentValues.SetValues(newEditCar);
            App.DB.SaveChanges();
        }
        
        public void EditType(Type newEditType)
        {
            Type oldTypeToEdit = FindTypeForId(newEditType.Id);
            App.DB.Entry(oldTypeToEdit).CurrentValues.SetValues(newEditType);
            App.DB.SaveChanges();
        }
    }
}
