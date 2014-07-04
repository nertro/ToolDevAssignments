
namespace LevelEditor.Model
{
    class MapTileType
    {
        public string Name
        {
            get;
            set;
        }

        public int MovementCost
        {
            get;
            set;
        }

        public MapTileType(string name, int cost)
        {
            this.Name = name;
            this.MovementCost = cost;
        }
    }
}
