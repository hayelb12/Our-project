using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;


namespace Final
{
    class DataBase
    {
        OleDbConnection con = new OleDbConnection();

        public DataBase()
        {
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\User\source\repos\Server\Server\bin\Debug\DataBase.accdb; Persist Security Info = False;";

            con.ConnectionString = connectionString;

            con.Open();
        }

        public bool IsUserExist(string username)
        {
            OleDbCommand users = new OleDbCommand();

            users.CommandText = "SELECT username FROM login WHERE username=" + '"' + username + '"';

            users.Connection = con;

            OleDbDataReader readOwnerID = users.ExecuteReader();

            string OwnerID = null;

            while (readOwnerID.Read())

            {

                OwnerID = readOwnerID["username"].ToString();

            }
            readOwnerID.Close();
            return OwnerID != null;
        }

        public bool IsUserAndPassMatCh(string username, string passsword)
        {
            OleDbCommand users = new OleDbCommand();

            users.CommandText = "SELECT * FROM login WHERE username=" + '"' + username + '"';

            users.Connection = con;

            OleDbDataReader readOwnerID = users.ExecuteReader();

            String OwnerID = null;

            while (readOwnerID.Read())

            {

                OwnerID = readOwnerID["password"].ToString();

            }
            readOwnerID.Close();
            return passsword == OwnerID;
        }

        public void connectUser(string username)
        {
            string command = string.Format("UPDATE login SET connected = '1' WHERE username = '{0}'", username);

            OleDbCommand connect = new OleDbCommand(command,con);

            connect.ExecuteNonQuery();
        }

        public void disConnectUser(string username)
        {
            string command = string.Format("UPDATE login SET connected = '0' WHERE username = '{0}'", username);

            OleDbCommand connect = new OleDbCommand(command, con);

            connect.ExecuteNonQuery();
            
        }

        public bool isUserConnected(string username)
        {
            string command = string.Format("SELECT connected FROM login WHERE username = '{0}'", username);
            OleDbCommand connect = new OleDbCommand(command, con);

            OleDbDataReader reader = connect.ExecuteReader();

            string connected = null;

            while(reader.Read())
            {
                connected = reader["connected"].ToString();
            }

            return connected == "True";
        }

        public void signUpUser(string user,string password)
        {
            string command = string.Format("INSERT INTO login(username,[password],connected) VALUES('{0}','{1}','{2}')", user,password,1);

            OleDbCommand signUp = new OleDbCommand(command, con);

            signUp.ExecuteNonQuery();
        }

        public void changePassword(string user, string password)
        {
            string command = string.Format("UPDATE [login] SET [password] = '{1}' WHERE [username] = '{0}'", user,password);

            OleDbCommand connect = new OleDbCommand(command, con);

            connect.ExecuteNonQuery();
        }

        public List<String> getRooms(string roomName)
        {
            List<String> rooms = new List<String>();

            OleDbCommand getRooms = new OleDbCommand();

            getRooms.CommandText = "SELECT RoomName FROM Rooms WHERE RoomName LIKE '%" + roomName + "%'";

            getRooms.Connection = con;

            OleDbDataReader readOwnerID = getRooms.ExecuteReader();

            String room = null;

            while (readOwnerID.Read())

            {

                room = readOwnerID["RoomName"].ToString();
                rooms.Add(room);

            }
            readOwnerID.Close();

            return rooms;

        }

        

      
    }
}
