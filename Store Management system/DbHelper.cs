using System;
using System.IO;
using System.Windows.Forms;

namespace Store_Management_system
{
    public static class DbHelper
    {
        public static string GetConnectionString()
        {
            string dbPath = Path.Combine(Application.StartupPath, "Database1.mdf");
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{dbPath}"";Integrated Security=True;";
        }
    }
}
