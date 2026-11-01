using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР2_Сафронова.FolderForModel;

namespace ЛР2_Сафронова
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();

        List<Table_Motorbike> Motorbikes = DB.Table_Motorbike.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControl11.Fill(Motorbikes[AccNumber]);
            userControl12.Fill(Motorbikes[AccNumber + 1]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)//проверка при нажатии "Листать вправо"
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)//проверка при нажатии "Листать влево"
                AccNumber--;
            else
                return;

            Loading();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }
        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }
        private void ButtonRight_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void ButtonLeft_Click_1(object sender, EventArgs e)
        {

        }
    }
}
