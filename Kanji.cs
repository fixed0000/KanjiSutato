using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiSutato
{
    internal class Kanji
    {
        public string onyomi = "Undefined";
        public string kunyomi = "Undefined";
        public string translation = "Undefined";
        public string kanjiItself = "Undefined";
        public int currentStreak;
        public int MaxStreak;
        public int Wrote;
        public int NumberInRow;
        public bool UsedToday;
    }
}
