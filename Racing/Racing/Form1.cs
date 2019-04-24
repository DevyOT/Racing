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
            CreateNewRace(false);
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
           CreateNewRace(true);
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
           
        }
        private void CreateNewRace(bool buttonClick)
        {
            /* инициализация новой гонки */
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
            if ((Convert.ToInt32(tbPlayer1.Text) + Convert.ToInt32(tbPlayer2.Text) + Convert.ToInt32(tbPlayer3.Text)) <= player.money)
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


                player.money = player.money - Convert.ToInt32(tbPlayer1.Text) - Convert.ToInt32(tbPlayer2.Text) - Convert.ToInt32(tbPlayer3.Text);
                if (buttonClick)
                {
                    int victory = 0;
                    Bet bet1 = new Bet(Convert.ToInt32(tbPlayer1.Text), listCarObj[0].speedCarObj, victory);
                    Bet bet2 = new Bet(Convert.ToInt32(tbPlayer2.Text), listCarObj[1].speedCarObj, victory);
                    Bet bet3 = new Bet(Convert.ToInt32(tbPlayer3.Text), listCarObj[2].speedCarObj, victory);
                    player.money += Convert.ToInt32(bet1.PaymentRatiio())+Convert.ToInt32(bet2.PaymentRatiio())+Convert.ToInt32(bet3.PaymentRatiio());
                }

                labelRating.Text = "Рейтинг: " + player.rating.ToString();
                labelMoney.Text = player.money.ToString() + " $";
            }
            else
            {
                MessageBox.Show("Не достаточно средств!");
            }

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
