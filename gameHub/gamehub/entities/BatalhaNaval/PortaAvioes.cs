using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.BatalhaNaval
{
    public class PortaAvioes : Embarcacoes
    {
        public PortaAvioes(int linha, int coluna) : base(linha, coluna)
        {
            LetraDaPeca = 'P';
        }
    }
}
