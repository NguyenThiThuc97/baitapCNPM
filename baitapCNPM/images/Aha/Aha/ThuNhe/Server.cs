using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ThuNhe
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            connect();
        }
        //dodng ket noi.
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
        //gui tin cho tat ca client.
        private void BtnSend_Click(object sender, EventArgs e)
        {
             foreach (Socket item in CLientList)
             {
                send(item);
           }
            // send();
            AddMessage(TxtMessage.Text);
            TxtMessage.Clear();
        }
        System.Net.IPEndPoint IP;
        System.Net.Sockets.Socket server;
        List<System.Net.Sockets.Socket> CLientList;
        void connect()
        {
            CLientList = new List<System.Net.Sockets.Socket>();
            //ip la dia chi cua server.
            IP = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 9999);
            server = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, SocketType.Stream, System.Net.Sockets.ProtocolType.IP);
            server.Bind(IP);
            System.Threading.Thread Listen = new System.Threading.Thread(()=> {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        CLientList.Add(client);

                        System.Threading.Thread receive1 = new System.Threading.Thread(Receive);
                        receive1.IsBackground = true;
                        receive1.Start(client);
                    }
                }
                catch
                {
                    IP = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 9999);
                    server = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, SocketType.Stream, System.Net.Sockets.ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        //dong ket noi hien thoi.
        void close()
        {
            server.Close();
        }
        //giui tin
        void send(Socket client)
        {
            if (client !=null && TxtMessage.Text != string.Empty)
                client.Send(Serialize(TxtMessage.Text));
        }
        //nhan tin
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string Message = (String)Deserialize(data);
                    //
                   // foreach (Socket item in CLientList)
                   // {
                     //   if(item !=null)
                      //   item.Send(Serialize(Message));
                  //  }
                    //

                    AddMessage(Message);
                }
            }
            catch
            {
                CLientList.Remove(client);
                client.Close();
            }
        }
        //add message vao khung chat.
        void AddMessage(String s)
        {
            LstMessage.Items.Add(new ListViewItem() { Text = s });
        }
        //phan manh.
        byte[] Serialize(object obj)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        //goi manh lai.
        object Deserialize(byte[] data)
        {
            System.IO.MemoryStream stream = new System.IO.MemoryStream(data);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            return formatter.Deserialize(stream);

        }
    }
}
