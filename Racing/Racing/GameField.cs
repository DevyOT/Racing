using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class GameField
    {
        List<CarObj> carObjList =new List<CarObj>();
        public GameField()
        {
            /* initialization */
        }
        public void GetCarObjs()
        {
            /* вернуть массив машин участвующих в гонке */
            CarObj Player1 = new CarObj(0, 0);
            CarObj Player2 = new CarObj(0, 0);
            CarObj Player3 = new CarObj(0, 0);
            carObjList.Add(Player1);
            carObjList.Add(Player2);
            carObjList.Add(Player3);
            
        }
    }
}
