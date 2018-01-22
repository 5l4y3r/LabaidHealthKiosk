using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidHealthKiosk
{
    public partial class ControlAdvertisement : UserControl
    {
        public ControlAdvertisement()
        {
            InitializeComponent();
            timerAdvertise.Start();
        }
       static string s = @"C:\Users\Lenovo\documents\visual studio 2015\Projects\LabaidHealthKiosk\LabaidHealthKiosk\Resources\";
        string[] pictureBoxArray = new string[] { s+"ss.jpg", s+"labaid1.jpg",s+"labaid2.jpg",s+"labaid3.jpg" };

        int pctIndex = 0;

        private void timerAdvertise_Tick(object sender, EventArgs e)
        {

            pictureBoxAdvertise.ImageLocation = pictureBoxArray[pctIndex];
            pctIndex++;
            if (pctIndex == pictureBoxArray.Length)
                pctIndex = 0;
        }

        private void pictureBoxAdvertise_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlWelcome cc = new ControlWelcome();
            this.Controls.Add(cc);
            cc.Show();
            cc.Dock = DockStyle.Fill;

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void AdvertisementPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
