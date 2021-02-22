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
    public partial class FrmInformacao : Form
    {
        public FrmInformacao(string Mensagem)
        {
            InitializeComponent();
            lblMensagem.Text = Mensagem;
        }

        private void FrmInformacao_Load(object sender, EventArgs e)
        {
            FormEsclarecer.ShowAsyc(this);
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
