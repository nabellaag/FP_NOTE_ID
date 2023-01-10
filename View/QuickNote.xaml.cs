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

namespace NOTE_ID.View
{
    /// <summary>
    /// Interaction logic for QuickNote.xaml
    /// </summary>
    public partial class QuickNote : Page
    {
        Model.QuickNote quickNote;
        Frame frame;
        public QuickNote(Model.QuickNote quickNote, Frame frame)
        {
            InitializeComponent();
            this.quickNote = quickNote;
            this.frame = frame;

            if (quickNote != null) SetNote();

        }

        private void SetNote()
        {
            Title.Text = quickNote.Title;
            Text.Text = quickNote.Text;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Title.Text) || string.IsNullOrWhiteSpace(Text.Text))
            {
                MessageBox.Show("Judul atau Text kosong");
                return;
            }
            App.quickNotes.Add(new Model.QuickNote(Title.Text, Text.Text));

            frame.Content = null;
        }
    }
}
