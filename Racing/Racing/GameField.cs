using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class GameField
    {
        public List<CarObj> carObjList =new List<CarObj>();
        public GameField()
        {
            /* initialization */
        }
        private void GetCarObjs()
        {
            /* вернуть массив машин участвующих в гонке */
            CarObj objPlayer1 = new CarObj(0, 0);
            CarObj objPlayer2 = new CarObj(0, 0);
            CarObj objPlayer3 = new CarObj(0, 0);
            carObjList.Add(objPlayer1);
            carObjList.Add(objPlayer2);
            carObjList.Add(objPlayer3);
            
        }
    }
}
