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
            if (args.Length == 0)
            {
                Console.WriteLine("Indique o ficheiro.");
                return;
            }

            string fileName = args[0];

            List<Score> scores = new List<Score>();

            foreach (string line in File.ReadAllLines(fileName))
            {
                string[] parts = line.Split(' ');
                string name = parts[0];
                int points = int.Parse(parts[1]);
                scores.Add(new Score(name, points));
            }

            // Ordena os Scores
            scores.Sort();

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            // Escreve a lista no ficheiro ranking.txt
            string[] medals = { "Gold", "Silver", "Bronze"};

            foreach (string medal in medals)
            {
                foreach (Score s in scores)
                {
                    if (s.Medal == medal)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            
            File.WriteAllLines("ranking.txt", scores.ConvertAll(s => s.ToString()));
            Console.WriteLine("Ranking guardado em 'ranking.txt'.");
            scores.Sort(new ScoreByNameComparer());

            // Ordena por Nome e Escreve em alpha.txt
            File.WriteAllLines("alpha.txt",scores.ConvertAll(s => s.ToString()));
            Console.WriteLine("Lista alfabética guardada em 'alpha.txt'.");

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