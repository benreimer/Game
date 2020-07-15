using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class QuestPath
    {
        public string Name;
        public int Length;

        public QuestPath(string name, int length)
        {
            Name = name;
            Length = length;
        }
    }
}
