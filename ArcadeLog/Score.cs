using System.Collections.Generic;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        private int points;

        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        public string Name { get; }

        // Propriedade: Points (int), sempre entre 0 e 9999
        public int Points
        {
            get { return points; }

            set
            {
                if (value < 0)
                    points = 0;
                else if (value > 9999)
                    points = 9999;
                else
                    points = value;
            }
        }

        // Propriedade Só de Leitura: Medal (string)
        public string Medal
        {
            get
            {
                if (Points >= 7000)
                    return "Gold";
                else if (Points >= 4000)
                    return "Silver";
                else
                    return "Bronze";
            }
        }
        // Construtor: aceita nome e pontuação
        public Score(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Score other)
        {
            return other.Points.CompareTo(this.Points);
        }

        public override string ToString()
        {
            return $"{Name} [{Medal}] : {Points}";
        }
    }
}
