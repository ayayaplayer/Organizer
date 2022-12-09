using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.Common;

namespace Organizer
{

    public partial class ListNotes : Window
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Professional\Desktop\Progs\Organizer\Organizer\ListOfNotes.mdf;Integrated Security=True");


        public ListNotes()
        {
            sqlConnection.Open();

            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT ID, Status AS N'Статус', Name  AS N'Имя',  Surname AS N'Фамилия',  PhoneNumber AS N'Номер телефона', Date AS N'Дата', Deal AS N'Дело'  FROM [Notes]   ", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            data.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = dataSet.Tables[0] });

        }

        private void TakeStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TakeStatus.SelectedIndex == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT ID, Status AS N'Статус', Name  AS N'Имя',  Surname AS N'Фамилия',  PhoneNumber AS N'Номер телефона', Date AS N'Дата', Deal AS N'Дело'  FROM [Notes]  WHERE Status LIKE N'Физическое лицо' ", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                data.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = dataSet.Tables[0] });
            }
            if (TakeStatus.SelectedIndex == 1)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT ID, Status AS N'Статус', Name  AS N'Имя',  Surname AS N'Фамилия',  PhoneNumber AS N'Номер телефона', Date AS N'Дата', Deal AS N'Дело'  FROM [Notes]  WHERE Status LIKE N'Юридическое лицо' ", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                data.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = dataSet.Tables[0] });
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ListOfNotes"].ConnectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [Notes] where [Id]= '" + ((DataRowView)data.SelectedItem).Row[0].ToString() + "'", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ListOfNotes"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From [Notes]", sqlConnection);
            DataTable dt = new DataTable("Notes");
            adapter.Fill(dt);
            data.ItemsSource = dt.DefaultView;
            MessageBox.Show("Данные удалены");

        }
    }  
}
