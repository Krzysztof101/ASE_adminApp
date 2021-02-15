using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_admin_app
{


    public partial class UserControlBooks : UserControl
    {


        



        INavBooks navigation;
        IBookFunctions functions;
        LinkedList<Book> allBooks;

        public UserControlBooks(INavBooks navigation, IBookFunctions functions)
        {
            InitializeComponent();
            this.navigation = navigation;
            this.functions = functions;
            allBooks = functions.getAllBooks();
            foreach(Book b in allBooks)
            {
                ContainerBook cont = new ContainerBook(b);
                listBoxBooks.Items.Add(cont);
            }
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            if(listBoxBooks.SelectedIndex==-1)
            {
                return;
            }
            ContainerBook container = (ContainerBook)listBoxBooks.SelectedItem;
            navigation.goToEditBooks( container.StoredBook.clone() );
        }

        private void buttonMainPanel_Click(object sender, EventArgs e)
        {
            navigation.goToMain();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContainerBook container = (ContainerBook)listBoxBooks.SelectedItem;
            Book selectedBook = container.StoredBook;
            fillDataListbox(selectedBook);
            fillBonusesListBox(selectedBook);

        }
        private void fillDataListbox(Book selectedBook)
        {
            listBoxData.Items.Clear();
            listBoxData.Items.Add("id: " + selectedBook.Id.ToString());
            listBoxData.Items.Add("title: " + selectedBook.Title);
            listBoxData.Items.Add(new ContainerAuthors(selectedBook.authors));
            listBoxData.Items.Add(new ContainerCategories(selectedBook.categories));
            listBoxData.Items.Add("price: " + selectedBook.Price);
            listBoxData.Items.Add("price minus discount in procent: " + selectedBook.priceMinusDiscountInProcent);
            listBoxData.Items.Add("start selling date: " + selectedBook.startSellingDate.ToString());
            listBoxData.Items.Add( "quantity: " + selectedBook.quantity );
            string deleted = "no";
            if(selectedBook.deleted)
            {
                deleted = "yes";
            }
            listBoxData.Items.Add("deleted: " + deleted);
        }
        private void fillBonusesListBox(Book selectedBook)
        {
            listBoxBonuses.Items.Clear();
            foreach(Bonus b in selectedBook.bonuses)
            {
                ContainerBonus cb = new ContainerBonus(b);
                listBoxBonuses.Items.Add(cb);
            }
        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            navigation.goToEditBooks(null);
        }
    }
}
