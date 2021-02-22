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
    public partial class NovoProduto : Form
    {
        FrmProdutos Frm = new FrmProdutos();
        E_Produtos entidade = new E_Produtos();
        N_Produtos negocios = new N_Produtos();

        public bool Atualizar = false;

        public NovoProduto()
        {
            InitializeComponent();
            ListarCategoria();
            ListarMarcas();
        }

        public void ListarCategoria()
        {
            N_Categoria negocios = new N_Categoria();
            BoxCategoria.DataSource = negocios.ListarCategoria("");
            BoxCategoria.ValueMember = "IdCategoria";
            BoxCategoria.DisplayMember = "NomeCategoria";
        }
        public void ListarMarcas()
        {
            N_Marca negocios = new N_Marca();
            BoxMarca.DataSource = negocios.ListarMarca("");
            BoxMarca.ValueMember = "IdMarca";
            BoxMarca.DisplayMember = "NomeMarca";
        }

        private void FecharForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Atualizar == false)
            {
                try
                {
                    entidade.Produto = txtProduto.Text;
                    entidade.PrecoCompra = Convert.ToDecimal(txtCompra.Text);
                    entidade.PrecoVenda = Convert.ToDecimal(txtVenda.Text);
                    entidade.Stock = Convert.ToInt32(txtEstoque.Text);
                    entidade.IdCategoria = Convert.ToInt32(BoxCategoria.SelectedValue);
                    entidade.IdMarca = Convert.ToInt32(BoxMarca.SelectedValue);

                    negocios.CriarProdutos(entidade);
                    FrmSucess.ConfirmacaoForm("PRODUTO SALVO");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar o produto" + ex);
                }
            }
            if (Atualizar == true)
            {
                try
                {

                    entidade.Produto = txtProduto.Text.ToUpper();
                    entidade.PrecoCompra = Convert.ToDecimal(txtCompra.Text.ToUpper());
                    entidade.PrecoVenda = Convert.ToDecimal(txtVenda.Text.ToUpper());
                    entidade.Stock = Convert.ToInt32(txtEstoque.Text.ToUpper());
                    entidade.IdCategoria = Convert.ToInt32(BoxCategoria.SelectedValue);
                    entidade.IdMarca = Convert.ToInt32(BoxMarca.SelectedValue);

                    negocios.AtualizarProdutos(entidade);
       
                    FrmSucess.ConfirmacaoForm("PRODUTO EDITADO COM SUCESSO");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O produto não pode ser editado" + ex);            
                }
            }
        }
    }
}
