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
    /// Interaction logic for BookRecommendation.xaml
    /// </summary>
    public partial class BookRecommendation : Page
    {
        public BookRecommendation()
        {
            InitializeComponent();
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
                    Width = 230,
                    Height = 340,
                    Margin = new Thickness(20),
                    Tag = i,
                    Background = new ImageBrush(bitmap),
                    Style = style,
                    Content = App.books[i].nama,
                };

                button.Click += new RoutedEventHandler(Book_Click);
                BooksSP.Children.Add(button);
            }
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            BookFrame.Visibility = Visibility.Visible;
            BookFrame.Navigate(new BookInfo(App.books[(int)(sender as Button).Tag] ,BookFrame));
        }
    }
}
