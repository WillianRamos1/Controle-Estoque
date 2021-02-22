using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDados;


namespace CapaNegocios
{
    public class N_Categoria
    {
        D_Categoria objData = new D_Categoria();

        public List<E_Categoria> ListarCategoria(string buscar)
        {
            return objData.ListarCategorias(buscar);
        }

        public void InserindoCategoria(E_Categoria Categoria)
        {
            objData.InserirCategoria(Categoria);
        }

        public void EditandoCategoria(E_Categoria Categoria)
        {
            objData.EditarCategoria(Categoria);
        }

        public void ExcluirCategoria(E_Categoria Categoria)
        {
            objData.ExcluirCategoria(Categoria);
        }
    }
}
