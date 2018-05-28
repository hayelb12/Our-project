using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Configuration;
using System.Net;
namespace Final
{
    class Server
    {

        public Server()
        {

        }


        public void server()
        {
            try
            {
                //IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                //IPAddress Ip = null;
                //for (int i = 0; i < ipHostInfo.AddressList.Length; i++)
                //{
                //    if (ipHostInfo.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                //    {
                //        Ip = ipHostInfo.AddressList[i];
                //        break;
                //    }
                //}

                IPAddress add = new IPAddress(getBytesIPv4("0.0.0.0"));
                TcpListener serverSocket = new TcpListener(add, 8220);
                serverSocket.AllowNatTraversal(true);
                TcpClient clientSocket = default(TcpClient);
                int counter = 0;

                serverSocket.Start();
                Console.WriteLine(" >> " + "Server Started");

                counter = 0;
                while (true)
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();
                    Console.WriteLine(" >> " + "Client No:" + Convert.ToString(counter) + " started!");
                    User client = new User();
                    client.startClient(clientSocket, Convert.ToString(counter));

                }

                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine(" >> " + "exit");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(" >> " + "exit");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }



        }

        private Byte[] getBytesIPv4(string Ip)
        {
            Byte[] add = new Byte[4];
            string[] st = Ip.Split(new char[] { '.' });

            for (int i = 0; i < st.Length; i++)
            {
                add[i] = Byte.Parse(st[i]);
            }

            return add;
        }

    }
}

