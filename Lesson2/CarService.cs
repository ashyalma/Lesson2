using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class CarService
    {
        FileDatabase DataBase = new FileDatabase(@"C:\CarRentDatabase");
        List<Rent> ListOfRents = new List <Rent>();
        List<Car> UnavailableCars = new List<Car>();
        List<Car> AvailableCars = new List<Car>();
        Car[] cars = new Car[]
        {
            new Car("БМВ", "Отличная машина"),
            new Car("Мерседес", "Классная машина"),
            new Car("Тойота", "Хорошая машина"),
            new Car("Тесла", "Крутая машина"),
            new Car("Лада","Машина")
        };

        public CarService()
        {
            ListOfRents = DataBase.GetFromDatabase<Rent>().ToList();      
        }

        public List <Car> GetAvailableCars(DateTime FromDate, DateTime ToDate)
        {
            AvailableCars.Clear();
            UnavailableCars.Clear();
            UnavailableCars = GetUnavailableCars(FromDate, ToDate);
            foreach (Car SomeCar in cars)
            {
                if (UnavailableCars.Contains(SomeCar) == false)
                    AvailableCars.Add(SomeCar);
            }

            return (AvailableCars);
        }
        
        public List<Car> GetUnavailableCars(DateTime FromDate, DateTime ToDate)
        {
            UnavailableCars.Clear();
            foreach(Rent _Rent in ListOfRents)
            {
                if (((FromDate >= _Rent.DateFrom) && (FromDate <= _Rent.DateTo)) ||
                    ((ToDate >= _Rent.DateFrom) && (ToDate <= _Rent.DateTo))) 
                    //Если хотя бы 1 из заданных пользователем дат попадает в уже арендованный промежуток
                {
                    UnavailableCars.Add(_Rent.CarToRent);
                }
            }
            return (UnavailableCars);
        }

        public void MakeRent(Rent NewRent)
        {
            ListOfRents.Add(NewRent);
            DataBase.SaveToDatabase<Rent>(ListOfRents.ToArray());
        }
    }
}
