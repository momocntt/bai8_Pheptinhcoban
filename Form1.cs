using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_Pheptinhcoban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTinh_Click(object sender, EventArgs e)
        {
            double So1 = double.Parse(txtSo1.Text);
            double So2 = double.Parse(txtSo2.Text);
            if (rdbCong.Checked)
            {
                txtKQ.Text = (So1 + So2).ToString();
            }
            if (rdbTru.Checked)
            {
                txtKQ.Text = (So1 - So2).ToString();
            }
            if (rdbNhan.Checked)
            {
                txtKQ.Text = (So1 * So2).ToString();
            }
            if (rdbChia.Checked)
                if (So2 == 0)
                {
                    txtKQ.Text = " Lỗi chia 0: ";
                }
                else
                {
                    txtKQ.Text = (So1 / So2).ToString();
                }
        }
    }
}
        
