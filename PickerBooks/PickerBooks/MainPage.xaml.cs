using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerBooks
{
    public partial class MainPage : ContentPage
    {
        List<Book> availableBooks = new List<Book>();

        void initAvailableBook()
        {
            availableBooks.Add(new Book() { code = "0", titleBook = "Dạy làm giàu", imageBook = "lamgiau.jpg" });
            availableBooks.Add(new Book() { code = "1", titleBook = "Cha giàu cha nghèo", imageBook = "cgcn.jpg" });
            availableBooks.Add(new Book() { code = "2", titleBook = "Ngày xưa có một con bò", imageBook = "conbo.jpg" });
            availableBooks.Add(new Book() { code = "4", titleBook = "Chiến tranh tiền tệ", imageBook = "cttt.jpg" });
            availableBooks.Add(new Book() { code = "5", titleBook = "Kỹ thuật lập trình", imageBook = "ktlt.jpg" });

            pikBook.ItemsSource = availableBooks;
            pikBook.SelectedIndex = 0;

        }
        void CartInit(string title)
        {
            List<Book> listBook = new List<Book>();
            if (title != "")
            {
                foreach (Book book in availableBooks)
                {
                    if (book.titleBook == title)
                    {
                        listBook.Add(book);
                    }
                }
            }
            listViewBook.ItemsSource = listBook;
        }
        public MainPage()
        {
            InitializeComponent();
            initAvailableBook();
            CartInit("");
        }

    

        private void pikBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int index = picker.SelectedIndex;
            if(index >= 0)
            {
                string title = picker.Items[index].ToString();
                CartInit(title:title);
            }
        }
    }
}
