using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Racing
{
    class CarObj
    {
        /// <summary>
        /// Представляет из себя машину с водителем, у которой есть координаты
        /// </summary>
        Random random; 
        public double speedCarObj;
        double x, y = 0;
        public Car car;
        Driver driver;

        public CarObj(double x, double y)
        {
            /* initialization */
            this.x = x;
            this.y = y;
            random = new Random();
            // создал обьект машинки со случайными значениями
            car = new Car(RandomModel(), random.Next(0, 3));
            // создал обьект водителя со случайными значениями
            driver = new Driver(RandomName(), (random.Next(0, 1) == 0 ? true : false), (random.Next(2, 3) == 2 ? true : false));
            speedCarObj = CalcFinalSpeed();
        }
        public void DrawCarObj()
        {
           /* отрисовка машины */
        }
        private double CalcFinalSpeed()
        {
            /* вычисление финальной скорости на основе данных о водителе и машине */
             return car.Speed * driver.DriverCoef; // посчитал скорость 
        }
        private string RandomName()
        {
            switch (random.Next(5, 8))
            {
                case 5:
                    return "Alex";
                case 6:
                    return "Ivan";
                case 7:
                    return "Igor";
                case 8:
                    return "Petr";
            }
            return "luzer";
        }
         private string RandomModel()
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "VAZ";
                case 2:
                    return "nisan";
                case 3:
                    return "toyota";
                case 4:
                    return "volga";
            }
            return "luzer";
        }
    }
}
