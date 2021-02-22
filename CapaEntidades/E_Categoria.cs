using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Categoria
    {
        private int _IdCategoria;
        private string _CodCategoria;
        private string _NomeCategoria;
        private string _DescricaoCategoria;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string CodCategoria { get => _CodCategoria; set => _CodCategoria = value; }
        public string NomeCategoria { get => _NomeCategoria; set => _NomeCategoria = value; }
        public string DescricaoCategoria { get => _DescricaoCategoria; set => _DescricaoCategoria = value; }
    }
}
