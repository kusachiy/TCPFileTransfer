using System;
using System.Net;
using System.Windows.Forms;

namespace TCPFileTransfer
{
    public partial class Form1 : Form
    {
        TCPAbstract tcp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {            
            try
            {
                tcp.Start();
            }
            catch
            {
                statusbar.Text = "Проблема при подключении";
                return;
            }
            statusbar.Text = tcp.GetStatus();
          
         }

        private void Select_File_Click(object sender, EventArgs e)
        {
            try
            {
                tcp.SelectFileDirectory();
            }
            catch
            {
                statusbar.Text = "Проблема при выборе файла/директории";
                return;
            }
            statusbar.Text = tcp.GetStatus();
            button_Connect.Enabled = true;
            SendFile.Enabled = true;
            button1.Enabled = true;
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            try
            {
                tcp.TransferFile();
            }
            catch
            {
                statusbar.Text = "Проблема при передаче файла";
                return;
            }
            statusbar.Text = tcp.GetStatus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tumblr();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tumblr();
        }
        void Tumblr()
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;
            else if (radioButton2.Checked)
                radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void on_vutton_Click(object sender, EventArgs e)
        {
            IPAddress adress;
            int port;
            try
            {
                adress = IPAddress.Parse(textboxIP.Text);
                port = int.Parse(textboxPort.Text);
            }
            catch (Exception ex)
            {
                statusbar.Text = "ERROR" + ex.Message;
                return;
            }

            if (radioButton1.Checked)
            {
                tcp = new TCPClient(adress, port);
                SendFile.Visible = true;
            }
            if (radioButton2.Checked)
            {
                tcp = new TCPServer(adress, port);
                SendFile.Visible = false;
            }
            Select_File.Enabled = true;
            on_vutton.Enabled = false;
            statusbar.Text = tcp.GetStatus();
        }
    }
}
