using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaidHealthKiosk
{
    public partial class UserView : Form
    {
        static int x = 0;

        public UserView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            

        }

        private void UserView_Load(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.Clear();
            
            ControlAdvertisement cc = new ControlAdvertisement();
            tableLayoutPanel.Controls.Add(cc);
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
    }


}
