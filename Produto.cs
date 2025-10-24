using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    public class Produto: Fabricante 
    {
        public string CodigoDeBarras { get; set; }

        public string Descricao { get; set;  }

        public decimal Preco { get; set; }

        public string concatenacaoDesCat()
        {

            return CodigoDeBarras + Descricao;
        }

    }
}
