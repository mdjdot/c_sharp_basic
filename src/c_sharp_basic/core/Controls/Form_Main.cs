using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form_Main : Form
    {
        int count;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void LB_Count_Click(object sender, EventArgs e)
        {
            TXT_Count.Focus();
        }

        private void BTN_Submmit_Click(object sender, EventArgs e)
        {

        }

        private void TXT_Count_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Count.Text.Length > 0)
            {
                if (!int.TryParse(TXT_Count.Text, out count))
                {
                    //Tip_Count.SetToolTip(TXT_Count, "提示");
                    Tip_Count.Show("商品数量必须是大于0的整数", TXT_Count, 1000);
                }
                else
                {
                    BTN_Submmit.Enabled = true;
                }
            }
            else
            {
                BTN_Submmit.Enabled = false;
            }
        }

        private void BTN_Books_Click(object sender, EventArgs e)
        {
            if (TXT_Books.Text.Length > 0)
            {
                foreach (ListViewItem item in LV_Books.Items)
                {
                    if (item.Text == TXT_Books.Text)
                    {
                        MessageBox.Show("书籍已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                LV_Books.Items.Add(TXT_Books.Text);

            }
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Timer_Process.Enabled = true;
            BTN_Start.Enabled = false;
            BTN_Pause.Enabled = true;
            BTN_Stop.Enabled = true;
        }

        private void BTN_Pause_Click(object sender, EventArgs e)
        {
            Timer_Process.Enabled = false;
            BTN_Pause.Enabled = false;
            BTN_Start.Enabled = true;
        }

        private void Timer_Process_Tick(object sender, EventArgs e)
        {
            if (PB_Process.Value < PB_Process.Maximum)
            {
                PB_Process.Value++;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            Timer_Process.Enabled = false;
            PB_Process.Value = 0;
            BTN_Pause.Enabled = false;
            BTN_Stop.Enabled = false;
            BTN_Start.Enabled = true;
        }
    }
}
