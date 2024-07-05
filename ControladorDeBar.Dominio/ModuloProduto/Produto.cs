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

        public Produto(int idProduto, string nomeProduto)
        {
            this.IdProduto = idProduto;
            this.NomeProduto = nomeProduto;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto produtoAtualizado = (Produto)novoRegistro;

            IdProduto = produtoAtualizado.IdProduto;
            NomeProduto = produtoAtualizado.NomeProduto;
        }

        public override string ToString() //Transforma objet em string
        {
            return $"IdProduto: {IdProduto}, Nome: {NomeProduto}";
        }
    }
}
