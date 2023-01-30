using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.BatalhaNaval
{
    public class Agua : Embarcacoes
    {
        public Agua() { }

        public Agua(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            LetraDaPeca = '~';
        }
    }
}
