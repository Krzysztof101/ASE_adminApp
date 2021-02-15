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
    public partial class UserControlEditCategories : UserControl
    {
        Category categoryToEdit;
        INavEditCategories navigation;
        ICategoryFunctions categoryFunctions;

        public UserControlEditCategories(INavEditCategories navigation, ICategoryFunctions categoryFunctions ,Category toEdit)
        {
            InitializeComponent();
            this.navigation = navigation;
            categoryToEdit = toEdit;
            this.categoryFunctions = categoryFunctions;
            if(categoryToEdit!= null)
            {
                labelDescription.Text = "rename category: " + categoryToEdit.categoryName;
                buttonAddEdit.Text = "rename category";
            }
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            navigation.goToCategories();
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            string newCategoryName = textBoxCategory.Text;
            if (textBoxCategory.Text == "")
            {
                MessageBox.Show("enter category name");
                return;
            }
            if (categoryToEdit==null)
            {
                // add new category
                Category c = new Category(newCategoryName);

                bool result = categoryFunctions.tryToAddCategory(c);
                if(result)
                {
                    MessageBox.Show("Category added.");
                }
                else
                {
                    MessageBox.Show("Category already exists or failure while writting to database.");
                }

            }
            else
            {
                //edit existing category

                Category c = new Category(newCategoryName);
                string result = categoryFunctions.tryToUpdateCategory(categoryToEdit, c);
                if(result ==categoryFunctions.operationSuccesfull())
                {
                    MessageBox.Show("Category updated.");
                }
                else
                {
                    MessageBox.Show("Category already exists or failure while writting to database.");
                }
            }
        }
    }
}
