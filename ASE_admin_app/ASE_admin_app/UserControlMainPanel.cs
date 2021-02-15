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
    public partial class UserControlMainPanel : UserControl
    {
        INavMainPanel navigation;
        public UserControlMainPanel(INavMainPanel navigation)
        {
            InitializeComponent();
            this.navigation = navigation;
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            navigation.goToBooks();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            navigation.goToAuthors();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            navigation.goToCategories();
        }

        private void buttonRecommendationsSystem_Click(object sender, EventArgs e)
        {
            navigation.goToRecommendationsSystem();
        }
    }
}
