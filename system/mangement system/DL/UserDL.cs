using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using mangement_system.BL;
namespace mangement_system.DL
{
    class UserDL
    {
        public static List<BL.User> users = new List<BL.User>();

        public static void addlist(BL.User s)
        {
            users.Add(s);
        }
        public static void storeuser(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);

            file.Flush();
            file.Close();
        }
        public static bool Check(string name, string password)
        {

            for (int i = 0; i < users.Count; i++)
            {

                if (name == users[i].getName() && password == users[i].getPassword() )
                {
                   
                    return true;


                }
            }

            return false;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    BL.User u = new BL.User(name, password, role);
                    users.Add(u);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
    }
}
