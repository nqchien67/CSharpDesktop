using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang.GUI
{
    public partial class frnMessage : Form
    {
        public frnMessage(string message, string buttonText1, string buttonText2)
        {
            InitializeComponent();

            label1.Text = message;
            button1.Text = buttonText1;
            button2.Text = buttonText2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Dispose();
        }
    }
}
