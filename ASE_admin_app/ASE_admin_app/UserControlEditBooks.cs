using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASE_admin_app
{
    public partial class UserControlEditBooks : UserControl
    {
        INavEditBooks navigation;
        IEditBooks bookFunctions;
        Book editAddBook;
        bool addingBook;
        public UserControlEditBooks(INavEditBooks navigation, IEditBooks bookFunctions, Book toEdit)
        {
            InitializeComponent();
            initialControlsSetup();
            this.navigation = navigation;
            this.bookFunctions = bookFunctions;
            editAddBook = toEdit;
            if(toEdit!=null)
            {
                prepareForUpdate();
            }
            else
            {
                prepareForAdd();
            }
        }
        public void initialControlsSetup()
        {
            textBoxTitle.Text = "";
            textBoxPrice.Text = "";
            textBoxPrice.Text = "";
            textBoxDiscount.Text = "";
            textBoxQuantity.Text = "";
        }

        

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            navigation.goToBooks();
        }
        private void prepareForUpdate()
        {
            addingBook = false;
            prepareCategoriesAuthorsAndBonuses(editAddBook);

        }
        private void prepareForAdd()
        {
            addingBook = true;
            editAddBook = new Book();
            prepareCategoriesAuthorsAndBonuses(editAddBook);
        }
        private void prepareCategoriesAuthorsAndBonuses(Book book)
        {

            //fill listboxes
            LinkedList<Author> otherAuthors = bookFunctions.getAllAuthorsMinuBookAuthors(book);
            listBoxThisBookAuthors.Items.Clear();
            foreach(Author authorThisBook in book.authors)
            {
                listBoxThisBookAuthors.Items.Add(authorThisBook);
            }
            listBoxOtherAuthors.Items.Clear();
            foreach(Author otherAuthor in otherAuthors)
            {
                listBoxOtherAuthors.Items.Add(otherAuthor);
            }


            LinkedList<Category> otherCategories = bookFunctions.getCategriesBookDoesntbelongTo(book);
            listBoxThisBookCategories.Items.Clear();
            foreach(Category category in book.categories)
            {
                listBoxThisBookCategories.Items.Add(category);
            }
            listBoxOtherCategories.Items.Clear();
            foreach(Category otherCategory in otherCategories)
            {
                listBoxOtherCategories.Items.Add(otherCategory);
            }

            listBoxThisBookBonuses.Items.Clear();
            foreach(Bonus thisBookBonus in book.bonuses)
            {
                ContainerBonus container = new ContainerBonus(thisBookBonus);
                listBoxThisBookBonuses.Items.Add(container);
            }

            //fill general data panel
            if (book.Id == Book.newBookId)
            {
                labelID.Text = "new book";
            }
            else
            {
                labelID.Text = book.Id.ToString();
            }
            textBoxTitle.Text = book.Title;
            textBoxPrice.Text = book.Price.ToString();
            textBoxDiscount.Text = book.priceMinusDiscountInProcent.ToString();
            textBoxQuantity.Text = book.quantity.ToString();
            dateTimeStartSelling.Value = book.startSellingDate;
            checkBoxDeleted.Checked = book.deleted;

        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if(addingBook)
            {
                bool attemptToFill =  fillBookWithUIData();

                if (attemptToFill)
                {
                    string result = bookFunctions.addNewBook(editAddBook);

                        MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Incorrect data passed to UI");
                }
            }
            else
            {
                bool attemptToFill = fillBookWithUIData();
                if(attemptToFill)
                {

                    string result = bookFunctions.updateBook(editAddBook);
                        MessageBox.Show(result);

                }
                else
                {
                    MessageBox.Show("Incorrect data passed to UI");
                }

            }
        }

        private bool fillBookWithUIData()
        {
            try
            {
                string title = textBoxTitle.Text;
                decimal price = Convert.ToDecimal(textBoxPrice.Text);
                int discount = Convert.ToInt32(textBoxDiscount.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                DateTime date = dateTimeStartSelling.Value;
                bool deleted = checkBoxDeleted.Checked;
                LinkedList<Author> authors = new LinkedList<Author>();
                foreach(Object objAuthor in listBoxThisBookAuthors.Items)
                {
                    Author a = ((Author)objAuthor).clone();
                    authors.AddLast(a);
                }
                LinkedList<Category> categories = new LinkedList<Category>();
                foreach(Object objCateg in listBoxThisBookCategories.Items)
                {
                    Category c = ((Category)objCateg).clone();
                    categories.AddLast(c);
                }
                LinkedList<Bonus> bonuses = new LinkedList<Bonus>();
                foreach(Object objBon in listBoxThisBookBonuses.Items )
                {
                    ContainerBonus contBonus = ((ContainerBonus)objBon);
                    Bonus bonus = contBonus.StoredBonus;
                    bonuses.AddLast(bonus.clone());
                }

                editAddBook.Title = title;
                editAddBook.Price = price;
                editAddBook.priceMinusDiscountInProcent = discount;
                editAddBook.quantity = quantity;
                editAddBook.startSellingDate = date;
                editAddBook.deleted = deleted;
                editAddBook.authors = authors;
                editAddBook.categories = categories;
                editAddBook.bonuses = bonuses;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private void buttonMoveAuthor_Click(object sender, EventArgs e)
        {
            if(listBoxOtherAuthors.SelectedIndex==-1 && listBoxThisBookAuthors.SelectedIndex==-1)
            {
                return;
            }
            if(listBoxThisBookAuthors.SelectedIndex!=-1 && listBoxOtherAuthors.SelectedIndex==-1)
            {
                Author moved = (Author)listBoxThisBookAuthors.SelectedItem;
                listBoxThisBookAuthors.Items.RemoveAt(listBoxThisBookAuthors.SelectedIndex);
                listBoxOtherAuthors.Items.Add(moved);
                return;
            }
            if (listBoxThisBookAuthors.SelectedIndex == -1 && listBoxOtherAuthors.SelectedIndex != -1)
            {
                Author moved = (Author)listBoxOtherAuthors.SelectedItem;
                listBoxOtherAuthors.Items.RemoveAt(listBoxOtherAuthors.SelectedIndex);
                listBoxThisBookAuthors.Items.Add(moved);
                return;
            }

        }

        private void listBoxOtherAuthors_Click(object sender, EventArgs e)
        {
            listBoxThisBookAuthors.SelectedIndex = -1;
        }

        private void listBoxThisBookAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxThisBookAuthors_Click(object sender, EventArgs e)
        {
            listBoxOtherAuthors.SelectedIndex = -1;
        }

        private void listBoxThisBookCategories_Click(object sender, EventArgs e)
        {
            listBoxOtherCategories.SelectedIndex = -1;
        }

        private void listBoxOtherCategories_Click(object sender, EventArgs e)
        {
            listBoxThisBookCategories.SelectedIndex = -1;
        }

        private void buttonMoveCategory_Click(object sender, EventArgs e)
        {


            if(listBoxThisBookCategories.SelectedIndex==-1 && listBoxOtherCategories.SelectedIndex==-1)
            {
                return;
            }
            if(listBoxThisBookCategories.SelectedIndex!= -1 && listBoxOtherCategories.SelectedIndex == -1)
            {
                Category moved = (Category)listBoxThisBookCategories.SelectedItem;
                listBoxThisBookCategories.Items.RemoveAt(listBoxThisBookCategories.SelectedIndex);
                listBoxOtherCategories.Items.Add(moved);
            }
            if (listBoxThisBookCategories.SelectedIndex == -1 && listBoxOtherCategories.SelectedIndex != -1)
            {
                Category moved = (Category)listBoxOtherCategories.SelectedItem;
                listBoxOtherCategories.Items.RemoveAt(listBoxOtherCategories.SelectedIndex);
                listBoxThisBookCategories.Items.Add(moved);
            }

        }

        private void buttonBonusAdd_Click(object sender, EventArgs e)
        {
            int score = 0;
            DateTime start;
            DateTime end;
           
            try
            {
                score = Convert.ToInt32(textBoxBonusScore.Text);
                start = dateTimeBonusStart.Value;
                end = dateTimeBonusEnd.Value;

            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect data passed to the UI");
                return;
            }
            Bonus bonus = new Bonus();
            bonus.id = 0;
            bonus.score = score;
            bonus.startDate = start;
            bonus.endDate = end;
            if(!bonus.correct())
            {
                MessageBox.Show("Incorrect data while creating bonus");
                return;
            }
            ContainerBonus container = new ContainerBonus(bonus);
            listBoxThisBookBonuses.Items.Add(container);
        }

        private void buttonDeleteBonus_Click(object sender, EventArgs e)
        {
            if(listBoxThisBookBonuses.SelectedIndex != -1)
            {
                listBoxThisBookBonuses.Items.RemoveAt(listBoxThisBookBonuses.SelectedIndex);
            }
        }
    }
}
