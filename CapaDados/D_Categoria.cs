using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;


namespace CapaDados
{
    public class D_Categoria
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Categoria> ListarCategorias(string buscar)
        {
            SqlDataReader LerFilas;

            SqlCommand cmd = new SqlCommand("SP_BUSCARCATEGORIA", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LerFilas = cmd.ExecuteReader();

            List<E_Categoria> Listar = new List<E_Categoria>();

            while (LerFilas.Read())
            {
                Listar.Add(new E_Categoria
                {
                    IdCategoria = LerFilas.GetInt32(0),
                    CodCategoria = LerFilas.GetString(1),
                    NomeCategoria = LerFilas.GetString(2),
                    DescricaoCategoria = LerFilas.GetString(3)
                });
            }
            connection.Close();
            LerFilas.Close();

            return Listar;
        }

        public void InserirCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERIRCATEGORIA", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@NOME", Categoria.NomeCategoria);
            cmd.Parameters.AddWithValue("@DESCRICAO", Categoria.DescricaoCategoria);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void EditarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", Categoria.IdCategoria);
            cmd.Parameters.AddWithValue("@NOME", Categoria.NomeCategoria);
            cmd.Parameters.AddWithValue("@DESCRICAO", Categoria.DescricaoCategoria);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void ExcluirCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EXCLUIRCATEGORIA", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", Categoria.IdCategoria);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
