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
using NOTE_ID.Model;

namespace NOTE_ID.View
{
    /// <summary>
    /// Interaction logic for ReadingListPopUp.xaml
    /// </summary>
    public partial class ReadingListPopUp : UserControl
    {
        public ReadingListPopUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) ||
                string.IsNullOrWhiteSpace(dateBox.Text) ||
                string.IsNullOrWhiteSpace(authorBox.Text) ||
                string.IsNullOrWhiteSpace(typeBox.Text) ||
                string.IsNullOrWhiteSpace(publisherBox.Text)) return;
            Model.ReadingList rl = new()
            {
                TitleBook = titleBox.Text,
                Tanggal = DateTime.Today,
                Type = typeBox.Text,
                Author = authorBox.Text,
                Publisher = publisherBox.Text,
                Status = statusComboBox.Text == "Finished" ? Status.Finished : Status.NotYet
            };
            App.readingLists.Add(rl);
            titleBox.Text = string.Empty;
            dateBox.Text = string.Empty;
            authorBox.Text = string.Empty;
            publisherBox.Text = string.Empty;
            typeBox.Text = string.Empty;
        }
    }
}
