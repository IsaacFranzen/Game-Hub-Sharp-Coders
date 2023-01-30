using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.BatalhaNaval
{
    public class Embarcacoes
    {
        public int Linha;
        public int Coluna;
        public char LetraDaPeca;

        public Embarcacoes()
        {
           
        }
        
        public Embarcacoes(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
           
        }
    }
}
