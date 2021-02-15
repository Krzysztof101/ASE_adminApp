using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_admin_app
{
    class AdminNavigation : INavMainPanel, INavAuthors, INavBooks, INavCategories, INavEditAuthors, INavEditBooks, INavEditCategories, INavReccomendationsSystem
    {
        FormAdmin ownerForm;
        IAdminGeneralFunctions administrationFunctions;

        public AdminNavigation(FormAdmin ownerForm)
        {
            this.ownerForm = ownerForm;
            administrationFunctions = ownerForm.administrationFunctions;
            ownerForm.switchControl(new UserControlMainPanel(this));
        }
        public void goToAuthors()
        {
            ownerForm.switchControl(new UserControlAuthors(this, administrationFunctions));
        }


        public void goToBooks()
        {
            ownerForm.switchControl(new UserControlBooks(this, administrationFunctions));
        }

        public void goToCategories()
        {
            ownerForm.switchControl(new UserControlCategories(this, administrationFunctions));
        }

        public void goToEditAuthors(Author toEdit)
        {
            ownerForm.switchControl(new UserControlEditAuthors(this,administrationFunctions, toEdit));
        }

        public void goToEditBooks(Book toEdit)
        {
            ownerForm.switchControl(new UserControlEditBooks(this, administrationFunctions, toEdit));
        }

        public void goToEditCategories(Category toEdit)
        {
            ownerForm.switchControl(new UserControlEditCategories(this, administrationFunctions ,toEdit ));
        }

        public void goToMain()
        {
            ownerForm.switchControl(new UserControlMainPanel(this));
        }

        public void goToRecommendationsSystem()
        {
            ownerForm.switchControl(new UserControlRecommendationsSystem(this, administrationFunctions));
        }
    }
}
