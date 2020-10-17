using ClientBoutique.BoutiqueRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBoutique.Forms
{
    public partial class frmCategorie : Form
    {
        Service1Client service = new Service1Client();
        public frmCategorie()
        {
            InitializeComponent();
        }
        

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            
            dgCategorie.DataSource = service.GetCategories().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() != "" && txtDenomination.Text.Trim() != "")
            {
                Categorie c = new Categorie();
                c.CodeCategorie = txtCode.Text;
                c.Denomination = txtDenomination.Text;
                service.AddCategorie(c);
                Effacer();
            }
            else
                MessageBox.Show("Veuiller Renseigner les Champs!", "Error", MessageBoxButtons.OK);
        }

        private void Effacer()
        {
            dgCategorie.DataSource = service.GetCategories().ToList();
            txtDenomination.Clear();
            txtCode.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idCategorie = int.Parse(dgCategorie.CurrentRow.Cells[2].Value.ToString());
            Categorie c = service.GetCategorieById(idCategorie);
            c.CodeCategorie = txtCode.Text;
            c.Denomination = txtDenomination.Text;
            service.UpdateCategorie(c);
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idCategorie = int.Parse(dgCategorie.CurrentRow.Cells[2].Value.ToString());
            service.DeleteCategorie(idCategorie);
            Effacer();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgCategorie.CurrentRow.Cells[0].Value.ToString();
            txtDenomination.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text.Trim() != "")
                dgCategorie.DataSource = service.GetFilteredCategories(txtRecherche.Text);
            else
                dgCategorie.DataSource = service.GetCategories();
        }        
    }
}
