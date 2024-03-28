namespace Assigment__01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbThang = new System.Windows.Forms.TextBox();
            this.txtbNam = new System.Windows.Forms.TextBox();
            this.txtbSoNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // txtbThang
            // 
            this.txtbThang.Location = new System.Drawing.Point(258, 137);
            this.txtbThang.Multiline = true;
            this.txtbThang.Name = "txtbThang";
            this.txtbThang.Size = new System.Drawing.Size(132, 31);
            this.txtbThang.TabIndex = 3;
            this.txtbThang.TextChanged += new System.EventHandler(this.txtbThang_TextChanged);
            // 
            // txtbNam
            // 
            this.txtbNam.Location = new System.Drawing.Point(258, 195);
            this.txtbNam.Multiline = true;
            this.txtbNam.Name = "txtbNam";
            this.txtbNam.Size = new System.Drawing.Size(132, 31);
            this.txtbNam.TabIndex = 4;
            this.txtbNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // txtbSoNgay
            // 
            this.txtbSoNgay.Enabled = false;
            this.txtbSoNgay.Location = new System.Drawing.Point(258, 249);
            this.txtbSoNgay.Multiline = true;
            this.txtbSoNgay.Name = "txtbSoNgay";
            this.txtbSoNgay.Size = new System.Drawing.Size(132, 31);
            this.txtbSoNgay.TabIndex = 5;
            this.txtbSoNgay.TextChanged += new System.EventHandler(this.txtbSoNgay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ngày\r\n";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(258, 307);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(132, 33);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSoNgay);
            this.Controls.Add(this.txtbNam);
            this.Controls.Add(this.txtbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbThang;
        private System.Windows.Forms.TextBox txtbNam;
        private System.Windows.Forms.TextBox txtbSoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
    }
}