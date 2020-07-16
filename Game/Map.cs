using System.Collections.Generic;

namespace Game
{
    public class Map
    {
        public List<QuestPath> Paths;

        public Map LoadDefaultMap()
        {
            List<QuestPath> defaultPaths = new List<QuestPath>();
            defaultPaths.Add(new QuestPath("Path1", 300));
            defaultPaths.Add(new QuestPath("Path2", 350));
            defaultPaths.Add(new QuestPath("Path3", 400));

           return new Map()
           {
               Paths = defaultPaths
           };
        }

        public Map LoadMap()
        {
            //need to create a way to allow user to load a specific map file...maybe? The name of this map should be saved in the game file.
            return new Map();
        }
    }
}
