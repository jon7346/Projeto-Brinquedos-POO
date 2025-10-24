using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    public class Brinquedos:Produto
    {
        public string Categoria { get; set; }
        
        public string IdadeMinima { get; set; }

        public string ConcacatenacaoCategoria()
        {
            return concatenacaoDesCat() + Categoria; 
        } 
        public string ConcatenacaoCategoriaNomeFabri()
        {
            return ConcacatenacaoCategoria() + Nome;
        }
    }

}
