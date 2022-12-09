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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Organizer
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MakeNoteClick_Click(object sender, RoutedEventArgs e)
        {
            MakeNote makeNote = new MakeNote();
            makeNote.Show();
        }

        private void ShowNotesClick_Click(object sender, RoutedEventArgs e)
        {
            ListNotes listNotes = new ListNotes();
            listNotes.Show();
        }
    }
}
