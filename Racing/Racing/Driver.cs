using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class Driver
    {
        /// <summary>
        /// Свойства: 
        /// есть или нет права,
        /// опыт,
        /// победы,
        /// поражения,
        /// имя,
        /// пьяный или нет,
        /// имя
        /// скорость. 
        /// </summary>

        public double DriverCoef;

        double exp = 0;
        int win = 0;
        int lose = 0;
       
        bool isDrunk = false;
        bool driverLicence = true;

        string name;

        public Driver(string name, bool isDrunk, bool driverLicence)
        {
            /* initialization */
            this.name = name;
            this.isDrunk = isDrunk;
            this.driverLicence = driverLicence;
            this.DriverCoef = CalcCoef();
            
        }

        private double CalcCoef()
        {
            /* возвращает коэфициент водителя */
            double driverLicenceCoef = driverLicence == true ? 0.5 : 0.1;
            double drunkPromili = isDrunk == true ? 0.5 : 0.1;
            Random r = new Random();
            exp = r.Next(0,20);
            /* возвращает коэфициент водителя */
            switch (name)
            {
                case "Alex": return 0.2 + driverLicenceCoef + drunkPromili + exp;
                case "Ivan": return 0.3 + driverLicenceCoef + drunkPromili + exp;
                case "Igor": return 0.4 + driverLicenceCoef + drunkPromili + exp;
                case "Petr": return 0.5 + driverLicenceCoef + drunkPromili + exp;
                default: return 0.1;
            }
        }
        public string GetDriverInfo()
        {
            /* возвращает данные о водителе */
            return $"Опыт: {exp} Кол-во побед: {win} Кол-во поражений: {lose}";
        }
    }
}
