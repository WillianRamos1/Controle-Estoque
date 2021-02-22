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
    public partial class FrmCategoria : Form
    {
        private string idcategoria;
        private bool Editarse = false;


        E_Categoria objEntidate = new E_Categoria();
        N_Categoria objNegocio = new N_Categoria();


        public FrmCategoria()
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

        private void TabelaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabela("");
            AdicionarTabela();
        }

        public void AdicionarTabela()
        {
            TabelaCategoria.ClearSelection();

            TabelaCategoria.Columns[0].Visible = false;
            TabelaCategoria.Columns[1].Width = 60;
            TabelaCategoria.Columns[2].Width = 170;

        }

        public void MostrarBuscarTabela(string buscar)
        {
            N_Categoria objNegocio = new N_Categoria();
            TabelaCategoria.DataSource = objNegocio.ListarCategoria(buscar);
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
            txtCodigo.Focus();
        }

        private void btnNOVO_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TabelaCategoria.SelectedRows.Count > 0)
            {
                Editarse = true;
                idcategoria = TabelaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = TabelaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNome.Text = TabelaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescricao.Text = TabelaCategoria.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Selecione a linha que deseja editar");

            TabelaCategoria.ClearSelection();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    
                    objEntidate.NomeCategoria = txtNome.Text.ToUpper();
                    objEntidate.DescricaoCategoria = txtDescricao.Text.ToUpper();

                    objNegocio.InserindoCategoria(objEntidate);

                    MessageBox.Show("Salvo com sucesso");
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
                    objEntidate.IdCategoria = Convert.ToInt32(idcategoria);
                    objEntidate.NomeCategoria = txtNome.Text.ToUpper();
                    objEntidate.DescricaoCategoria = txtDescricao.Text.ToUpper();


                    objNegocio.EditandoCategoria(objEntidate); 

                    MessageBox.Show("Edição Salva com sucesso");
                    MostrarBuscarTabela("");
                    LimparCampos();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar os dados, Verifique os campos" + ex);
                }
            }
            TabelaCategoria.ClearSelection();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (TabelaCategoria.SelectedRows.Count > 0)
            {
                objEntidate.IdCategoria = Convert.ToInt32(TabelaCategoria.CurrentRow.Cells[0].Value.ToString());
                objNegocio.ExcluirCategoria(objEntidate);

                
                MostrarBuscarTabela("");
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("Selecione a linha que deseja apagar");
            }

            TabelaCategoria.ClearSelection();
        }
    }
}
