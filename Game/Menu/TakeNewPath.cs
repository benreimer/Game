using System;

namespace Game.Menu
{
    class TakeNewPath: IMenu
    {
        public string Description => "Take the new path";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("take new path...");
            //game.CurrentPath = (QuestPath)game.CurrentPath.PathList[0];
            AssignNewPathToCurrentPath(game);
        }

        private void AssignNewPathToCurrentPath(Game game)
        {
            QuestPath parentPath = game.CurrentPath;
         //   QuestPath newPath = new QuestPath(game.CurrentPath.PathList[0].Name,game.CurrentPath.PathList[0].Length);
            
            //add the details of the parent path (the path I just left) as a path off of this my now current path
         //   newPath.PathList.Add(new AdventurePath { Name = "ParentPath", Length = parentPath.Length, Location = 0});
         //todo get back to this....I would like to take the current items in the list and order them based on location
            //   List<AdventurePath> updatedList = newPath.PathList.OrderBy(p => p.Location);
         //   newPath.PathList.Clear();
         //   newPath.PathList = updatedList;
          //  game.CurrentPath = newPath;
         //   game.CurrentPath.Location = 0; // game.Character.CurrentLocation;

            //I can't set this to 0 because it would immediately flag that I was on a new path (the previous one) so I am going to set it to 1 for now
           // game.Character.CurrentLocation = 0;

          //  Console.WriteLine($"Cuurent path is now {game.CurrentPath.Name} with a length of {game.CurrentPath.Length}.  It has {game.CurrentPath.PathList.Count} branching paths.");
        }
    }
}
