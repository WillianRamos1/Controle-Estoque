using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaEntidades
{
    public class E_Produtos
    {
        private int _IdProduto;
        private string _CodigoProduto;
        private string _Produto;
        private int _IdCategoria;
        private int _IdMarca;
        private decimal _PrecoCompra;
        private decimal _PrecoVenda;
        private int _Stock;
        private string _Buscar;

        private string totalCategorias;
        private string totalMarcas;
        private string totalProdutos;
        private string totalEstoque;


        public int IdProduto { get => _IdProduto; set => _IdProduto = value; }
        public string CodigoProduto { get => _CodigoProduto; set => _CodigoProduto = value; }
        public string Produto { get => _Produto; set => _Produto = value; }
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public int IdMarca { get => _IdMarca; set => _IdMarca = value; }
        public decimal PrecoCompra { get => _PrecoCompra; set => _PrecoCompra = value; }
        public decimal PrecoVenda { get => _PrecoVenda; set => _PrecoVenda = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }


        public string TotalCategorias { get => totalCategorias; set => totalCategorias = value; }
        public string TotalMarcas { get => totalMarcas; set => totalMarcas = value; }
        public string TotalProdutos { get => totalProdutos; set => totalProdutos = value; }
        public string TotalEstoque { get => totalEstoque; set => totalEstoque = value; }
    }
}
