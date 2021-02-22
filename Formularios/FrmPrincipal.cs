using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaApresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void TelaSize()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TelaSize();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form Menssagem = new FrmInformacao("SAIR DO SISTEMA ?");
            resultado = Menssagem.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void SelecionandoBotoes(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnPainel.Textcolor = Color.White;
            btnProdutos.Textcolor = Color.White;
            btnVendas.Textcolor = Color.White;
            btnCompras.Textcolor = Color.White;
            btnEmpregados.Textcolor = Color.White;
            btnClientes.Textcolor = Color.White;
            btnFornecedores.Textcolor = Color.White;
            btnLucro.Textcolor = Color.White;

            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 140);
            }
        }

        private void SeguirBotao(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            Flecha.Top = sender.Top;            
        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioWrapper(new FrmDashboard());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormularioWrapper(new FrmProdutos());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnEmpregados_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnLucro_Click(object sender, EventArgs e)
        {
            SelecionandoBotoes((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBotao((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private Form formativado = null;

        private void AbrirFormularioWrapper(Form FrmHijo)
        {
            if (formativado != null)
                formativado.Close();
            formativado = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FrmHijo);
            Wrapper.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
