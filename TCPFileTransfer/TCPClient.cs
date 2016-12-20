using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace TCPFileTransfer
{
    class TCPClient : TCPAbstract
    {
        IPAddress host;
        int port;
        Socket sListener;
        Socket serverSock;
        string path;
        string fileName;
        string status="None";

        public TCPClient(IPAddress host,int port)
        {
            this.host = host;
            this.port = port;
            status = "Включено";
        }

        public void Start()
        {
            try
            {
                //IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                //IPAddress ipAddr = ipHost.AddressList[0];
                IPAddress ipAddr = host;
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
                // Создаем сокет Tcp/Ip
                sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sListener.Connect(ipEndPoint);
                status = "Подключено к серверу";            
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при создании подключения" + ex.Message);
            }
        }
        public void TransferFile()
        {
            try
            {               
                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                byte[] fileData = File.ReadAllBytes(path);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                sListener.Send(clientData);
                sListener.Close();
                status = "Файл доставлен";
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при передаче файла" + ex.Message);
            }
        }
        public void SelectFileDirectory()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            status = "Выбран новый файл для отправки";

        }
        public void Close()
        {
            sListener.Close();
            status = "Сокет закрыт";
        }

        public string GetStatus()
        {
            return status;
        }
    }
}
