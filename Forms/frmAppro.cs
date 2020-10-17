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
    public partial class frmAppro : Form
    {
        Service1Client service = new Service1Client();
        public frmAppro()
        {
            InitializeComponent();
        }

        private void frmAppro_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = service.GetProduits().ToList();
            cbxUnite.DisplayMember = "libelle";
            cbxUnite.ValueMember = "Id";
            cbxUnite.DataSource = service.GetUnites().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.GetProduitById(id);
            if(txtQuantite.Text.Trim() != "")
            {
                Stock st = new Stock();
                st.Numero = service.StockGenerator();
                
                st.Quantite = int.Parse(txtQuantite.Text);
                st.PrixUnitaire = p.PrixUnitaire;
                st.Total = st.PrixUnitaire * st.Quantite;
                st.Type = "Entree";
                st.IdProduit = p.Id;
                bool ret = service.AddStock(st);
                if (ret == true)
                {
                 p.Quantite = p.Quantite + int.Parse(txtQuantite.Text);
                 service.UpdateProduit(p);
                 Effacer();
                }
               
            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.GetProduitById(id);
            txtQuantiteActuelle.Text = p.Quantite.ToString();
            cbxUnite.SelectedValue = p.IdUnite;
        }

        private void Effacer()
        {
            txtQuantite.Text = string.Empty;
            txtQuantiteActuelle.Text = string.Empty;
            dgProduit.DataSource = service.GetProduits().ToList();
            cbxUnite.DataSource = service.GetUnites().ToList();
            cbxUnite.DisplayMember = "libelle";
            cbxUnite.ValueMember = "Id";
        }
    }
}
