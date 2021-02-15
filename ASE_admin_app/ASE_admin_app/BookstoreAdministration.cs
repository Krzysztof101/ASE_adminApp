using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{
    class BookstoreAdministration :IAdminGeneralFunctions
    {
        IDBGeneralInterface database;

        public BookstoreAdministration()
        {
            database = AdminDBPackagingClass.instance;
        }

        public bool addAuthor(Author newAuthor)
        {
            
            return database.addAuthor(newAuthor);
        }

        

        public LinkedList<Author> getAllAuthors()
        {
            return database.getAllAuthors();
        }

        public LinkedList<Author> getAllAuthorsMinuBookAuthors(Book book)
        {
            return database.getAllAuthorsMinuBookAuthors(book);
        }

        public LinkedList<Book> getAllBooks()
        {
            return database.getAllBooks();
        }

        public LinkedList<Category> getAllCategories()
        {
            return database.getAllCategories();
        }

        public LinkedList<Category> getCategriesBookDoesntbelongTo(Book book)
        {
            return database.getAllCategoriesMinusBookCategories(book);
        }

        public string operationSuccesfull()
        {
            return "";
        }

        public bool tryToAddCategory(Category newCategory)
        {
            if( database.categoryExists(newCategory) )
            {
                return false;
            }
            return database.addCategory(newCategory);
        }

        public string tryToUpdateCategory(Category categoryBeforeUpdate, Category categoryAfterUpdate)
        {
            if(database.categoryExists(categoryAfterUpdate)  )
            {
                return "category with new name already exists";
            }
            if( !database.categoryExists(categoryBeforeUpdate) )
            {
                return "no category with that name in database";
            }
            bool updateResult =  database.updateCategory(categoryBeforeUpdate, categoryAfterUpdate);
            if(updateResult)
            {
                return "";
            }
            return "Error while connecting with database or maing update";
        }

        public bool updateAuthor(Author authorAfterUpdate)
        {
            return database.updateAuthor(authorAfterUpdate);
        }

        public string updateBook(Book bookToUpdate)
        {
            if (bookToUpdate.Id == Book.newBookId)
            {
                return "incorrect book id";
            }
            string result = bookToUpdate.correct();
            try
            {

                if (result == Book.BookCorrect)
                {

                    bool updateResult = database.updateBook(bookToUpdate);
                    if (updateResult)
                    {
                        result = "book updated";
                    }
                    else
                        result = "Error while writting to database";
                }
                return result;
            }
            catch (Exception e)
            {
                return "Error while writting to database";
            }
        }

        public string addNewBook(Book newBook)
        {
            if (newBook.Id != Book.newBookId)
            {
                return "incorrect book id";
            }
            string result = newBook.correct();
            try
            {

                if (result == Book.BookCorrect)
                {

                    bool addResult = database.addNewBook(newBook);
                    if (addResult)
                    {
                        result = "book added";
                    }
                    else
                        result = "Error while writting to database";
                }
                return result;
            }
            catch (Exception e)
            {
                return "Error while writting to database";
            }

        }

        public string updateRecomsSystem(RecommendationsSystem recmosSystem)
        {
            bool updateResult = database.updateRecomsSystem(recmosSystem);
            if(updateResult)
            {
                return "System updated";
            }
            return "Failure while writting to database";
        }

        public RecommendationsSystem getRecomsSystem()
        {
            return database.getRecomsSystem();
        }
    }
}
