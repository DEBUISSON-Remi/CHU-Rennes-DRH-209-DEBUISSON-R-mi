using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHU_Rennes_DRH
{
    public partial class fmr_crd : Form
    {
        public fmr_crd()
        {
            InitializeComponent();
            // TODO: cette ligne de code charge les données dans la table 'databaseDataSet2.Users'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.usersTableAdapter.Fill(this.databaseDataSet2.Users);
            // TODO: cette ligne de code charge les données dans la table 'databaseDataSet1.Formations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.formationsTableAdapter.Fill(this.databaseDataSet1.Formations);
            //SQLITE DOCUMENTATION: https://docs.microsoft.com/fr-fr/dotnet/standard/data/sqlite/?tabs=netcore-cli
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbx_selectFormation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbl_formationName.Text = formationsTableAdapter.Fill;
            int userId = cbx_selectFormation.SelectedIndex;
            if (usersTableAdapter.GetData()[userId][2] != null) {
                int formationId = Convert.ToInt32(usersTableAdapter.GetData()[userId][2]) - 1;
                lbl_formationName.Text = formationsTableAdapter.GetData()[formationId][1].ToString();
                lbl_formationDesc.Text = formationsTableAdapter.GetData()[formationId][2].ToString();
                lkl_formationLink.Text = formationsTableAdapter.GetData()[formationId][3].ToString();
                lkl_formationLink.Links.Clear();
                lkl_formationLink.Links.Add(0, lkl_formationLink.Text.Length, lkl_formationLink.Text);
            } else {
                lbl_formationName.Text = "Aucune formation";
                lbl_formationDesc.Text = "";
                lkl_formationLink.Text = "";
                lkl_formationLink.Links.Clear();
            }
        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {

            //TODO: Change id
            this.usersTableAdapter.Insert(4, tbx_createUser.Text, cbx_createUserFormation.SelectedIndex+1);
            //this.usersTableAdapter.Update(this);
            
        }

        private void lkl_formationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lkl_formationLink.Text);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_selectuser_Click(object sender, EventArgs e)
        {

        }
    }
}
