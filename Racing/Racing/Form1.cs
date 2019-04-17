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
        CarObj c1 = new CarObj(0, 0);
        CarObj c2 = new CarObj(0, 0);
        CarObj c3 = new CarObj(0, 0);

        public Form1()
        {
            InitializeComponent();
            speedPl1Label.Text = "0 км/ч";
            speedPl2Label.Text = "0 км/ч";
            speedPl3Label.Text = "0 км/ч";
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
            
            speedPl1Label.Text = c1.speedCarObj.ToString() + " км/ч";
            speedPl2Label.Text = c2.speedCarObj.ToString() + " км/ч";
            speedPl3Label.Text = c3.speedCarObj.ToString() + " км/ч";
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
