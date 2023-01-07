using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace NOTE_ID.View_Model
{
    public class MYDB : DbContext
    {
        public MYDB() : base()
        {

        }
        private MySqlConnection connection = new MySqlConnection(
            "server = localhost; port=3306;username=root;password=;database=note_id");
        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
