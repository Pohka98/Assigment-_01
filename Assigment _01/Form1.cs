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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resualt = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // Xử lý kết quả lựa chọn
            switch (resualt)
            {
                case DialogResult.Yes:
                    // Thoát chương trình
                    Application.Exit();
                    break;
                case DialogResult.No:
                    // Đóng hộp thoại
                    break;
            }

        }

        private void txtbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbB_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnKetQua_Click(object sender, EventArgs e)
        {

            //khai bao bien
            string a = "";
            string b = "";
            string ketQua = "";
            float soA = 0;
            float soB = 0;
            float ketQuaAB = 0;
            //Lấy thông tin a,b,ketqua
            a = txtbA.Text;
            b = txtbB.Text;
            ketQua = txtKetQua.Text;
            //Thong bao kiem tra

            if (a.Length == 0)
            {
                MessageBox.Show("Tôi yêu cầu bạn nhập số a vào");

                //Di chuyen chuot vao txtbA
                txtbA.Focus();
                return;
            }
            if (b.Length == 0)
            {
                MessageBox.Show("Tôi yêu cầu bạn nhập số b vào");

                //Di chuyen chuot vao txtbA
                txtbB.Focus();
                return;
            }

            //Chuyen thanh dang so
            soA = float.Parse(a);
            soB = float.Parse(b);
            //Kiem tra a
            if (soA == 0)
            {
                MessageBox.Show("Tôi yêu cầu bạn học lại kiến thức!");
                txtbA.Focus();
                return;
            }
            ketQuaAB = (- soB ) /( soA);

            txtKetQua.Text = ketQuaAB.ToString();
        }

        private void txtketQua_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
