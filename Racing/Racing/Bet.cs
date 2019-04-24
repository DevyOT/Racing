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
        int betAmount;
        double ratio;
        int victory;

        public Bet(int betAmount, double ratio, int victory)
        {
            this.betAmount = betAmount;
            this.ratio = ratio;
            this.victory = victory;
        }
        public double PaymentRatiio()
        {
            if(betAmount == 0)
            {
                return 0;
            }
            if(victory == 0)
            {
                return 0;
            }
            return betAmount + victory + ratio;
        }
    }
}
