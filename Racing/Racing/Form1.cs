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
        public Form1()
        {
            InitializeComponent();

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
        }

        private void speedLabel_Click(object sender, EventArgs e)
        {
            CarObj c = new CarObj(0,0);
            speedLabel.Text = c.speedCarObj.ToString();
        }
    }
}
