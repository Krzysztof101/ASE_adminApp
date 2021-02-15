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
    public partial class UserControlRecommendationsSystem : UserControl
    {
        INavReccomendationsSystem navigation;
        IRecomsSystem adminFunctions;
        RecommendationsSystem recSys;
        public UserControlRecommendationsSystem(INavReccomendationsSystem navigation, IRecomsSystem adminFunctions)
        {
            InitializeComponent();
            this.navigation = navigation;
            this.adminFunctions = adminFunctions;
            recSys = adminFunctions.getRecomsSystem();
            LinkedList<ScoreModuleInfo> modules = recSys.ModulesInfo;
            foreach(ScoreModuleInfo s in modules)
            {
                ContainerScoreModuleInfo cont = new ContainerScoreModuleInfo(s);
                listBoxModules.Items.Add(cont);
            }
        }

        private void buttonMainPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMainPanel_Click_1(object sender, EventArgs e)
        {
            navigation.goToMain();
        }

        private void listBoxModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxModules.SelectedIndex!=-1)
            {
                ContainerScoreModuleInfo cont = (ContainerScoreModuleInfo)listBoxModules.SelectedItem;
                listBoxSubmultiplicators.Items.Clear();
                ScoreModuleInfo module = cont.Module;
                foreach(SubMultiplicator s in module.SubMultiplicators)
                {
                    listBoxSubmultiplicators.Items.Add(s);
                }
                textBoxMain.Text = module.MainMultiplicator.ToString();
                checkBoxActive.Checked = module.Active;
            }
        }

        private void listBoxSubmultiplicators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxSubmultiplicators.SelectedIndex!=-1)
            {
                SubMultiplicator s = (SubMultiplicator)listBoxSubmultiplicators.SelectedItem;
                textBoxSub.Text = s.multiplicationValue.ToString();

            }
        }

        private void buttonSetMain_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(textBoxMain.Text);
                if(val<=0)
                {
                    MessageBox.Show("Main multiplicator value must be greater than 0");
                    return;
                }
                if(listBoxModules.SelectedIndex!=-1)
                {
                    ContainerScoreModuleInfo cont = (ContainerScoreModuleInfo)listBoxModules.SelectedItem;
                    cont.Module.MainMultiplicator = val;
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxModules.SelectedIndex != -1)
            {
                ContainerScoreModuleInfo cont = (ContainerScoreModuleInfo)listBoxModules.SelectedItem;
                cont.Module.Active = checkBoxActive.Checked;
            }
        }

        private void buttonSetSub_Click(object sender, EventArgs e)
        {
            if(listBoxSubmultiplicators.SelectedIndex!=-1)
            {
                SubMultiplicator s = (SubMultiplicator)listBoxSubmultiplicators.SelectedItem;
                try
                {
                    int val = Convert.ToInt32( textBoxSub.Text);
                    s.multiplicationValue = val;

                }
                catch(Exception)
                {
                    MessageBox.Show("Incorrect data");
                }

            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            string resultUpdate = adminFunctions.updateRecomsSystem(recSys);
            MessageBox.Show(resultUpdate);
        }
    }
}
