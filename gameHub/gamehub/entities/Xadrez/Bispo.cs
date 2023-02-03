using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Bispo: Pecas
    {
        public Bispo(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.B;
        }

        public override bool confereMovimento(int colunaFinal, int linhaFinal)
        {
            int diferencaLinhas = linhaFinal - Linha;
            int diferencaColunas = colunaFinal - Coluna;
            int pecasNaPosicao = 0;

            if (linhaFinal == Linha && colunaFinal == Coluna)
            {
                return false;
            }

            int piecesInTheWay = 0;

            if (Math.Abs(diferencaLinhas) == Math.Abs(diferencaColunas))
            {
                if (Linha > linhaFinal && Coluna > colunaFinal)
                {
                    for (int i = Linha - 1, j = Coluna - 1; i > linhaFinal; i--, j--)
                    {
                        if (Tabuleiro.tabuleiroX[i, j].LetrasPecas != LetrasPecas.Vazio) pecasNaPosicao++;
                    }
                    if (pecasNaPosicao == 0)
                        return true;
                    else
                        return false;
                }
                else if (Linha > linhaFinal && Coluna < colunaFinal)
                {
                    for (int i = Linha - 1, j = Coluna + 1; i > linhaFinal; i--, j++)
                    {
                        if (Tabuleiro.tabuleiroX[i, j].LetrasPecas != LetrasPecas.Vazio) pecasNaPosicao++;
                    }
                    if (pecasNaPosicao == 0)
                        return true;
                    else
                        return false;
                }
                else if (Linha < linhaFinal && Coluna > colunaFinal)
                {
                    for (int i = Linha + 1, j = Coluna - 1; i < linhaFinal; i++, j--)
                    {
                        if (Tabuleiro.tabuleiroX[i, j].LetrasPecas != LetrasPecas.Vazio) pecasNaPosicao++;
                    }
                    if (pecasNaPosicao == 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    for (int i = Linha + 1, j = Coluna + 1; i < linhaFinal; i++, j++)
                    {
                        if (Tabuleiro.tabuleiroX[i, j].LetrasPecas != LetrasPecas.Vazio) pecasNaPosicao++;
                    }
                    if (pecasNaPosicao == 0)
                        return true;
                    else
                        return false;
                }
            }
            else return false;
        }
    }
}
