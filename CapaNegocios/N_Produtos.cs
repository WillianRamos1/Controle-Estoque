using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using CapaDados;
using CapaNegocios;


namespace CapaNegocios
{
    public class N_Produtos
    {
        D_Produtos data = new D_Produtos();
        E_Produtos Negocios = new E_Produtos();

        public DataTable ListandoProdutos()
        {
            return data.ListarProdutos();
        }

        public DataTable ProcurarProdutos(string Buscar)
        {
                Negocios.Buscar = Buscar;
                return data.ProcurarProdutos(Negocios);
        }

        public void CriarProdutos(E_Produtos produto)
        {
            data.CriarProdutos(produto);
        }

        public DataTable AtualizarProdutos(E_Produtos produto)
        {
            return data.AtualizarProdutos(produto);
        }

        public void ExcluirProdutos(int IdProduto)
        {
            data.ExcluirProdutos(IdProduto);
        }

        public void Summaring(E_Produtos produto)
        {
            data.MostrarTotal(produto);
        }
    }
}
