using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_admin_app
{
    public interface IAdminGeneralFunctions : ICategoryFunctions, IAuthorFunctions, IBookFunctions, IEditBooks, IRecomsSystem
    {

    }
    public interface ICategoryFunctions : IGetAllCategories
    {
        bool tryToAddCategory(Category newCategory);
        string tryToUpdateCategory(Category categoryBeforeUpdate, Category categoryAfterUpdate);
        //bool categoryExists(Category category);
        
        string operationSuccesfull();
    }
    /*
    public interface IBookFunctions
    {
        LinkedList<Book> getAllBooks();
    }
    */
    public interface IGetAllAuthors
    {
        LinkedList<Author> getAllAuthors();
    }
    public interface IGetAllCategories
    {
        LinkedList<Category> getAllCategories();
    }
    public interface IEditBooks : IOperationSuccesful
    {
        LinkedList<Category> getCategriesBookDoesntbelongTo(Book book);
        LinkedList<Author> getAllAuthorsMinuBookAuthors(Book book);
        string updateBook(Book bookToUpdate);
        string addNewBook(Book newBook);

    }
    public interface IAuthorFunctions :IGetAllAuthors
    {
        bool addAuthor(Author newAuthor);
        bool updateAuthor(Author authorAfterUpdate);
    }
    public interface IBookFunctions :IGetAllAuthors, IGetAllCategories
    {
        //LinkedList<Category> getBookCategory(Book book);
        //LinkedList<Author> getBookAuthors(Book book);
        //bool updateBook(Book updatedBook);
        //bool addNewBook(Book newBook);
        LinkedList<Book> getAllBooks();

    }
    public interface IOperationSuccesful
    {
        string operationSuccesfull();
    }
    public interface IRecomsSystem
    {
        string updateRecomsSystem(RecommendationsSystem recmosSystem);
        RecommendationsSystem getRecomsSystem();
    }
}
