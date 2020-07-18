namespace Game
{
    public interface IMenu
    {
        string Description { get;  }
        void Execute(Game game, Utilities utilities);
    }
}