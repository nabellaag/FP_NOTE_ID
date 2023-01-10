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
    /// Interaction logic for BookInfo.xaml
    /// </summary>
    public partial class BookInfo : Page
    {
        Frame frame;
        public BookInfo(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            SetBooksRec();
        }

        private void SetBooksRec()
        {
            //if (App.books.Count < 1) { return; }
            Style style = this.FindResource("BookButton") as Style;
            for (int i = 0; i < App.books.Count(); i++)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(App.books[i].cover);
                bitmap.EndInit();

                Button button = new Button
                {
                    Width = 100,
                    Height = 150,
                    Margin = new Thickness(20),
                    Tag = i,
                    Name = "sdsfsdf",
                    Content = App.books[i].nama,
                    Background = new ImageBrush(bitmap),
                    Style = style
                };

                //button.Click += new RoutedEventHandler(Book_Click);
                BooksSP2.Children.Add(button);
            }
        }

        private void DescButt_Click(object sender, RoutedEventArgs e)
        {
            Detail.Visibility = Visibility.Hidden;
        }

        private void DetailButt_Click(object sender, RoutedEventArgs e)
        {
            Detail.Visibility = Visibility.Visible;
        }
    }
}
