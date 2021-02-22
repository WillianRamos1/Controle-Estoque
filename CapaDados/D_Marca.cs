using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;


namespace CapaDados
{
    public class D_Marca
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Marca>ListarMarca(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARMARCA", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Marca> Listar = new List<E_Marca>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Marca
                {
                    IdMarca = LeerFilas.GetInt32(0),
                    CodigoMarca = LeerFilas.GetString(1),
                    NomeMarca = LeerFilas.GetString(2),
                    DescricaoMarca = LeerFilas.GetString(3)
                });
            }

            connection.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InserirMarca(E_Marca Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERIRMARCA", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            connection.Open();

            cmd.Parameters.AddWithValue("@NOME", Marca.NomeMarca);
            cmd.Parameters.AddWithValue("@DESCRICAO", Marca.DescricaoMarca);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void EditarMarca(E_Marca Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARMARCA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDMARCA", Marca.IdMarca);
            cmd.Parameters.AddWithValue("@NOME", Marca.NomeMarca);
            cmd.Parameters.AddWithValue("DESCRICAO", Marca.DescricaoMarca);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void ExcluirMarca(E_Marca Marca)
        {
            SqlCommand cmd = new SqlCommand("SP_EXCLUIRMARCA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDMARCA", Marca.IdMarca);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
