using ClientBoutique.BoutiqueRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBoutique.Forms
{
    public partial class frmProduit : Form
    {
        Service1Client service = new Service1Client();
        public frmProduit()
        {
            InitializeComponent();
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            cbxCategorie.DataSource = service.GetCategories();
            cbxCategorie.DisplayMember = "Denomination";
            cbxCategorie.ValueMember = "Id";
            dgProduit.DataSource = service.GetProduits().ToList();
            cbxUnite.DataSource = service.GetUnites().ToList();
            cbxUnite.DisplayMember = "libelle";
            cbxUnite.ValueMember = "Id";
            btnReset.Visible = false;
        }

        private void btnSelectimage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                //pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                txtImage.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.QuantiteMinimale = !string.IsNullOrEmpty(txtQuantiteMinimale.Text)?int.Parse(txtQuantiteMinimale.Text):0;
            p.QuantiteQritique = !string.IsNullOrEmpty(txtQuantiteQritique.Text) ? int.Parse(txtQuantiteQritique.Text) : 0;
            p.Image = txtImage.Text;
            p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
            p.Quantite = 0;
            p.PrixUnitaire = !string.IsNullOrEmpty(txtPrix.Text) ? int.Parse(txtPrix.Text) : 0;
            p.IdUnite = int.Parse(cbxUnite.SelectedValue.ToString());
            
            service.AddProduit(p);
            Effacer();
        }

        public void Effacer()
        {
            txtCode.Clear();
            txtDesignation.Clear();
            txtImage.Clear();
            txtPrix.Clear();
            txtQuantiteMinimale.Clear();
            txtQuantiteQritique.Clear();
            cbxCategorie.DataSource = service.GetCategories();
            cbxCategorie.DisplayMember = "Denomination";
            cbxCategorie.ValueMember = "Id";
            cbxUnite.DataSource = service.GetUnites().ToList();
            cbxUnite.DisplayMember = "libelle";
            cbxUnite.ValueMember = "Id";
            dgProduit.DataSource = service.GetProduits().ToList();
            btnReset.Visible = false;
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.GetProduitById(id);
            txtCode.Text = p.CodeProduit;
            txtDesignation.Text = p.DesignationProduit;
            txtImage.Text = p.Image;
            txtPrix.Text = p.PrixUnitaire.ToString();
            txtQuantiteQritique.Text = p.QuantiteQritique.ToString();
            txtQuantiteMinimale.Text = p.QuantiteMinimale.ToString();
            cbxCategorie.SelectedValue = p.IdCategorie;
            cbxUnite.SelectedValue = p.IdUnite;
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            List<ProduitViewModel> liste = service.GetProduits().ToList();
            List<ProduitViewModel> filtered = new List<ProduitViewModel>();
            foreach (var p in liste)
            {
                if (p.Id.ToString().Contains(txtRecherche.Text) || p.DesignationProduit.ToLower().Contains(txtRecherche.Text.ToLower()) || p.CodeProduit.ToLower().Contains(txtRecherche.Text.ToLower()) || p.Categorie.ToLower().Contains(txtRecherche.Text.ToLower()) || p.Pu.ToString().Contains(txtRecherche.Text.ToLower()))
                {
                    filtered.Add(p);
                }
            }
            dgProduit.DataSource = filtered;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.GetProduitById(id);
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.QuantiteMinimale = int.Parse(txtQuantiteMinimale.Text);
            p.QuantiteQritique = int.Parse(txtQuantiteQritique.Text);
            p.Image = txtImage.Text;
            p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
            p.PrixUnitaire = int.Parse(txtPrix.Text);
            p.IdUnite = int.Parse(cbxUnite.SelectedValue.ToString());
            service.UpdateProduit(p);
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            service.DeleteProduit(id);
            Effacer();
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            service.ExportXls();
        }
    }
}
