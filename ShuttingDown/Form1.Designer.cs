namespace ShuttingDown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChucNang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTGConLai = new System.Windows.Forms.Label();
            this.labelThoiGianHienTai = new System.Windows.Forms.Label();
            this.nbuPhut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbuGio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxnhacNho = new System.Windows.Forms.CheckBox();
            this.numericUpDownNhacNho = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNhacNho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChucNang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng của công cụ";
            // 
            // cmbChucNang
            // 
            this.cmbChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucNang.FormattingEnabled = true;
            this.cmbChucNang.Items.AddRange(new object[] {
            "Tắt máy",
            "Khởi động lại"});
            this.cmbChucNang.Location = new System.Drawing.Point(93, 24);
            this.cmbChucNang.Name = "cmbChucNang";
            this.cmbChucNang.Size = new System.Drawing.Size(219, 21);
            this.cmbChucNang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức năng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTGConLai);
            this.groupBox2.Controls.Add(this.labelThoiGianHienTai);
            this.groupBox2.Controls.Add(this.nbuPhut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nbuGio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // labelTGConLai
            // 
            this.labelTGConLai.AutoSize = true;
            this.labelTGConLai.Location = new System.Drawing.Point(114, 70);
            this.labelTGConLai.Name = "labelTGConLai";
            this.labelTGConLai.Size = new System.Drawing.Size(49, 13);
            this.labelTGConLai.TabIndex = 8;
            this.labelTGConLai.Text = "00:00:00";
            // 
            // labelThoiGianHienTai
            // 
            this.labelThoiGianHienTai.AutoSize = true;
            this.labelThoiGianHienTai.Location = new System.Drawing.Point(114, 47);
            this.labelThoiGianHienTai.Name = "labelThoiGianHienTai";
            this.labelThoiGianHienTai.Size = new System.Drawing.Size(49, 13);
            this.labelThoiGianHienTai.TabIndex = 7;
            this.labelThoiGianHienTai.Text = "00:00:00";
            // 
            // nbuPhut
            // 
            this.nbuPhut.Location = new System.Drawing.Point(221, 20);
            this.nbuPhut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbuPhut.Name = "nbuPhut";
            this.nbuPhut.Size = new System.Drawing.Size(46, 20);
            this.nbuPhut.TabIndex = 6;
            this.nbuPhut.ValueChanged += new System.EventHandler(this.nbuPhut_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ";
            // 
            // nbuGio
            // 
            this.nbuGio.Location = new System.Drawing.Point(116, 20);
            this.nbuGio.Name = "nbuGio";
            this.nbuGio.Size = new System.Drawing.Size(46, 20);
            this.nbuGio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian còn lại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tắt máy tính trong :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(138, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "ShuttingDown Tool";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBoxnhacNho
            // 
            this.checkBoxnhacNho.AutoSize = true;
            this.checkBoxnhacNho.Location = new System.Drawing.Point(13, 229);
            this.checkBoxnhacNho.Name = "checkBoxnhacNho";
            this.checkBoxnhacNho.Size = new System.Drawing.Size(129, 17);
            this.checkBoxnhacNho.TabIndex = 5;
            this.checkBoxnhacNho.Text = "Nhắc nhở sau (phút): ";
            this.checkBoxnhacNho.UseVisualStyleBackColor = true;
            this.checkBoxnhacNho.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDownNhacNho
            // 
            this.numericUpDownNhacNho.Enabled = false;
            this.numericUpDownNhacNho.Location = new System.Drawing.Point(154, 225);
            this.numericUpDownNhacNho.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownNhacNho.Name = "numericUpDownNhacNho";
            this.numericUpDownNhacNho.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNhacNho.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phút";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 258);
            this.Controls.Add(this.numericUpDownNhacNho);
            this.Controls.Add(this.checkBoxnhacNho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn giờ tắt máy tính - Code by Le Minh Thanh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbuGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNhacNho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbChucNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nbuPhut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbuGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTGConLai;
        private System.Windows.Forms.Label labelThoiGianHienTai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBoxnhacNho;
        private System.Windows.Forms.NumericUpDown numericUpDownNhacNho;
        private System.Windows.Forms.Label label7;
    }
}

