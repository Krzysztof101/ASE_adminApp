using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{

    public interface IDBGeneralInterface : IDBCategories, IDBAuthors, IDBBooks, IDBEditBooks, IDBRecomsSystem
    {
        
    }
    public interface IDBCategories
    {
        bool addCategory(Category newCategory);
        bool updateCategory(Category categoryBeforeUpdate, Category categoryAfterUpdate);
        bool categoryExists(Category category);
        LinkedList<Category> getAllCategories();
    }
    public interface IDBAuthors
    {
        LinkedList<Author> getAllAuthors();
        bool addAuthor(Author newAuthor);
        bool updateAuthor(Author authorAfterUpdate);
    }
    public interface IDBBooks
    {
        LinkedList<Book> getAllBooks();
    }
    public interface IDBEditBooks
    {
        bool addNewBook(Book newBook);
        bool updateBook(Book toUpdate);
        LinkedList<Author> getAllAuthorsMinuBookAuthors(Book book);
        LinkedList<Category> getAllCategoriesMinusBookCategories(Book book);
    }
    public interface IDBRecomsSystem
    {
        bool updateRecomsSystem(RecommendationsSystem recSys);
        RecommendationsSystem getRecomsSystem();
    }



}
