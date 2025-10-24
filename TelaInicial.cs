using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoPOO
{
    public partial class TelaInicial: Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        BrinquedoExecução BrinquedoExecucao = new BrinquedoExecução();
        private void telaDeBrinquedosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tela = new TelaBrinquedos(BrinquedoExecucao);
                tela.ShowDialog();
        }


    }
}
