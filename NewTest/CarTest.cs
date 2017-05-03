using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest
{
    class CarTest
    {
        private string _model;
        private double _price;
        private string _licensplate;

        public CarTest(string model, double price, string licensplate)
        {
            _model = model;
            _price = price;
            _licensplate = licensplate;
        }

        public string Model { get; }
    }
}
