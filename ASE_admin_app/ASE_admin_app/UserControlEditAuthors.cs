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
    public partial class UserControlEditAuthors : UserControl
    {
        INavEditAuthors navigation;
        IAuthorFunctions authorFunctions;
        Author editAddAuthor;
        public UserControlEditAuthors(INavEditAuthors navigation,IAuthorFunctions functions, Author toEdit)
        {
            InitializeComponent();
            this.navigation = navigation;
            editAddAuthor = toEdit;
            if(editAddAuthor!=null)
            {
                labelDescription.Text = "Edit author: " + toEdit.Name + " " + toEdit.LastName;
                buttonEditAdd.Text = "Edit Author";
            }
            authorFunctions = functions;
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            navigation.goToAuthors();
        }

        private void buttonEditAdd_Click(object sender, EventArgs e)
        {
           if(textBoxName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Insert name or last name.");
                return;
            }
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            if (editAddAuthor == null)
            {
                
                Author a = new Author(0, name, lastName);
                bool resultAdd = authorFunctions.addAuthor(a);
                if(resultAdd==true)
                {
                    MessageBox.Show("Author added");
                }
                else
                {
                    MessageBox.Show("Error while writting to database");
                }
           }
           else
           {
                Author a = new Author(editAddAuthor.Id, name, lastName);
                bool resultAdd = authorFunctions.updateAuthor(a);
                if (resultAdd == true)
                {
                    MessageBox.Show("Author updated");
                }
                else
                {
                    MessageBox.Show("Error while writting to database");
                }
           }
        }
    }
}
