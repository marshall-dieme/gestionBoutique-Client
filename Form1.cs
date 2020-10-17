using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientBoutique.Forms;
using FontAwesome.Sharp;

namespace ClientBoutique
{
    public partial class MainForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderPane;
        private Form activeForm;
        //Constructor
        public MainForm()
        {
            InitializeComponent();
            leftBorderPane = new Panel();
            leftBorderPane.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderPane);
        }

        //Dragable panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Methods

        private void ActivateButton(object btnSender)
        {
            currentBtn = (IconButton)btnSender;
            leftBorderPane.BackColor = Color.White;
            leftBorderPane.Location = new Point(0, currentBtn.Location.Y);
            leftBorderPane.Visible = true;
            leftBorderPane.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategorie(), sender);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProduit(), sender);
        }

        private void btnAppro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAppro(), sender);
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            leftBorderPane.Visible = false;

        }

         private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
