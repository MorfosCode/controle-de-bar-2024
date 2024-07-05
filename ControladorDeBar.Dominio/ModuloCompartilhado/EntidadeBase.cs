using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDeBar.Dominio.ModuloCompartilhado
{
    public abstract class EntidadeBase
    {
        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
