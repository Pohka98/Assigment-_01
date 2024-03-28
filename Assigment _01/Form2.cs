using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment__01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtbThang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbSoNgay_TextChanged(object sender, EventArgs e)
        {
            // khai bao
            string thang = "";
            string nam = "";
            string ngay = "";
            int soThang = 0;
            int soNam = 0;
            int soNgay = 0;

            // lay ket qua
            thang = txtbThang.Text;
            nam = txtbNam.Text;
            ngay = txtbSoNgay.Text;


            if (thang.Length == 0 || nam.Length == 0)
            {
                MessageBox.Show("Nhập số dô");
                txtbThang.Focus();
                txtbNam.Focus();
                return;
            }

            soThang =  int.Parse(thang);
            soNam = int.Parse(nam);


           /*if(thang.Length == 1)
            {
                switch(thang)
                {
                    case 1: 
                }
            }
           */

        }
    }
}
