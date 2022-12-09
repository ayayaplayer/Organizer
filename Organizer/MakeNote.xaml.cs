using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Markup;
using System.Text.RegularExpressions;

namespace Organizer
{

    public partial class MakeNote : Window
    {

        private SqlConnection sqlConnection = null;
        public MakeNote()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ListOfNotes"].ConnectionString);
            sqlConnection.Open();
            InitializeComponent();
        }



        private void IndividualCBX_Checked(object sender, RoutedEventArgs e)
        {
            if (IndividualCBX.IsChecked == true)
            {
                EntityCBX.IsEnabled = false;
            }
        }

        private void EntityCBX_Checked(object sender, RoutedEventArgs e)
        {
            if (EntityCBX.IsChecked == true)
            {
                IndividualCBX.IsEnabled = false;
            }
        }

        private void IndividualCBX_Unchecked(object sender, RoutedEventArgs e)
        {
            if (IndividualCBX.IsChecked == false)
            {
                EntityCBX.IsEnabled = true;
            }
        }

        private void EntityCBX_Unchecked(object sender, RoutedEventArgs e)
        {
            if (EntityCBX.IsChecked == false)
            {
                IndividualCBX.IsEnabled = true;
            }
        }

        private void SaveNote_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO [Notes] (Status,   Name,   Surname,    PhoneNumber,    Date,   Deal) VALUES (@Status,  @Name,  @Surname,   @PhoneNumber,   @Date,  @Deal)", sqlConnection);
            DateTime dateTime = DateTime.Parse(Date.Text.ToString());
            if (IndividualCBX.IsChecked == true)
            {
                sqlCommand.Parameters.AddWithValue("Status", Individual.Content.ToString());
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("Status", Entity.Content.ToString());
            }
            sqlCommand.Parameters.AddWithValue("Name", Name.Text.ToString());
            sqlCommand.Parameters.AddWithValue("Surname", Surname.Text.ToString());
            sqlCommand.Parameters.AddWithValue("PhoneNumber", PhoneNumber.Text.ToString());
            sqlCommand.Parameters.AddWithValue("Date", $"{dateTime.Month}/{dateTime.Day}/{dateTime.Year}");
            sqlCommand.Parameters.AddWithValue("Deal", Deal.Text.ToString());
            sqlCommand.ExecuteNonQuery();
            this.Close();
            if (PhoneNumber.Text.ToString() == "7-966-666-66-99")
            {
                Sudoku sudoku = new Sudoku();
                sudoku.Show();
            }    
        }






        private void PhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {


            e.Handled = "0123456789-".IndexOf(e.Text) < 0;

        }

        private void PhoneNumber_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (PhoneNumber.Text == "7-999-999-99-99")
            {
                PhoneNumber.Text = "";
                PhoneNumber.Foreground = Brushes.Black;
            }
            else if (PhoneNumber.Text == "")
            {
                PhoneNumber.Text = "7-999-999-99-99";
                PhoneNumber.Foreground = Brushes.LightGray;
            }
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[a-zA-Zа-яА-Я]+");

            if (!re.IsMatch(e.Text))
            {
                Name.Background = Brushes.Purple;
                NameReminder.Visibility = Visibility.Visible;
            }
            else
            {
                NameReminder.Visibility = Visibility.Hidden;
                Name.Background = Brushes.White;
            }
        }

        private void Surname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[a-zA-Zа-яА-Я]+");

            if (!re.IsMatch(e.Text))
            {
                Surname.Background = Brushes.Purple;
                SurnameReminder.Visibility = Visibility.Visible;
            }
            else
            {
                SurnameReminder.Visibility = Visibility.Hidden;
                Surname.Background = Brushes.White;
            }
        }
    }
}
