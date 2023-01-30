using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.BatalhaNaval
{
    public class Submarino : Embarcacoes
    {
        public Submarino(int linha, int coluna) : base(linha, coluna)
        {
            LetraDaPeca = 'S';
        }
    }
}
