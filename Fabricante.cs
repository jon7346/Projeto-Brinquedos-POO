using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    public class Fabricante
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }

        public string Concatenacao()
        { return Nome + CNPJ;  }


    }
}
