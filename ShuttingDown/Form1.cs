using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShuttingDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        private int hour = 0;
        private int minute = 0;
        private int sec=0;
        private decimal downTime = 0;
        private void Load()
        {
            cmbChucNang.SelectedIndex = 0;
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelThoiGianHienTai.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNhacNho.Enabled = !numericUpDownNhacNho.Enabled;
        }
        /// <summary>
        /// Bat dau tien hanh tat hoac khoi dong lai hoac dang xuat khoi may tinh
        /// dong thoi tien hanh dem nguoc thoi gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(nbuPhut.Value<=0 && nbuGio.Value ==0)
            {
                MessageBox.Show("Bạn chưa chọn thời gian!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chương trình sẽ tiến hành " + cmbChucNang.SelectedItem.ToString() + " sau " + nbuGio.Value + " giờ " + nbuPhut.Value + " phút nữa !", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TinhThoiGian();
                timer2.Start();
                button1.Enabled = false;
                button2.Enabled = true;
                if(cmbChucNang.SelectedIndex==0)
                {
                    Shutdown(downTime.ToString());
                }
                else if(cmbChucNang.SelectedIndex==1)
                {
                    Restart(downTime.ToString());
                }
                else
                {
                    LogOff(downTime.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cancel();
            button1.Enabled = true;
            button2.Enabled = false;
            labelTGConLai.Text = "00:00:00";
            timer2.Stop();
        }
        private void TinhThoiGian()
        {
            hour =Convert.ToInt32(nbuGio.Value);
            minute = Convert.ToInt32(nbuPhut.Value);
            sec = 59;
            downTime = nbuPhut.Value * 60 + nbuGio.Value * 3600;
        }
#region Cac ham tat may, khoi dong lai, dang xuat
        private void Shutdown(string thoiGian)
        {
            Process.Start("shutdown", "-s -t "+thoiGian);
        }
        private void Restart(string thoiGian)
        {
            Process.Start("shutdown", "-r -t "+thoiGian);
        }
        private void LogOff(string thoiGian)
        {

        }
        private void Cancel()
        {
            Process.Start("shutdown", "-a");
        }
        #endregion
        /// <summary>
        /// Thay doi gia tri trong NumericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nbuPhut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if(num.Value >=60)
            {
                nbuGio.Value++;
                num.Value = 0;
            }
        }
        private string formatTime(int time)
        {
            string t = time.ToString();
            return t = time < 10 ? "0" + t : t;
        }
        /// <summary>
        /// Hien thi thoi gian con lai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(hour>0||minute>0||sec>0)
            {
                if(minute==0&& hour>0) { minute = 59;hour -= 1; }
                if(sec==0 && minute>0) { sec = 59; minute -= 1; }
                sec -= 1;
            }
            labelTGConLai.Text = formatTime(hour)+":"+formatTime(minute)+":"+formatTime(sec);
            if(checkBoxnhacNho.Checked==true && numericUpDownNhacNho.Value==minute)
            {
                MessageBox.Show("Máy tính của bạn sẽ " + cmbChucNang.SelectedItem.ToString() + " trong " + minute + " nữa!\nBạn hãy lưu lại các tài liệu đang thực hiện để tránh bị mât!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
