using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;


namespace CapaApresentacao
{
    public partial class FrmMarcas : Form
    {
        private string idmarca;
        private bool Editarse = false;


        E_Marca objEntidate = new E_Marca();
        N_Marca objNegocio = new N_Marca();


        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TabelaMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabela("");
            AdicionarTabela();
        }

        public void AdicionarTabela()
        {
            TabelaMarca.ClearSelection();

            TabelaMarca.Columns[0].Visible = false;
            TabelaMarca.Columns[1].Width = 60;
            TabelaMarca.Columns[2].Width = 170;

        }

        public void MostrarBuscarTabela(string buscar)
        {
            N_Marca objNegocio = new N_Marca();
            TabelaMarca.DataSource = objNegocio.ListarMarca(buscar);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabela(txtPesquisar.Text);
        }


        private void LimparCampos()
        {
            Editarse = false;
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtNome.Focus();
        }

        private void btnNOVO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TabelaMarca.SelectedRows.Count > 0)
            {
                Editarse = true;
                idmarca = TabelaMarca.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = TabelaMarca.CurrentRow.Cells[1].Value.ToString();
                txtNome.Text = TabelaMarca.CurrentRow.Cells[2].Value.ToString();
                txtDescricao.Text = TabelaMarca.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Selecione a linha que deseja editar");

            TabelaMarca.ClearSelection();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    
                    objEntidate.NomeMarca = txtNome.Text.ToUpper();
                    objEntidate.DescricaoMarca = txtDescricao.Text.ToUpper();

                    objNegocio.InserindoMarca(objEntidate);

                    FrmSucess.ConfirmacaoForm("Salvo");
                    MostrarBuscarTabela("");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar os dados, Verifique os campos" + ex);
                }
            }
            if (Editarse == true)
            {
                try
                {
                    objEntidate.IdMarca = Convert.ToInt32(idmarca);
                    objEntidate.NomeMarca = txtNome.Text.ToUpper();
                    objEntidate.DescricaoMarca = txtDescricao.Text.ToUpper();


                    objNegocio.EditandoMarca(objEntidate);

                    FrmSucess.ConfirmacaoForm("Editado");
                    MostrarBuscarTabela("");
                    LimparCampos();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar os dados, Verifique os campos" + ex);
                }
            }
            TabelaMarca.ClearSelection();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = new DialogResult();
                FrmInformacao frm = new FrmInformacao("CONFIRME A EXCLUSÃO DO REGISTRO");
                resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    objEntidate.IdMarca = Convert.ToInt32(TabelaMarca.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.ExcluirMarca(objEntidate);

                    FrmSucess.ConfirmacaoForm("EXCLUIDO");
                    MostrarBuscarTabela("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione a linha que deseja apagar" + ex);
            }

           TabelaMarca.ClearSelection();
        }
    }
}
