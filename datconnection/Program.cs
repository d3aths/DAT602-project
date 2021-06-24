using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace datconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Page());

            ////add a new username and a password
            //dataAccess aDataAccess = new dataAccess();
            //Console.WriteLine("===Adding New User===");
            //Console.WriteLine(aDataAccess.AddUser("Celeste", "no"));
            //Console.ReadLine();
            //Console.WriteLine(aDataAccess.AddUser("Hannah Montana", "yeehaw"));
            //Console.ReadLine();

            ////takes a userID, the field you want to update, and the data to update
            //dataAccess bDataAccess = new dataAccess();
            //Console.WriteLine("====Editing User Details===");
            //Console.WriteLine(bDataAccess.EditAcc(1, "email", "no@no.com"));
            //Console.ReadLine();

            ////input userID to be deleted
            //dataAccess cDataAccess = new dataAccess();
            //Console.WriteLine("====Deleting Account===");
            //Console.WriteLine(cDataAccess.DelAcc(2));
            //Console.ReadLine();

            ////no parameters needed to call this
            //dataAccess dDataAccess = new dataAccess();
            //Console.WriteLine("====Online Players===");
            //Console.WriteLine(dDataAccess.ShowPlayers());
            //Console.WriteLine("If blank, there are no online players");
            //Console.ReadLine();

            ////user id then class must be either "Tank" "Berserker" "Ninja"
            //dataAccess eDataAccess = new dataAccess();
            //Console.WriteLine("====Selecting A Class===");
            //Console.WriteLine(eDataAccess.PickClass(1, "Tank"));
            //Console.ReadLine();

            ////user id then x + y coordinates of new position
            //dataAccess fDataAccess = new dataAccess();
            //Console.WriteLine("====Moving Player===");
            //Console.WriteLine(fDataAccess.Move(1, 1, 1));
            //Console.ReadLine();

            //dataAccess hDataAccess = new dataAccess();
            //Console.WriteLine("testing if user check outputs");
            //Console.WriteLine(hDataAccess.checkUser("hannah"));
            //Console.ReadLine();
        }
    }
}
