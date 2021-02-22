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
using Excel = Microsoft.Office.Interop.Excel;


namespace CapaApresentacao
{
    public partial class FrmProdutos : Form
    {
        N_Produtos Negocios = new N_Produtos();
        public FrmProdutos()
        {
            InitializeComponent();
            MostrarTabelaProdutos();
            OcultarMover();
            MostrarTotal();
        }


        public void OcultarMover()
        {
            TabelaProdutos.Columns[2].Visible = false;
            TabelaProdutos.Columns[5].Visible = false;
            TabelaProdutos.Columns[7].Visible = false;

            TabelaProdutos.Columns[0].DisplayIndex = 11;
            TabelaProdutos.Columns[1].DisplayIndex = 11;

            TabelaProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TabelaProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void MostrarTabelaProdutos()
        {
            N_Produtos Negocios = new N_Produtos();
            TabelaProdutos.DataSource = Negocios.ListandoProdutos();
        }

        public void ProcurarProdutos(string Buscar)
        {
            N_Produtos Negocios = new N_Produtos();
            TabelaProdutos.DataSource = Negocios.ProcurarProdutos(Buscar);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            ProcurarProdutos(txtPesquisar.Text);
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            NovoProduto frm = new NovoProduto();
            frm.ShowDialog();
            frm.Atualizar = false;
            MostrarTabelaProdutos();
            MostrarTotal();
        }

        public void MostrarTotal()
        {
            E_Produtos entidade = new E_Produtos();
            N_Produtos negocios = new N_Produtos();

            negocios.Summaring(entidade);
            lblCategoria.Text = entidade.TotalCategorias;
            lblMarca.Text = entidade.TotalMarcas;
            lblProdutos.Text = entidade.TotalProdutos;
            lblTotalStock.Text = entidade.TotalEstoque;
        }

        private void TabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TabelaProdutos.Rows[e.RowIndex].Cells["EXCLUIR"].Selected)
            {
                FrmInformacao mensagem = new FrmInformacao("Deseja excluir o produto selecionado ?");
                DialogResult result = mensagem.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int deletar = Convert.ToInt32(TabelaProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Negocios.ExcluirProdutos(deletar);
                    FrmSucess.ConfirmacaoForm("EXCLUIDO");
                    MostrarTabelaProdutos();
                    MostrarTotal();
                }
            }
            else if (TabelaProdutos.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                NovoProduto frm = new NovoProduto();
                frm.Atualizar = true;
                frm.txtCodigo.Text = TabelaProdutos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                frm.txtProduto.Text = TabelaProdutos.Rows[e.RowIndex].Cells["PRODUTO"].Value.ToString();
                frm.txtCompra.Text = TabelaProdutos.Rows[e.RowIndex].Cells["PRECO_COMPRA"].Value.ToString();
                frm.txtVenda.Text = TabelaProdutos.Rows[e.RowIndex].Cells["PRECO_VENDA"].Value.ToString();
                frm.txtEstoque.Text = TabelaProdutos.Rows[e.RowIndex].Cells["STOCK"].Value.ToString();
                frm.BoxCategoria.Text = TabelaProdutos.Rows[e.RowIndex].Cells["IDCATEGORIA"].Value.ToString();
                frm.BoxMarca.Text = TabelaProdutos.Rows[e.RowIndex].Cells["IDMARCA"].Value.ToString();

                frm.ShowDialog();
                MostrarTabelaProdutos();
                MostrarTotal();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
            MostrarTotal();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frm = new FrmMarcas();
            frm.ShowDialog();
            MostrarTotal();
        }

        private void copyAlltoClipboard()
        {
            TabelaProdutos.RowHeadersVisible = false;
            TabelaProdutos.SelectAll();
            DataObject dataObj = TabelaProdutos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
