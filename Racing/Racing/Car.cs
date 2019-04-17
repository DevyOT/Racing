using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class Car
    {
        /// <summary>
        /// Свойства: 
        /// покрышки {лысые = 0, потертые = 1, новые = 2},
        /// модель,
        /// скорость. 
        /// </summary>
        string model = "";
        int tires = 2;
        public double Speed;

        public Car(string model, int tires)
        {
            /* initialization */
            this.model = model;
            this.tires = tires;
            this.Speed = CalcSpeed(); 
        }
        private double CalcSpeed()
        {
            /* вычисление скорости машины */
            switch (model)
            {
                case "VAZ": return 0.2 + tires;
                case "nisan": return 0.4 + tires;
                case "toyota": return 0.8 + tires;
                case "volga": return 0.3 + tires;
            }
            return 0.1;
        }
    }
}
