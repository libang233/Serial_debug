/*
    The IO_control of serial assistant.
    Creat by Libang 2017-1-6
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SML_serialTest
{
    public partial class IO_control_form : Form
    {
        string DIO;
        string AIO;

        public IO_control_form()
        {
            InitializeComponent();
        }


        private void D3_Dbutton_Click(object sender, EventArgs e)
        {
            string testText = "dwrite 3 1";
            Form1.ComPort.WriteLine(testText);
        }

        private void DBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DIO = DBox.SelectedItem.ToString().Substring(1);
        }

        private void D_PWM_button_Click(object sender, EventArgs e)
        {
            string PWM_digital = "awrite " + DIO + " " + PWM_Box.Text;
            if (Form1.portsGet == true)
            {
                if (DIO != null)
                {
                    if (DIO != "2")
                    {
                        if (PWM_Box.Text != null)
                        {
                            Form1.ComPort.WriteLine(PWM_digital);
                        }
                        else
                        {
                            MessageBox.Show("请输入PWM数值");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择可以输出PWM的IO口");
                    }
                }
                else
                {
                    MessageBox.Show("请选择IO口");
                }
            }
            else
            {
                MessageBox.Show("串口未连接");
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void D_HIGH_button_Click(object sender, EventArgs e)
        {
            if (Form1.portsGet == true)
            {
                if (DIO != null)
                {
                    if (PWM_Box.Text != null)
                    {
                        Form1.ComPort.WriteLine("dwrite " + DIO + " 1");
                    }
                    else
                    {
                        MessageBox.Show("请输入PWM数值");
                    }
                }
                else
                {
                    MessageBox.Show("请选择IO口");
                }
            }
            else
            {
                MessageBox.Show("串口未连接");
            }
        }

        private void D_LOW_button_Click(object sender, EventArgs e)
        {
            if (Form1.portsGet == true)
            {
                if (DIO != null)
                {
                    if (PWM_Box.Text != null)
                    {
                        Form1.ComPort.WriteLine("dwrite " + DIO + " 0");
                    }
                    else
                    {
                        MessageBox.Show("请输入PWM数值");
                    }
                }
                else
                {
                    MessageBox.Show("请选择IO口");
                }
            }
            else
            {
                MessageBox.Show("串口未连接");
            }
        }
    }
}
