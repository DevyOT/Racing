using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Вернуть готовую сумму посчитаного выйгрыша если проиграл то 0
/// </summary>
namespace Racing
{
    class Bet
    {
        int[] betAmount;
        List<CarObj> listCarObj;
        public double winMoney;

        public Bet(int[] betAmount, List<CarObj> listCarObj)
        {
            this.betAmount = betAmount;
            this.listCarObj = listCarObj;
        }
        public List<CarObj> GetUpdateCarObj()
        {
            if (listCarObj[0].speedCarObj > listCarObj[1].speedCarObj && listCarObj[0].speedCarObj > listCarObj[2].speedCarObj)
            {
                listCarObj[0].driver.win += 1;
                winMoney += betAmount[0] * listCarObj[0].driver.driverRatio;
            }
            else
            {
                listCarObj[0].driver.lose += 1;
            }
            if (listCarObj[1].speedCarObj > listCarObj[0].speedCarObj && listCarObj[1].speedCarObj > listCarObj[2].speedCarObj)
            {
                listCarObj[1].driver.win += 1;
                winMoney += betAmount[1] * 2;
            }
            else
            {
                listCarObj[1].driver.lose += 1;
            }
            if (listCarObj[2].speedCarObj > listCarObj[0].speedCarObj && listCarObj[2].speedCarObj > listCarObj[1].speedCarObj)
            {
                listCarObj[2].driver.win += 1;
                winMoney += betAmount[2] * 2;
            }
            else
            {
                listCarObj[2].driver.lose += 1;
            }
            return listCarObj;
        }
    }
}
