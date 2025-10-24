using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    public class BrinquedoExecução
    {
        private List<Brinquedos> BrinquedosExecucao = new List<Brinquedos>();

        public void Adicionar(Brinquedos brinquedo)
        {
            BrinquedosExecucao.Add(brinquedo);

        } 
        public void Remover(Brinquedos brinquedo)
        {
            BrinquedosExecucao.Remove(brinquedo); 
        }

        public List<Brinquedos> ListarBrinquedos()
        {
            return BrinquedosExecucao;
        }
    }
}
