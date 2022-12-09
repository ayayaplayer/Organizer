using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Organizer
{

   public class SQLNotes
    {
        public int AddSqlNote(string Status, string Name,string Surname, SqlConnection connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Professional\Desktop\Progs\Organizer\Organizer\ListOfNotes.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Notes] (Status, Name, Surname) VALUES (N'{Status}', N'{Name}', N'{Surname}')", connectionString);
            int ScoreOfNotes = command.ExecuteNonQuery();
            return ScoreOfNotes;
        }

        public int ShowAllNotes(DataGrid data, SqlConnection connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Professional\Desktop\Progs\Organizer\Organizer\ListOfNotes.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                $"SELECT *  FROM [Notes] ", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            data.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = dataSet.Tables[0] });
            int rowsCount = dataSet.Tables[0].Rows.Count;
            return rowsCount;
        }
    }

   
}
