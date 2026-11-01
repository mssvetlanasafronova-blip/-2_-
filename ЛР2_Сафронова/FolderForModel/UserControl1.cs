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

namespace ЛР2_Сафронова.FolderForModel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Fill(Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            PictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
