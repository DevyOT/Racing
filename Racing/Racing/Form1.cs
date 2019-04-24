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
        public Form1()
        {
            InitializeComponent();
            CreateNewRace();
            speedPl1Label.Text = "0 км/ч";
            speedPl2Label.Text = "0 км/ч";
            speedPl3Label.Text = "0 км/ч";
            labelMoney.Text = "0 $";
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
        private void CreateNewRace()
        {
            /* инициализация новой гонки */
            GF = new GameField();
            listCarObj = GF.GetCarObjs();
            speedPl1Label.Text = listCarObj[0].speedCarObj.ToString() + " км/ч";
            speedPl2Label.Text = listCarObj[1].speedCarObj.ToString() + " км/ч";
            speedPl3Label.Text = listCarObj[2].speedCarObj.ToString() + " км/ч";
            labelStat1.Text = listCarObj[0].driver.GetDriverInfo();
            labelstat2.Text = listCarObj[1].driver.GetDriverInfo();
            labelstat3.Text = listCarObj[2].driver.GetDriverInfo();
            Player1.Text = listCarObj[0].driver.name +" - "+ listCarObj[0].car.model;
            Player2.Text = listCarObj[1].driver.name + " - " + listCarObj[1].car.model;
            Player3.Text = listCarObj[2].driver.name + " - " + listCarObj[2].car.model;
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
    }
}
