using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControladorDeBar.Dominio.ModuloCompartilhado;

namespace ControladorDeBar.Dominio.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public decimal PrecoProduto { get; set; }

        public Produto(string nomeProduto, decimal precoProduto)
        {
            this.NomeProduto = nomeProduto;
            this.PrecoProduto = precoProduto;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto produtoAtualizado = (Produto)novoRegistro;

            NomeProduto = produtoAtualizado.NomeProduto;
            PrecoProduto = produtoAtualizado.PrecoProduto;
        }

        public override string ToString() //Transforma objet em string
        {
            return $"IdProduto: {IdProduto}, Nome: {NomeProduto}, Preço: {PrecoProduto}";
        }
    }
}
