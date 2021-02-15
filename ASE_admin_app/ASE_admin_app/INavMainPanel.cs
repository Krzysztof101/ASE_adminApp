using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_admin_app
{
    public interface INavMainPanel :INavEditAuthors, INavEditBooks, INavEditCategories
    {

        //void goToBooks();
        //void goToAuthors();
        //void goToCategories();
        void goToRecommendationsSystem();
    }
    
    public interface INavGoToMain
    {
        void goToMain();
    }
    public interface INavBooks :INavGoToMain
    {
        void goToEditBooks(Book toEdit);
    }
    public interface INavEditBooks
    {
        void goToBooks();
    }
    public interface INavAuthors :INavGoToMain
    {
        void goToEditAuthors(Author toEdit);
    }
    public interface INavEditAuthors
    {
        void goToAuthors();
    }
    public interface INavCategories :INavGoToMain
    {
        void goToEditCategories(Category categoryToEdit);
    }
    public interface INavEditCategories
    {
        void goToCategories();
    }
    public interface INavReccomendationsSystem :INavGoToMain
    {
        
    }
}
