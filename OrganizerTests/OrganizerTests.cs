using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace OrganizerTests
{
    [TestClass]
    public class OrganizerTests
    {
        [TestMethod]
        public void AddNewNote()
        {
            string status, name,surname;
            int actual, expected = 1;
            status = "Физическое лицо";
            name = "Роман";
            surname = "Кушнарёв";
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Professional\Desktop\Progs\Organizer\Organizer\ListOfNotes.mdf;Integrated Security=True");
            sqlConnection.Open();
            SQLNotes note = new SQLNotes();
            actual = note.AddSqlNote(status,name,surname,sqlConnection);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShowNote()
        {
           
            int actual, expected = 9;
            DataGrid data = new DataGrid();
            DataSet dataSet = new DataSet();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Professional\Desktop\Progs\Organizer\Organizer\ListOfNotes.mdf;Integrated Security=True");
            sqlConnection.Open();
            SQLNotes note = new SQLNotes();
            actual = note.ShowAllNotes( data, sqlConnection);
            Assert.AreEqual(expected, actual);
        }
    }
}
