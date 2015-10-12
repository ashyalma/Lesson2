using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
 public class Car
 {
            public Car(string name, string description)
            {
                _name = name;
                _description = description;
            }
            public string GetName()
            {
        return _name;
        }
        public string GetDescription()
        {
                return _description;
        }
        private string _name;
        private string _description;
        public override string ToString()
        {
            return _name;
        }
        }
 }
