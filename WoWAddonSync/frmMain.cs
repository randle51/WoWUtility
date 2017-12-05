using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WoWUtility
{
    public partial class frmMain : Form
    {
        GeneralFuncs GF;
        WoWFuncs WF;
        Settings MySet;
        MacroTranslator MT;
        

        public frmMain()
        {
            InitializeComponent();

            GF = new GeneralFuncs();
            WF = new WoWFuncs();
            MySet = new Settings();

        }

        private void btnDurchsuchen1_Click(object sender, EventArgs e)
        {
            txtPath1.Text = GF.OpenFileDialog();
            MySet.wowPath1 = txtPath1.Text;
        }

        private void btnDurchsuchen2_Click_1(object sender, EventArgs e)
        {
            txtPath2.Text = GF.OpenFileDialog();
            MySet.wowPath2 = txtPath2.Text;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Int16[] A1 = WF.GetAddonVersion(txtPath1.Text);
            Int16[] A2 = WF.GetAddonVersion(txtPath2.Text);

            //if (WF.IsNewerAddonVersion(A1, A2))
            //{
            //    GF.CopyFolder(txtPath1.Text, txtPath2.Text);
            //}
            //else
            //{
            //    MessageBox.Show("Älter");
            //}

            foreach (string s in WF.GetAddonList(txtPath1.Text))
            {
                clbAddons.Items.Add(s);
                for (int i = 0; i < clbAddons.Items.Count; i++)
                {
                    clbAddons.SetItemChecked(i, true);
                }
            }
        }

        private void btnMacro_Click(object sender, EventArgs e)
        {
            MT = new MacroTranslator(true, txtPath1.Text, MySet.GetSpellList());
        }

        private void btnMacro2_Click(object sender, EventArgs e)
        {
            MT = new MacroTranslator(false, txtPath1.Text, MySet.GetSpellList());
        }
    }
}
