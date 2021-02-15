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
    public partial class UserControlCategories : UserControl
    {
        INavCategories navigation;
        ICategoryFunctions categoriesFunctions;
        LinkedList<Category> categories;
        public UserControlCategories(INavCategories navigation, ICategoryFunctions administration)
        {
            InitializeComponent();
            this.navigation = navigation;
            categoriesFunctions = administration;
            categories = categoriesFunctions.getAllCategories();
            foreach(Category category in categories)
            {
                listBoxCategories.Items.Add(category);
            }
            
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if(listBoxCategories.SelectedIndex==-1)
            {
                return;
            }
            else
            {
                Category selectedCategory = (Category)listBoxCategories.SelectedItem;
                navigation.goToEditCategories(selectedCategory);
            }
            //navigation.goToEditCategories(c);
        }

        private void buttonMainPanel_Click(object sender, EventArgs e)
        {
            navigation.goToMain();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            navigation.goToEditCategories(null);
        }
    }
}
