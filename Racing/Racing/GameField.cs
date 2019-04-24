using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class GameField
    {
        private List<CarObj> carObjList;
        
        public GameField()
        {
            /* initialization */
            carObjList = new List<CarObj>();
            CarObj objPlayer1 = new CarObj(0, 0);
            CarObj objPlayer2 = new CarObj(0, 0);
            CarObj objPlayer3 = new CarObj(0, 0);
            carObjList.Add(objPlayer1);
            carObjList.Add(objPlayer2);
            carObjList.Add(objPlayer3);
        }
        public List<CarObj> GetCarObjs()
        {
            /* вернуть массив машин участвующих в гонке */
            return carObjList;
        }
    }
}
