using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Rent
    {
        private Car _RentedCar;
        private System.DateTime _DateFrom, _DateTo;

        public Rent(Car RentedCar, System.DateTime DateFrom, System.DateTime DateTo)
        {
            _RentedCar = RentedCar;
            _DateFrom = DateFrom;
            _DateTo = DateTo;
        }

        public Car CarToRent
        {
            get
            {
                return _RentedCar;
            }
        }
        public System.DateTime DateFrom
        {
            get
            {
                return _DateFrom;
            }
        }
        public System.DateTime DateTo
        {
            get
            {
                return _DateTo;
            }
        }

        
    }
}
