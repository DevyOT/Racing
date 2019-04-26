using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form1 : Form
    {
        GameField GF;
        List<CarObj> listCarObj;
        Player player;
        public Form1()
        {
            
            player = new Player(1000, 0, "Player");
            InitializeComponent();
            FieldInicilization();
            labelName.Text = "Имя: " + player.name;
            speedPl1Label.Text = "0 км/ч";
            speedPl2Label.Text = "0 км/ч";
            speedPl3Label.Text = "0 км/ч";
            tbPlayer1.Text = "0";
            tbPlayer2.Text = "0";
            tbPlayer3.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameField_Enter(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           CreateNewRace();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
           
        }
        private void ZeroCheck()
        {
            if (tbPlayer1.Text == "")
            {
                tbPlayer1.Text = "0";
            }
            if (tbPlayer2.Text == "")
            {
                tbPlayer2.Text = "0";
            }
            if (tbPlayer3.Text == "")
            {
                tbPlayer3.Text = "0";
            }
        }

        private void CreateNewRace()
        {
            /* инициализация новой гонки */
            ZeroCheck();
            int[] betFields = { Convert.ToInt32(tbPlayer1.Text), Convert.ToInt32(tbPlayer2.Text), Convert.ToInt32(tbPlayer3.Text) };
            
            if (betFields.Sum() <= player.money)
            {
                player.money -= betFields.Sum();

                Bet bet = new Bet(betFields,listCarObj);
                  
               
                listCarObj = bet.GetUpdateCarObj();
                player.money += bet.winMoney;
                FieldInicilization();
            }
            else
            {
                MessageBox.Show("Не достаточно средств!");
            }

        }
       
        private void FieldInicilization ()
        {
            GF = new GameField();
            listCarObj = GF.GetCarObjs();

            speedPl1Label.Text = listCarObj[0].speedCarObj.ToString() + " км/ч";
            speedPl2Label.Text = listCarObj[1].speedCarObj.ToString() + " км/ч";
            speedPl3Label.Text = listCarObj[2].speedCarObj.ToString() + " км/ч";

            labelStat1.Text = listCarObj[0].driver.GetDriverInfo();
            labelstat2.Text = listCarObj[1].driver.GetDriverInfo();
            labelstat3.Text = listCarObj[2].driver.GetDriverInfo();

            Player1.Text = listCarObj[0].driver.name + " - " + listCarObj[0].car.model;
            Player2.Text = listCarObj[1].driver.name + " - " + listCarObj[1].car.model;
            Player3.Text = listCarObj[2].driver.name + " - " + listCarObj[2].car.model;

            labelRating.Text = "Рейтинг: " + player.rating.ToString();
            labelMoney.Text = player.money.ToString() + " $";
        }

        private void speedPl2Label_Click(object sender, EventArgs e)
        {
           
        }

        private void speedPl1Label_Click(object sender, EventArgs e)
        {
            
        }

        private void speedPl3Label_Click(object sender, EventArgs e)
        {
           
        }

        private void tbPlayer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbPlayer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbPlayer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number !=8)
            {
                e.Handled = true;
            }
        }
    }
}
