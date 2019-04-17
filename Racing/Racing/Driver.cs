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

        public double speedDrave;

        int exp = 0;
        int quantityVictory = 0;
        int quantityDefeat = 0;
       
        bool isDrunk = false;
        bool driverLicence = true;

        string name;

        double driverLicenceCoef;
        double drunkPromili;

        public Driver(string name, bool isDrunk, bool driverLicence)
        {
            /* initialization */
            this.name = name;
            this.isDrunk = isDrunk;
            this.driverLicence = driverLicence;
            this.speedDrave = CalcCoef();
        }

        public double CalcCoef()
        {
            /* возвращает коэфициент водителя */
            driverLicenceCoef = driverLicence == true ? 0.5 : 0.1;
            drunkPromili = isDrunk == true ? 0.5 : 0.1;

            /* возвращает коэфициент водителя */
            switch (name)
            {
                case "Alex": return 0.2 + driverLicenceCoef + drunkPromili;
                case "Ivan": return 0.3 + driverLicenceCoef + drunkPromili;
                case "Igor": return 0.4 + driverLicenceCoef + drunkPromili;
                case "Petr": return 0.5 + driverLicenceCoef + drunkPromili;
            }
            return 0.1;
        }
        public string GetDriverInfo()
        {

            /* возвращает данные о водителе */
            string drunkStr = isDrunk == true ? "бухой" : "трезвый";
            string driverLicenceStr = driverLicence == true ? "ecть" : "отсутствуют";
            
            return $"Имя: {name}.  Опыт: {exp} Кол-во побед: {quantityVictory} Кол-во порожений: {quantityDefeat}  Водитель {drunkStr}. Права {driverLicenceStr}.";
        }
    }
}
