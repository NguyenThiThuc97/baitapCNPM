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

namespace Server
{
    //cần:
   /*
    -socket
    -ip
         */
    public partial class Client : Form
    {
        public Client()
        {

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //gui tin di.
        private void BtnSend_Click(object sender, EventArgs e)
        {
            send();
            AddMessage(TxtMessage.Text);
        }
        System.Net.IPEndPoint IP ;
        System.Net.Sockets.Socket client;
        void connect()
        {
            //ip la dia chi cua server.
            IP = new System.Net.IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 9999);
            client = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork,SocketType.Stream, System.Net.Sockets.ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Cannot connect !","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            System.Threading.Thread listen = new System.Threading.Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        //dong ket noi hien thoi.
        void close()
        {
            client.Close();
        }
        //giui tin
        void send()
        {
            if(TxtMessage.Text!=string.Empty)
                client.Send(Serialize(TxtMessage.Text));
        }
        //nhan tin
        void Receive()
        {
            try {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string Message = (String)Deserialize(data);
                    AddMessage(Message);
                }
                    }
            catch 
            {
                close();
            }
        }
        //add message vao khung chat.
        void AddMessage(String s)
        {
            LstMessage.Items.Add(new ListViewItem() { Text = s });
            TxtMessage.Clear();
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
           return  formatter.Deserialize(stream);
            
        }
        //dong ket noi kji dong form.
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
