using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDados;
using CapaEntidades;


namespace CapaNegocios
{
    public class N_Marca
    {
        D_Marca objData = new D_Marca();

        public List<E_Marca>ListarMarca(string buscar)
        {
            return objData.ListarMarca(buscar);
        }

        public void InserindoMarca(E_Marca Marca)
        {
            objData.InserirMarca(Marca);
        }

        public void EditandoMarca(E_Marca Marca)
        {
            objData.EditarMarca(Marca);
        }

        public void ExcluirMarca(E_Marca Marca)
        {
            objData.ExcluirMarca(Marca);
        }

    }
}
