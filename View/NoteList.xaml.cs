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
    /// Interaction logic for NoteList.xaml
    /// </summary>
    public partial class NoteList : Page
    {
        public NoteList()
        {
            InitializeComponent();
        }

        private void SetList()
        {
            Style style = this.FindResource("BookButton") as Style;
            for (int i = 0; i < App.quickNotes.Count(); i++)
            {

                Button button = new Button
                {
                    Width = 800,
                    Height = 60,
                    Margin = new Thickness(20),
                    Tag = i,
                    Content = App.quickNotes[i].Title,
                    Style = style
                };

                button.Click += new RoutedEventHandler(Note_Click);
                NoteSP.Children.Add(button);
            }
        }

        private void Note_Click(object sender, RoutedEventArgs e)
        {
            NoteFrame.Visibility = Visibility.Visible;
            NoteFrame.Navigate(new QuickNote(App.quickNotes[(int)(sender as Button).Tag], NoteFrame));
        }
    }
}
