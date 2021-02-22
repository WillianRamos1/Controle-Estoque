using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDados;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CapaDados
{
    public class D_Produtos
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarProdutos()
        {
            DataTable tabela = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_LISTARPRODUTOS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            LeerFilas = cmd.ExecuteReader();
            tabela.Load(LeerFilas);

            LeerFilas.Close();
            connection.Close();

            return tabela;
        }

        public DataTable ProcurarProdutos(E_Produtos produto)
        {
            DataTable tabela = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_PROCURARPRODUTOS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", produto.Buscar);

            LeerFilas = cmd.ExecuteReader();
            tabela.Load(LeerFilas);

            LeerFilas.Close();
            connection.Close();

            return tabela;
        }

        public void ExcluirProdutos(int IdProduto)
        {
            SqlCommand cmd = new SqlCommand("SP_EXCLUIRPRODUTO", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDPRODUTO", IdProduto);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void CriarProdutos(E_Produtos produtos)
        {
            SqlCommand cmd = new SqlCommand("SP_CRIARPRODUTO", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@PRODUTO", produtos.Produto);
            cmd.Parameters.AddWithValue("@PRECO_COMPRA", produtos.PrecoCompra);
            cmd.Parameters.AddWithValue("@PRECO_VENDA", produtos.PrecoVenda);
            cmd.Parameters.AddWithValue("@STOCK", produtos.Stock);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produtos.IdCategoria);
            cmd.Parameters.AddWithValue("@IDMARCA", produtos.IdMarca);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public DataTable AtualizarProdutos(E_Produtos produtos)
        {
            DataTable tabela = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_ATUALIZARPRODUTOS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDPRODUTO", produtos.IdProduto);
            cmd.Parameters.AddWithValue("@PRODUTO", produtos.Produto);
            cmd.Parameters.AddWithValue("@PRECO_COMPRA", produtos.PrecoCompra);
            cmd.Parameters.AddWithValue("@PRECO_VENDA", produtos.PrecoVenda);
            cmd.Parameters.AddWithValue("@STOCK", produtos.Stock);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", produtos.IdCategoria);
            cmd.Parameters.AddWithValue("@IDMARCA", produtos.IdMarca);

            LeerFilas = cmd.ExecuteReader();
            tabela.Load(LeerFilas);

            LeerFilas.Close();

            connection.Close();

            return tabela;
        }

        public void MostrarTotal(E_Produtos produtos)
        {
            SqlCommand cmd = new SqlCommand("summary", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalCategorias = new SqlParameter("@TOTALCATEGORIA", 0);
            totalCategorias.Direction = ParameterDirection.Output;

            SqlParameter totalMarcas = new SqlParameter("@TOTALMARCAS", 0);
            totalMarcas.Direction = ParameterDirection.Output;

            SqlParameter totalProdutos = new SqlParameter("@TOTALPRODUTOS", 0);
            totalProdutos.Direction = ParameterDirection.Output;

            SqlParameter totalEstoque = new SqlParameter("@TOTALESTOQUE", 0);
            totalEstoque.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalCategorias);
            cmd.Parameters.Add(totalMarcas);
            cmd.Parameters.Add(totalProdutos);
            cmd.Parameters.Add(totalEstoque);
            connection.Open();

            cmd.ExecuteNonQuery();

            produtos.TotalCategorias = cmd.Parameters["@TOTALCATEGORIA"].Value.ToString();
            produtos.TotalMarcas = cmd.Parameters["@TOTALMARCAS"].Value.ToString();
            produtos.TotalProdutos = cmd.Parameters["@TOTALPRODUTOS"].Value.ToString();
            produtos.TotalEstoque = cmd.Parameters["@TOTALESTOQUE"].Value.ToString();

            connection.Close();
        }
    }
}
