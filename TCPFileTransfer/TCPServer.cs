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
    class TCPServer : TCPAbstract
    {
        IPAddress host;
        int port;
        Socket sListener;
        Socket clientSock;
        string receivedPath;
        string status = "None";

        public TCPServer(IPAddress host,int port)
        {
            this.host = host;
            this.port = port;
            status = "Включено";
        }

        public void Start()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                //IPAddress ipAddr = host;
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
                // Создаем сокет Tcp/Ip
                sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sListener.Bind(ipEndPoint);
                sListener.Listen(100);
                status = "Ожидание клиентов";
                clientSock = sListener.Accept();
                status = "Связь установлена";
                TransferFile();         
              
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
                byte[] clientData = new byte[1024 * 5000];
                int receivedBytesLen = clientSock.Receive(clientData);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);
                BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath+ "//" + fileName, FileMode.Append)); ;
                bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);               
                bWrite.Close();
                Close();
                status = "Файл принят";
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при передаче файла" + ex.Message);
            }
        }

        public void SelectFileDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                receivedPath = folderBrowserDialog.SelectedPath;
            }
            status = "Директория выбрана";
        }

        public void Close()
        {
            clientSock.Close();
            status = "Сокет закрыт";
        }
        public string GetStatus()
        {
            return status;
        }
    }
}
