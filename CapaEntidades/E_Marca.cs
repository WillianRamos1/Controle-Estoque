using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Marca
    {
        private int _IdMarca;
        private string _CodigoMarca;
        private string _NomeMarca;
        private string _DescricaoMarca;

        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public string CodigoMarca { get => _CodigoMarca; set => _CodigoMarca = value; }
        public string NomeMarca { get => _NomeMarca; set => _NomeMarca = value; }
        public string DescricaoMarca { get => _DescricaoMarca; set => _DescricaoMarca = value; }
    }
}
