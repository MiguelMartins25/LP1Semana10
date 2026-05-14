using System;
using System.Collections.Generic;
using System.IO;

namespace ArcadeLog
{
    public class Program
    {
        // Argumento:
        // args[0]: Caminho para o ficheiro (formato "nome pontuação" por linha)
        private static void Main(string[] args)
        {
            // Lê o Ficheiro e Cria os Scores
            List<Score> scores = new List<Score>();
            // CÓDIGO AQUI

            // Ordena os Scores
            // CÓDIGO AQUI

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            // Escreve a lista no ficheiro ranking.txt
            // CÓDIGO AQUI

            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome e Escreve em alpha.txt
            // CÓDIGO AQUI

            // Este programa mostra o seguinte no ecrã (exemplo: scores.txt com "Kronos 7400", "Luna 3800", "Rex 520", "Phantom 6100"):
            //
            // Kronos [Gold]: 7400
            // Phantom [Silver]: 6100
            // Luna [Bronze]: 3800
            // Rex [Bronze]: 520
            // Ranking guardado em 'ranking.txt'.
        }
    }
}
