/*
    The main body of serial assistant.
    Creat by Libang 2016-12-17
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
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SML_serialTest
{
    public partial class Form1 : Form
    {
        int BaudRate = 250000;
        public static  SerialPort ComPort = new SerialPort();
        StringBuilder builder = new StringBuilder();
        OpenFileDialog getFile = new OpenFileDialog();    //获取文件
        private string[] ports;                           //所有可用串口名
        public static bool portsGet = false;              //是否成功连接串口
        bool fileSelection = false;                       //检测是否为文件发送状态
        string SendPath;                                  //待发送文件路径
        string SendText;                                  //待发送文本
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            getPorts();
            Thread check = new Thread(new ThreadStart(checkPorts));//开辟一个线程
            check.Start();    
        }

        private void comDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = ComPort.BytesToRead;
            byte[] buf = new byte[n];
            ComPort.Read(buf, 0, n);
            builder.Clear();
            Invoke((EventHandler)(delegate
            {
                //直接按ASCII规则转换成字符串  
                builder.Append(Encoding.ASCII.GetString(buf));
                //追加的形式添加到文本框末端，并滚动到最后。  
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  接收数据："  );
                acceptBox.AppendText("\n");
                acceptBox.AppendText(builder.ToString() + '\n');
            }));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                if(fileSelection == true)
                {
                    sendFile();
                }
                else
                {
                    sendMessage(sendBox .Text );
                }
                
            }
            else
            {
                getPorts();
            }
        }

        private void enterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(null, null);
            }
            if(e.KeyCode == Keys.Back && fileSelection == true )
            {
                fileSelection = false;
                sendBox.Text = "";

            }
        }

        private void sendBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
           
        }

        private void sendFile()
        {
            try
            {
                ComPort.WriteLine(SendText);
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  发送信息：" + SendText + '\n');
                sendBox.Text = "";
                fileSelection = false;
            }
            catch
            {
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口未连接\n");
            }
        }
  
        public void sendMessage(string SendText )
        {
            try
            {
                byte[] sendBuffer = null;//发送数据缓冲区  
                int sendTimes;
                if (ComPort.IsOpen)
                {
                    if(HEX_selection.CheckState == CheckState.Checked)
                    {
                        try
                        {
                            SendText = SendText.Replace(" ", "");//去除16进制数据中所有空格  
                            SendText = SendText.Replace("\r", "");//去除16进制数据中所有换行  
                            SendText = SendText.Replace("\n", "");//去除16进制数据中所有换行  
                            if (SendText.Length == 1)//数据长度为1的时候，在数据前补0  
                            {
                                SendText = "0" + SendText;
                            }
                            else if (SendText.Length % 2 != 0)//数据长度为奇数位时，去除最后一位数据  
                            {
                                SendText = SendText.Remove(SendText.Length - 1, 1);
                            }

                            List<string> sendData16 = new List<string>();//将发送的数据，2个合为1个，然后放在该缓存里 如：123456→12,34,56  
                            for (int i = 0; i < SendText.Length; i += 2)
                            {
                                sendData16.Add(SendText.Substring(i, 2));
                            }
                            sendBuffer = new byte[sendData16.Count];//sendBuffer的长度设置为：发送的数据2合1后的字节数  
                            for (int i = 0; i < sendData16.Count; i++)
                            {
                                sendBuffer[i] = (byte)(Convert.ToInt32(sendData16[i], 16));//发送数据改为16进制  
                            }
                            sendTimes = sendBuffer.Length / 1000;
                            ComPort.Write(sendBuffer, sendTimes*1000, sendBuffer.Length%1000);
                            acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  发送信息：" + SendText + '\n');
                            sendBox.Text = "";
                        }
                        catch
                        {
                            acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "请正确输入16进制数据");
                        }
                       
                    }
                    else
                    {
                        ComPort.WriteLine(SendText);
                        acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  发送信息：" + SendText + '\n');
                        sendBox.Text = "";
                    }
                }
                else
                {
                    acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口未连接\n");
                }

            }
            catch
            {
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口未连接\n");
            }
        }

        private void getPorts()
        {
            try
            {
                ports = SerialPort.GetPortNames();
                if (ports.Length > 0)
                {
                    for (int i = 0; i < ports.Length; i++)
                    {
                        portName.DropDownItems.Add(ports[i]);//动态增加现有可用端口
                    }
                }
                ComPort.PortName = ports[0];
                ComPort.BaudRate = BaudRate;
                linkCom();
                ComPort.DataReceived += comDataReceived;
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口连接成功\n");
                portsGet = true;
            }
            catch
            {
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口未连接\n");
                sendButton.Text = "连接";
            }
        }

        public void linkCom()
        {
            try
            {
                ComPort.Open();

            }
            catch
            {
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口被占用\n");
            }
        }

        private  void checkPorts()
        {
            while (true)
            {
                while (portsGet)
                {
                    if (ComPort.IsOpen)
                    {
                        sendButton.Text = "发送";
                        portsGet = true;
                    }
                    else
                    {
                        sendButton.Text = "连接";
                        this.acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  串口未连接\n");
                        portName.DropDownItems.Clear();//移除所有端口选项
                        portsGet = false;
                    }
                }
                
                
            }          
        }

        private void deal_sal()
        {
            
        }

    
        private void sendBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void acceptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void portName_Click(object sender, EventArgs e)
        {

        }



        #region BaudRate selection
        private void 波特率ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BaudRate = 9600;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BaudRate = 19200;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BaudRate = 28800;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BaudRate = 38400;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            BaudRate = 57600;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            BaudRate = 115200;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            BaudRate = 250000;
            ComPort.BaudRate = BaudRate;
        }
        #endregion

        private void HEX_selection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureFile_Click(object sender, EventArgs e)
        {
            
            getFile.InitialDirectory = Application.StartupPath;
            getFile.Filter = "";
            getFile.FilterIndex = 2;
            getFile.RestoreDirectory = true;    //是否从记忆上次目录
            if ( getFile.ShowDialog() == DialogResult.OK)
            {
                SendPath = getFile.FileName.ToString();    //文件路径
                string Name = SendPath.Substring(SendPath.LastIndexOf("\\") + 1);
                sendBox.Text = Name;
                SendText = File.ReadAllText(SendPath);
                fileSelection = true;             
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(fileSelection == true)
            {
                fileSelection = false;
                sendBox.Text = SendText;
            }
            else
            {
                acceptBox.AppendText(DateTime.Now.ToLongTimeString().ToString() + "  无可用文件" + '\n');
            }

            
        }

        private void broken_line_Click(object sender, EventArgs e)
        {
            ComPort.Close();
        }

        private void IO_control_mode_Click(object sender, EventArgs e)
        {
            new IO_control_form().Show();
        }

        private void translate_file_Click(object sender, EventArgs e)
        {
            new translate_form().Show();
        }
    }

}
