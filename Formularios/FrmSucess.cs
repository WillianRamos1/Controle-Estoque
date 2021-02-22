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
    public partial class FrmSucess : Form
    {
        public FrmSucess(string Mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = Mensagem;
        }

        private void FrmSucess_Load(object sender, EventArgs e)
        {
            FormEsclarecer.ShowAsyc(this);
        }

        public static void ConfirmacaoForm(string Mensagem)
        {
            FrmSucess frm = new FrmSucess(Mensagem);
            frm.ShowDialog();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
