using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서_검색_pre0617
{
    public partial class Book0617 : Form
    {
        public Book0617()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Book> books = BookSearcher.Search(tbox_query.Text);
            foreach(Book book in books)
            {
                string[] datas = new string[3] { book.Title, book.Author, book.ISBN };
                ListViewItem lvi = new ListViewItem(datas);
                lv_book.Items.Add(lvi);
            }
        }

        private void Book0617_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookSearcher.Save();
        }

        private void Book0617_Load(object sender, EventArgs e)
        {
            List<Book> books = BookSearcher.Load();
            foreach(Book book in books)
            {
                string[] datas = new string[3] { book.Title, book.Author, book.ISBN };
                ListViewItem lvi = new ListViewItem(datas);
                lv_book.Items.Add(lvi);
            }
        }
    }
}
