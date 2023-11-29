using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_lybrary;

namespace test_dll_forms
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void b_message_Click(object sender, EventArgs e)
        {
            /* if (MyMath.LeapYear(tb_message.Text))
                 Class_lybrary.Message.GetMessage(tb_message.Text);
             else
                 MessageBox.Show("Невысокосный год","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);*/
            string msg = $"Сумма = {MyMath.SumValue(tb_message.Text)}\nМинимальное число = {MyMath.MinValue(tb_message.Text)}\nМаксимальное число = {MyMath.MaxValue(tb_message.Text)}";
            MessageBox.Show(msg, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
