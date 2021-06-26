using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace datconnection
{
    class dataAccess
    {
        public string Output { get; set; }
        private static string connectionString
        {
            get { return "Server=localhost;Port=3306;Database=game;Uid=root;password=nightfall;"; }

        }

        private static MySqlConnection _mySqlConnection = null;
        public static MySqlConnection mySqlConnection
        {
            get
            {
                if (_mySqlConnection == null)
                {
                    _mySqlConnection = new MySqlConnection(connectionString);
                }

                return _mySqlConnection;

            }
        }
        public string AddUser(string pUsername, string pPassword)
        {

            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 20);
            aP.Value = pUsername;
            p.Add(aP);
            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            bP.Value = pPassword;
            p.Add(bP);


            var aDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call AddUser(@UserName, @Password)", p.ToArray());

            // expecting one table with one row
            return (aDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public string EditAcc(int pUserID, string field, string param)
        {
            List<MySqlParameter> editInput = new List<MySqlParameter>();
            var editInputID = new MySqlParameter("@UserID", MySqlDbType.Int32);
            editInputID.Value = pUserID;
            editInput.Add(editInputID);
            var editInputField = new MySqlParameter("@Field", MySqlDbType.VarChar, 50);
            editInputField.Value = field;
            editInput.Add(editInputField);
            var editInputParam = new MySqlParameter("@Param", MySqlDbType.VarChar, 50);
            editInputParam.Value = param;
            editInput.Add(editInputParam);

            var bDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call EditAcc(@UserID, @Field, @Param)", editInput.ToArray());

            return (bDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public string DelAcc(int pUserID)
        {
            List<MySqlParameter> deleter = new List<MySqlParameter>();
            var deleteID = new MySqlParameter("@UserID", MySqlDbType.Int32);
            deleteID.Value = pUserID;
            deleter.Add(deleteID);

            var cDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call DelAcc(@UserID)", deleter.ToArray());

            return (cDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public string ShowPlayers()
        {
            var dDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call ShowPlayers()");

            return (dDataSet.Tables[0].Rows[0])["Online Players"].ToString();
        }

        public string PickClass(int pUserID, string build)
        {
            List<MySqlParameter> buildSelect = new List<MySqlParameter>();
            var UserID = new MySqlParameter("@UserID", MySqlDbType.Int32);
            UserID.Value = pUserID;
            buildSelect.Add(UserID);
            var buildName = new MySqlParameter("@buildName", MySqlDbType.VarChar, 10);
            buildName.Value = build;
            buildSelect.Add(buildName);

            var eDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call PickClass(@UserID, @buildName)", buildSelect.ToArray());

            return (eDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public string Move(int pUserID, int X, int Y)
        {
            List<MySqlParameter> mover = new List<MySqlParameter>();
            var UserID = new MySqlParameter("@UserID", MySqlDbType.Int32);
            UserID.Value = pUserID;
            mover.Add(UserID);
            var xPos = new MySqlParameter("@xCoord", MySqlDbType.Int32);
            xPos.Value = X;
            mover.Add(xPos);
            var yPos = new MySqlParameter("@yCoord", MySqlDbType.Int32);
            yPos.Value = Y;
            mover.Add(yPos);

            var fDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call Move(@UserID, @xCoord, @yCoord)", mover.ToArray());

            return (fDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

        public string addCheckedUser(string pUsername, string pPassword)
        {

            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 20);
            aP.Value = pUsername;
            p.Add(aP);
            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            bP.Value = pPassword;
            p.Add(bP);


            var gDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call addCheckedUser(@UserName, @Password)", p.ToArray());

            // expecting one table with one row
            return (gDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();

        }

        public string checkUser(string pUsername)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 20);
            aP.Value = pUsername;
            p.Add(aP);

            var hDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call checkUser(@UserName)", p.ToArray());

            return (hDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }
        public string LockOut(string pUsername)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 20);
            aP.Value = pUsername;
            p.Add(aP);

            var iDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call LockOut(@UserName)", p.ToArray());

            return (iDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }
        public string CheckLogin(string pUsername, string pPassword)
        {
            List<MySqlParameter> p = new List<MySqlParameter>();
            var aP = new MySqlParameter("@UserName", MySqlDbType.VarChar, 20);
            aP.Value = pUsername;
            p.Add(aP);
            var bP = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            bP.Value = pPassword;
            p.Add(bP);

            var jDataSet = MySqlHelper.ExecuteDataset(dataAccess.mySqlConnection, "Call CheckLogin(@UserName, @Password)", p.ToArray());

            Output = (jDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();

            return (jDataSet.Tables[0].Rows[0])["MESSAGE"].ToString();
        }

    }   
}
