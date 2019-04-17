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
        GameField GF = new GameField();

        public Form1()
        {
            InitializeComponent();
            speedPl1Label.Text = "0 км/ч";
            speedPl2Label.Text = "0 км/ч";
            speedPl3Label.Text = "0 км/ч";
            labelStat1.Text = GF.carObjList.ElementAt(1).driver.GetDriverInfo();
            labelstat2.Text = GF.carObjList[1].driver.GetDriverInfo();
            labelstat3.Text = GF.carObjList[2].driver.GetDriverInfo();
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
            
            speedPl1Label.Text = GF.carObjList[0].speedCarObj.ToString() + " км/ч";
            speedPl2Label.Text = GF.carObjList[1].ToString() + " км/ч";
            speedPl3Label.Text = GF.carObjList[2].ToString() + " км/ч";
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
