using NOTE_ID.Model;
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
        Book book;
        public BookInfo(Book book, Frame frame)
        {
            InitializeComponent();
            this.book = book;
            this.frame = frame;
            SetBookInfo();
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
                    Content = App.books[i].nama,
                    Background = new ImageBrush(bitmap),
                    Style = style
                };

                button.Click += new RoutedEventHandler(Book_Click);
                BooksSP2.Children.Add(button);
            }
        }

        private void SetBookInfo()
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(book.cover);
            bitmap.EndInit();

            BookCover.Source = bitmap;
            Judul.Content = book.judul;
            BookDesc.Text = book.deskripsi;
            JumlahHalaman.Content = book.jmlhal;
            TanggalTerbit.Content = book.tgl;
            ISBN.Content = book.isbn;
            Penerbit.Content = book.penerbit;
            Bahasa.Content = book.bahasa;
        }

        private void DescButt_Click(object sender, RoutedEventArgs e)
        {
            Detail.Visibility = Visibility.Hidden;
        }

        private void DetailButt_Click(object sender, RoutedEventArgs e)
        {
            Detail.Visibility = Visibility.Visible;
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new BookInfo(App.books[(int)(sender as Button).Tag], frame));

        }
    }
}
