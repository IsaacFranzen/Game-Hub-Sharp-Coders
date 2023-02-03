using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Peao : Pecas
    {
        public Peao(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.P;
        }

        public override bool confereMovimento(int linhaFinal, int colunaFinal)
        {

            switch(Cor)
            {
                case Cor.Black:
                    if (qtdDeMovimentos != 0)
                    {
                        if (linhaFinal == Linha - 1)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                            {
                                return true;
                            }
                            
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (linhaFinal == Linha - 1)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                            {
                                return true;
                            }
                           
                            else
                                return false;
                        }
                        else if (linhaFinal == Linha - 2)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio && Tabuleiro.tabuleiroX[Linha - 1, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                                return true;
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case Cor.White:
                    if (qtdDeMovimentos != 0)
                    {
                        if (linhaFinal == Linha + 1)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                            {
                                return true;
                            }
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (linhaFinal == Linha + 1)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                            {
                                return true;
                            }
                          
                            else
                                return false;
                        }
                        else if (linhaFinal == Linha + 2)
                        {
                            if (colunaFinal == Coluna && Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio && Tabuleiro.tabuleiroX[Linha + 1, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                                return true;
                            else
                                return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                default:
                    return false;
            }
           
        }
    }
}


