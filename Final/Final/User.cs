using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace Final
{
    class User
    {
        TcpClient clientSocket;
        string clNo;
        string username;
        DataBase db = new DataBase();

        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();

        }

        private void doChat()
        {
            try
            {
                int requestCount = 0;
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                Byte[] sendBytes = null;
                string serverResponse = null;
                string rCount = null;
                requestCount = 0;

                while ((true))
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        NetworkStream networkStream = clientSocket.GetStream();
                        networkStream.Read(bytesFrom, 0, 3000);
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine(" >> " + "From client-" + clNo + dataFromClient);



                        rCount = Convert.ToString(requestCount);
                        serverResponse = HandleClientMessage(dataFromClient);
                        if(serverResponse == "103")
                        {
                            
                            this.clientSocket.Close();
                            return;
                        }
                        sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                        Console.WriteLine(" >> " + serverResponse);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        if (username != null && username != "")
                            db.disConnectUser(username);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private string HandleClientMessage(string Message)
        {
            string response  = "";

            Request r = new Request(Message);
            int code = r.getCode();
            List<string> values = r.getValues();

            if(code == 203)
            {
                response = handleSignUp(values);
                username = values[0];
            }
            else if(code ==200)
            {
                response = handleSignIn(values);
                username = values[0];
            }
            else if( code == 201)
            {
                response = handleSignOut();
            }
            else if(code == 204)
            {
                response = handleChangePassword(values);
            }
            else if(code == 105)
            {
                response = handleSettings();
            }
            else if(code == 204)
            {
                response = handleChangePassword(values);
            }
            else if(code == 109)
            {
                response = handleSearch(values);
            }
            return response;
        }

        private string handleSignIn(List<string> values)
        {
            string response = "";
            string user = values[0];
            string password = values[1];
            if(db.IsUserExist(user))
            {
                if(db.IsUserAndPassMatCh(user,password))
                {
                    if(db.isUserConnected(user))
                    {
                        response = "1022";
                    }
                    else
                    {
                        response = "1020";
                        db.connectUser(user);

                    }

                }
                else
                {
                    response = "1021";
                }
            }
            else
            {
                response = "1023";
            }
            return response;
        }

        private string handleSignUp(List<string> values)
        {
            string response = "";
            string user = values[0];
            string pass = values[1];

            if(db.IsUserExist(user))
            {
                response = "1042";
            }
            else
            {
                if(Validator.userLegal(user) && Validator.passLegal(pass))
                {
                    response = "1040";
                    db.signUpUser(user, pass);
                }
                else
                {
                    if(!Validator.userLegal(user))
                    {
                        response = "1043";
                    }
                    else if(!Validator.passLegal(pass))
                    {
                        response = "1041";
                    }
                }
            }
            return response;
        }

        private string handleSignOut()
        {
            string response = "103";
            if (username != null)
                db.disConnectUser(this.username);
            return response;
        }

       

        private string handleSettings()
        {
            return "206" + username.Length.ToString("00") + username;
        }

        private string handleChangePassword(List<string> values)
        {
            string response = "";

            if (!db.IsUserAndPassMatCh(username, values[0]))
            {
                response = "1011";
                return response;
            }
            
            if(!Validator.passLegal(values[1]))
            {
                response = "1012";
                return response;
            }

            response = "1010";
            db.changePassword(username, values[1]);

            

            return response;
               
        }

        private string handleSearch(List<string> values)
        {
            string response = "210";
            List<String> roomnames = db.getRooms(values[0]);
            for (int i = 0; i < roomnames.Count; i++)
            {
                response += roomnames[i].Length.ToString("00") + roomnames[i];
            }
            return response;
        }
    }
}
