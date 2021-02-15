using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_admin_app
{
    public partial class FormAdmin : Form
    {
        AdminNavigation navigation;
        public IAdminGeneralFunctions administrationFunctions { get; private set; }
        public FormAdmin(IAdminGeneralFunctions administration)
        {
            InitializeComponent();
            this.administrationFunctions = administration;
            navigation = new AdminNavigation(this);
            this.Refresh();
        }

        internal void switchControl(UserControl uc)
        {
            Controls.Clear();
            Controls.Add(uc);
            this.Refresh();
        }
    }
}
