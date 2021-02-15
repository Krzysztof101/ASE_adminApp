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
    public partial class UserControlAuthors : UserControl
    {
        INavAuthors navigation;
        IAuthorFunctions authorFunctions;
        public UserControlAuthors(INavAuthors navigation, IAuthorFunctions authorFunctions)
        {
            InitializeComponent();
            this.navigation = navigation;
            this.authorFunctions = authorFunctions;
            LinkedList<Author> authors = authorFunctions.getAllAuthors();
            foreach(Author a in authors)
            {
                listBoxAuthors.Items.Add(a);
            }
        }

        private void buttonMainPanel_Click(object sender, EventArgs e)
        {
            navigation.goToMain();
        }

        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            if(listBoxAuthors.SelectedIndex==-1)
            {
                return;
            }
            Author selectedAuthor = (Author)listBoxAuthors.SelectedItem;
            navigation.goToEditAuthors(selectedAuthor);
        }

        private void buttonNewAuthor_Click(object sender, EventArgs e)
        {
            navigation.goToEditAuthors(null);
        }
    }
}
