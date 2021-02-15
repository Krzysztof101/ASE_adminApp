using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{
    class AdminDBPackagingClass : IDisposable, IDBCategories, IDBAuthors, IDBGeneralInterface
    {

        private AdminDBPackagingClass()
        {
            string computerName = Environment.MachineName;
            connectionString = @"Data Source=" + computerName +
                @"; Initial Catalog=BookstoreASE; User ID=userASE;Password=userASEpswd";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            makeConsoleLog("connection open");
        }

        public static void makeConsoleLog(string context, string msg)
        {
            Console.WriteLine(context + ": " + msg);
        }
        public static void makeConsoleLog(string msg)
        {
            Console.WriteLine(msg);
        }
        private static Lazy<AdminDBPackagingClass> instanceLazy = new Lazy<AdminDBPackagingClass>(() => new AdminDBPackagingClass());
        public static AdminDBPackagingClass instance { get { return instanceLazy.Value; } private set { } }
        private string connectionString;
        private SqlConnection cnn;


        public void Dispose()
        {
            cnn.Close();
            if (cnn.State == ConnectionState.Closed)
            {
                makeConsoleLog("connection to db closed");
            }
            else
            {
                makeConsoleLog("connection still open despite attempt to close it");
            }
        }

        public bool addCategory(Category newCategory)
        {
            try
            {
                string cmdText = "insert into Categories (CategName) values ('" + newCategory.categoryName + "');";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                cmd.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        /*
        try
            {
                string cmdText = "Insert into UserBooksToBuy (ID_user, ID_book) values (@id_user, @id_book)";
        SqlCommand cmd = new SqlCommand(cmdText, cnn);
        cmd.Parameters.AddWithValue("@id_user", user.id);
                cmd.Parameters.AddWithValue("@id_book", book.id);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {

            }


        */

        public bool updateCategory(Category categoryBeforeUpdate, Category categoryAfterUpdate)
        {
            try
            {
                string cmdText = "UPDATE Categories SET CategName = @newName WHERE CategName =@oldName";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@newName", categoryAfterUpdate.categoryName.ToLower());
                cmd.Parameters.AddWithValue("@oldName", categoryBeforeUpdate.categoryName.ToLower());
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
        /*
            int id = 0;
            string oString = "Select ID from Users where UserLogin=@newLogin";
            SqlCommand oCmd = new SqlCommand(oString, cnn);
            oCmd.Parameters.AddWithValue("@newLogin", login);
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                if (oReader.Read())
                {
                    id = oReader.GetInt32(0);
                }
            }
            return id; 
         
         */


        public bool categoryExists(Category category)
        {
            bool searchResult = false;
            try
            {
                string cmdText = "SELECT CategName from Categories where Lower(CategName)=@searchedCategory";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@searchedCategory", category.categoryName.ToLower());
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    if (oReader.Read())
                    {
                        searchResult = true;
                    }
                }
            }
            catch (Exception e)
            {

                searchResult = false;
            }
            return searchResult;
        }

        public LinkedList<Category> getAllCategories()
        {
            LinkedList<Category> categories = new LinkedList<Category>();
            try
            {
                string cmdText = "SELECT Lower(CategName) from Categories";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while(oReader.Read())
                    {
                        string categName = oReader.GetString(0);
                        Category category = new Category();
                        category.categoryName = categName;
                        categories.AddLast(category);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return categories;
        }

        public LinkedList<Author> getAllAuthors()
        {
            LinkedList<Author> authors = new LinkedList<Author>();
            try
            {
                string cmdText = "Select id_author, authorName, authorLastName from Authors order by AuthorLastName";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while(oReader.Read())
                    {
                        int id = oReader.GetInt32(0);
                        string name = oReader.GetString(1);
                        string lastName = oReader.GetString(2);
                        Author a = new Author(id, name, lastName);
                        authors.AddLast(a);
                    }
                }


            }
            catch(Exception e)
            {
                throw e;
            }
            return authors;
        }

        public bool addAuthor(Author newAuthor)
        {
            try
            {
                string cmdText = "insert into Authors (AuthorName, AuthorLastName) values (@newName,@newLastName)";
                SqlCommand cmd = new SqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@newName", newAuthor.Name);
                cmd.Parameters.AddWithValue("@newLastName", newAuthor.LastName);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;


        }

        public bool updateAuthor(Author authorAfterUpdate)
        {

                try
                {
                    string cmdText = "Update Authors set AuthorName=@newName, AuthorLastName=@newLastName where id_author=@updated_author_id";
                    SqlCommand cmd = new SqlCommand(cmdText, cnn);
                    cmd.Parameters.AddWithValue("@newName", authorAfterUpdate.Name);
                    cmd.Parameters.AddWithValue("@newLastName", authorAfterUpdate.LastName);
                    cmd.Parameters.AddWithValue("@updated_author_id", authorAfterUpdate.Id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    return false;
                }
                return true;

            
        }

        public LinkedList<Book> getAllBooks()
        {
            LinkedList<Book> books = getAllBooksWithOnlyData();
            foreach(Book b in books)
            {
                addAuthorsToBook(b);
                addCategoriesToBook(b);
                addBonusesToBook(b);
            }
            return books;
        }

        private void addBonusesToBook(Book b)
        {
            string cmdText = "select id_bonus, bonusPeriodStart, bonusPeriodEnd, id_book, multiplicator from Bonuses where id_book=@arg_book_id order by 3,2;";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@arg_book_id", b.Id);
            LinkedList<Bonus> bonuses = new LinkedList<Bonus>();

            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while(oReader.Read())
                {
                    int id = oReader.GetInt32(0);
                    DateTime start = oReader.GetDateTime(1);
                    DateTime end = oReader.GetDateTime(2);
                    //int bookId = oReader.GetInt32(3);
                    int score = oReader.GetInt32(4);
                    Bonus bon = new Bonus();
                    bon.id = id;
                    bon.startDate = start;
                    bon.endDate = end;
                    bon.score = score;
                    bonuses.AddLast(bon);
                    makeConsoleLog("fetched bonus: " + bon.id.ToString() + ", from " + bon.startDate.ToString() + " to " + bon.endDate.ToString());
                }

            }
            b.bonuses = bonuses;

        }

        private void addCategoriesToBook(Book b)
        {
            string cmdText = "select categName from categories join Bookcategories on categoryName=CategName where bookcategories.id_book =@arg_book_id;";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@arg_book_id", b.Id);
            LinkedList<Category> categories = new LinkedList<Category>();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string categName = oReader.GetString(0);
                    Category c = new Category(categName);
                    categories.AddLast(c);
                    makeConsoleLog("fetched category: "+c.categoryName);
                }
            }
            b.categories = categories;
        }

        private void addAuthorsToBook(Book b)
        {
            string cmdText = "select distinct authors.id_author, authorName, authorLastName from authorslist join authors on authors.id_author = authorslist.id_author where authorslist.id_book =@b_id order by 3,2";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@b_id", b.Id);
            LinkedList<Author> authors = new LinkedList<Author>();
            using(SqlDataReader oReader = cmd.ExecuteReader())
            {
                while(oReader.Read())
                {
                    int id = oReader.GetInt32(0);
                    string name = oReader.GetString(1);
                    string lastName = oReader.GetString(2);
                    Author a = new Author(id, name, lastName);
                    authors.AddLast(a);
                    makeConsoleLog("fetched author " + name + " " + lastName + " (" + id.ToString() + ")");
                }
            }
            b.authors = authors;
        }

        private LinkedList<Book> getAllBooksWithOnlyData()
        {
            LinkedList<Book> allBooks = new LinkedList<Book>();

            string cmdText = "select ID_book, Title, Price, PriceMinusDiscountInProcent, quantity, start_selling_date, deleted from books;";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    int id = oReader.GetInt32(0);
                    string title = oReader.GetString(1);
                    decimal price = (decimal)(oReader.GetSqlMoney(2));
                    int priceMinusDiscountInProcent = oReader.GetInt32(3);
                    int quantity = oReader.GetInt32(4);
                    DateTime begin = oReader.GetDateTime(5);
                    bool deleted = oReader.GetBoolean(6);

                    Book book = new Book();
                    book.Id = id;
                    book.Title = title;
                    book.Price = price;
                    book.priceMinusDiscountInProcent = priceMinusDiscountInProcent;
                    book.quantity = quantity;
                    book.startSellingDate = begin;
                    book.deleted = deleted;
                    makeConsoleLog("fetched book: " + book.Title + " (" + book.Id.ToString() + ")");
                    allBooks.AddLast(book);
                }
            }
            return allBooks;
        }

        public bool addNewBook(Book newBook)
        {

            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = cnn.BeginTransaction("AddNewBookTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            command.Connection = cnn;
            command.Transaction = transaction;
            int newBookId = newBook.Id;
            LinkedList<int> bonusIds = new LinkedList<int>();
            try
            {
                //add book
                string cmdTextInsertBook = "insert into books (Title, Price, PriceMinusDiscountInProcent, quantity, start_selling_date, deleted) " +
                    "values (@arg_book_Title, @arg_book_price, @arg_book_discount, @arg_book_quan, @arg_book_start_sell, @arg_book_del)";
                command.CommandText = cmdTextInsertBook;
                command.Parameters.AddWithValue("@arg_book_Title", newBook.Title.ToLower());
                command.Parameters.AddWithValue("@arg_book_price", newBook.Price);
                command.Parameters.AddWithValue("@arg_book_discount", newBook.priceMinusDiscountInProcent);
                command.Parameters.AddWithValue("@arg_book_quan", newBook.quantity);
                command.Parameters.AddWithValue("@arg_book_start_sell", newBook.startSellingDate);
                command.Parameters.AddWithValue("@arg_book_del", newBook.deleted);
                command.ExecuteNonQuery();
                
                makeConsoleLog("Add book");
                string cmdTextRetrieveBookId = "select @@Identity";
                
                command.CommandText = cmdTextRetrieveBookId;
                newBookId = Convert.ToInt32( command.ExecuteScalar());
                /*
                using(SqlDataReader oReader = command.ExecuteReader())
                {
                    oReader.Read();
                    newBookId = oReader.GetInt32(0);
                }
                */

                makeConsoleLog("fetch books scope identity - retrieved object");


                //add authors
                command.CommandText =
                    "insert into AuthorsList (id_book,id_author) values (@arg_new_book_id,@arg_author_id);";
                command.Parameters.AddWithValue("@arg_new_book_id", newBookId);
                command.Parameters.AddWithValue("@arg_author_id", -1);
                foreach (Author a in newBook.authors)
                {
                    command.Parameters.RemoveAt("@arg_author_id");
                    command.Parameters.AddWithValue("@arg_author_id", a.Id);
                    command.ExecuteNonQuery();
                }
                command.Parameters.RemoveAt("@arg_author_id");
                command.Parameters.AddWithValue("@arg_categ_name", "dummy");
                command.CommandText = "insert into Bookcategories (id_book, categoryName) values ( @arg_new_book_id , @arg_categ_name);";
                
                //add categories
                foreach(Category c in newBook.categories)
                {
                    command.Parameters.RemoveAt("@arg_categ_name");
                    command.Parameters.AddWithValue("@arg_categ_name", c.categoryName);
                    command.ExecuteNonQuery();

                }
                command.Parameters.RemoveAt("@arg_categ_name");

                //add bonuses
                command.Parameters.AddWithValue("@arg_bonus_start", DateTime.Now);
                command.Parameters.AddWithValue("@arg_bonus_end", DateTime.Now);
                command.Parameters.AddWithValue("@arg_score", -1);
                command.CommandText = "insert into Bonuses ( bonusPeriodStart, bonusPeriodEnd , id_book, multiplicator) values"+
                    " ( @arg_bonus_start, @arg_bonus_end,@arg_new_book_id, @arg_score);";
                foreach (Bonus b in newBook.bonuses)
                {
                    command.Parameters.RemoveAt("@arg_bonus_start");
                    command.Parameters.RemoveAt("@arg_bonus_end");
                    command.Parameters.RemoveAt("@arg_score");

                    command.Parameters.AddWithValue("@arg_bonus_start", b.startDate);
                    command.Parameters.AddWithValue("@arg_bonus_end", b.endDate);
                    command.Parameters.AddWithValue("@arg_score", b.score);
                    command.ExecuteNonQuery();

                    command.CommandText = "select @@Identity";
                    
                    
                        int newBonusId = 0;
                    newBonusId = Convert.ToInt32( command.ExecuteScalar() );
                        bonusIds.AddLast(newBonusId);
                    
                    makeConsoleLog("fetched bonus id");
                    /*
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        int newBonusId = 0;
                        oReader.Read();
                        newBonusId = oReader.GetInt32(0);
                        bonusIds.AddLast(newBonusId);
                    }
                    */
                }

                
                for (int i = 0; i < newBook.bonuses.Count; i++)
                {
                    newBook.bonuses.ElementAt(i).id = bonusIds.ElementAt(i);
                }
                newBook.Id = newBookId;
                

                // Attempt to commit the transaction.
                transaction.Commit();
                makeConsoleLog("Tracnsaction complete - book added");
                return true;

            }
            catch (Exception ex)
            {
                makeConsoleLog("Commit Exception Type: " + ex.GetType().ToString());
                makeConsoleLog("exception message: "+ ex.Message);
                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    makeConsoleLog("Commit Exception Type: " + ex2.GetType().ToString());
                    makeConsoleLog("exception message: " + ex2.Message);
                    return false;
                }
            }
            return false;

        }

        public bool updateBook(Book bookToUpdate)
        {

            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = cnn.BeginTransaction("UpdateBookTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            command.Connection = cnn;
            command.Transaction = transaction;
            int newBookId = bookToUpdate.Id;
            LinkedList<int> bonusIds = new LinkedList<int>();
            try
            {
                //add book
                string cmdTextInsertBook = "update Books set Title = @arg_title, Price=@arg_price, PriceMinusDiscountInProcent = @arg_discount,"+
                    " quantity=@arg_quantity, start_selling_date=@arg_start_sell, deleted=@arg_del where ID_book=@arg_id";
                command.CommandText = cmdTextInsertBook;
                command.Parameters.AddWithValue("@arg_title", bookToUpdate.Title.ToLower());
                command.Parameters.AddWithValue("@arg_price", bookToUpdate.Price);
                command.Parameters.AddWithValue("@arg_discount", bookToUpdate.priceMinusDiscountInProcent);
                command.Parameters.AddWithValue("@arg_quantity", bookToUpdate.quantity);
                command.Parameters.AddWithValue("@arg_start_sell", bookToUpdate.startSellingDate);
                command.Parameters.AddWithValue("@arg_del", bookToUpdate.deleted);
                command.Parameters.AddWithValue("@arg_id", bookToUpdate.Id);
                command.ExecuteNonQuery();



                makeConsoleLog("updated book");
                command.CommandText = "delete from AuthorsList where id_book=@arg_id;";
                command.ExecuteNonQuery();
                makeConsoleLog("deleted old authors");

                //add authors
                command.CommandText = "insert into AuthorsList (id_book,id_author) values (@arg_id,@arg_author_id);";
                command.Parameters.AddWithValue("@arg_author_id", -1);
                foreach (Author a in bookToUpdate.authors)
                {
                    command.Parameters.RemoveAt("@arg_author_id");
                    command.Parameters.AddWithValue("@arg_author_id", a.Id);
                    command.ExecuteNonQuery();
                }
                command.Parameters.RemoveAt("@arg_author_id");
                makeConsoleLog("added new authors");

                command.CommandText = "delete from Bookcategories where id_book=@arg_id;";
                command.ExecuteNonQuery();
                makeConsoleLog("delete old categories");

                command.Parameters.AddWithValue("@arg_categ_name", "dummy");
                command.CommandText = "insert into Bookcategories (id_book, categoryName) values ( @arg_id , @arg_categ_name);";

                //add categories
                foreach (Category c in bookToUpdate.categories)
                {
                    command.Parameters.RemoveAt("@arg_categ_name");
                    command.Parameters.AddWithValue("@arg_categ_name", c.categoryName);
                    command.ExecuteNonQuery();

                }
                command.Parameters.RemoveAt("@arg_categ_name");

                makeConsoleLog("update - categories added");
                //add bonuses

                command.CommandText = "delete from Bonuses where id_book=@arg_id";
                command.ExecuteNonQuery();
                makeConsoleLog("uptade - delete old bonuses");

                command.Parameters.AddWithValue("@arg_bonus_start", DateTime.Now);
                command.Parameters.AddWithValue("@arg_bonus_end", DateTime.Now);
                command.Parameters.AddWithValue("@arg_score", -1);
                command.CommandText = "insert into Bonuses ( bonusPeriodStart, bonusPeriodEnd , id_book, multiplicator) values" +
                    " ( @arg_bonus_start, @arg_bonus_end,@arg_id, @arg_score);";
                foreach (Bonus b in bookToUpdate.bonuses)
                {
                    command.Parameters.RemoveAt("@arg_bonus_start");
                    command.Parameters.RemoveAt("@arg_bonus_end");
                    command.Parameters.RemoveAt("@arg_score");

                    command.Parameters.AddWithValue("@arg_bonus_start", b.startDate);
                    command.Parameters.AddWithValue("@arg_bonus_end", b.endDate);
                    command.Parameters.AddWithValue("@arg_score", b.score);
                    command.ExecuteNonQuery();

                    command.CommandText = "select @@Identity";


                    int newBonusId = 0;
                    newBonusId = Convert.ToInt32(command.ExecuteScalar());
                    bonusIds.AddLast(newBonusId);

                    makeConsoleLog("fetched bonus id");
                    /*
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        int newBonusId = 0;
                        oReader.Read();
                        newBonusId = oReader.GetInt32(0);
                        bonusIds.AddLast(newBonusId);
                    }
                    */
                }


                for (int i = 0; i < bookToUpdate.bonuses.Count; i++)
                {
                    bookToUpdate.bonuses.ElementAt(i).id = bonusIds.ElementAt(i);
                }


                // Attempt to commit the transaction.
                transaction.Commit();
                makeConsoleLog("Tracnsaction complete - book updated");
                return true;

            }
            catch (Exception ex)
            {
                makeConsoleLog("Commit Exception Type: " + ex.GetType().ToString());
                makeConsoleLog("exception message: " + ex.Message);
                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    makeConsoleLog("Commit Exception Type: " + ex2.GetType().ToString());
                    makeConsoleLog("exception message: " + ex2.Message);
                    return false;
                }
            }
            //return false;



        }

        public LinkedList<Author> getAllAuthorsMinuBookAuthors(Book book)
        {
            string cmdText = "select authors.id_author, AuthorName, AuthorLastName from Authors where id_author not in ( select id_author from AuthorsList where id_book = @arg_book_id)" ;
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@arg_book_id", book.Id);
            LinkedList<Author> authors = new LinkedList<Author>();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    int id = oReader.GetInt32(0);
                    string name = oReader.GetString(1);
                    string lastName = oReader.GetString(2);
                    Author a = new Author(id, name, lastName);
                    authors.AddLast(a);
                    makeConsoleLog("fetched author " + name + " " + lastName + " (" + id.ToString() + ")");
                }
            }
            return authors;
        }

        public LinkedList<Category> getAllCategoriesMinusBookCategories(Book book)
        {
            LinkedList<Category> categories = new LinkedList<Category>();
            string cmdText = "select categName from Categories where CategName not in (select categoryName from Bookcategories where id_book = @arg_book_id);";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            cmd.Parameters.AddWithValue("@arg_book_id", book.Id);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string name = oReader.GetString(0);
                    Category c = new Category(name);
                    categories.AddLast(c);
                }
            }
            return categories;
        }

        public bool updateRecomsSystem(RecommendationsSystem recSys)
        {

            SqlCommand command = cnn.CreateCommand();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = cnn.BeginTransaction("SampleTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            command.Connection = cnn;
            command.Transaction = transaction;

            try
            {
                
                foreach (ScoreModuleInfo module in recSys.ModulesInfo)
                {
                    command.CommandText =
                        "Update RecommendationsModules set active=@arg_active, multiplicator=@arg_multi " +
                        " where descriptor =@arg_desc ";

                    command.Parameters.AddWithValue("@arg_desc", module.Name);
                    command.Parameters.AddWithValue("@arg_active", module.charActive);
                    command.Parameters.AddWithValue("@arg_multi", module.MainMultiplicator);
                    
                    command.ExecuteNonQuery();
                    command.Parameters.RemoveAt("@arg_active");
                    command.Parameters.RemoveAt("@arg_multi");
                    command.Parameters.RemoveAt("@arg_desc");
                    foreach (SubMultiplicator subMulti in module.SubMultiplicators)
                    {
                        command.CommandText =
                        "Update subRecommendators set multpicator=@arg_multi " +
                        " where descriptor =@arg_desc  and  moduleDescriptor =@arg_mod_desc";
                        command.Parameters.AddWithValue("@arg_desc", subMulti.name);
                        command.Parameters.AddWithValue("@arg_mod_desc", module.Name);
                        command.Parameters.AddWithValue("@arg_multi", subMulti.multiplicationValue);
                        command.ExecuteNonQuery();
                        command.Parameters.RemoveAt("@arg_desc");
                        command.Parameters.RemoveAt("@arg_mod_desc");
                        command.Parameters.RemoveAt("@arg_multi");
                    }

                }
                
                
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                makeConsoleLog("Commit Exception Type: " + ex.GetType().ToString());
                makeConsoleLog("exception message: " + ex.Message);

                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex2)
                {
                    makeConsoleLog("Commit Exception Type: " + ex2.GetType().ToString());
                    makeConsoleLog("exception message: " + ex2.Message);
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    return false;
                }
            }



        }

        public RecommendationsSystem getRecomsSystem()
        {
            LinkedList<ScoreModuleInfo> modules = new LinkedList<ScoreModuleInfo>();

            string cmdText = "select descriptor, active, multiplicator from RecommendationsModules";
            SqlCommand cmd = new SqlCommand(cmdText, cnn);
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    string desc = oReader.GetString(0);
                    string  activeChar = oReader.GetString(1).ToLower();
                    int mult = oReader.GetInt32(2);
                    bool active = true;
                    if(activeChar=="n")
                    {
                        active = false;
                    }
                    ScoreModuleInfo module = new ScoreModuleInfo(mult, desc, new LinkedList<string>(), new LinkedList<int>(), active);
                    modules.AddLast(module);
                }
            }

            foreach (ScoreModuleInfo s in modules)
            {
                cmdText = "select descriptor, multpicator from subRecommendators where moduleDescriptor = @mod_name";
                SqlCommand cmd2 = new SqlCommand(cmdText, cnn);
                cmd2.Parameters.AddWithValue("@mod_name", s.Name);
                using (SqlDataReader oReader = cmd2.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string name = oReader.GetString(0);
                        int val = oReader.GetInt32(1);
                        SubMultiplicator ss = new SubMultiplicator();
                        ss.name = name;
                        ss.multiplicationValue = val;
                        s.SubMultiplicators.AddLast(ss);
                    }

                }

            }
            return new RecommendationsSystem(modules);

        }
    }
}
