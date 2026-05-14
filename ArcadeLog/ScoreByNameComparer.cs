using System.Collections.Generic;

namespace ArcadeLog
{
    public class ScoreByNameComparer : IComparer<Score>
    {
        public int Compare(Score x, Score y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}