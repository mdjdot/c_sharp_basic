using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form subForm = new Form_Sub
            {
                MdiParent = this
            };
            Form subForm1 = new Form_Sub
            {
                MdiParent = this
            };

            subForm.Show();
            subForm1.Show();
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Timer_Display_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            else
            {
                Timer_Display.Enabled = false;
            }
        }
    }
}
