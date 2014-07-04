
namespace LevelEditor.Model
{
    class Map
    {
        public MapTile[,] Tiles
        {
            get;
            set;
        }

        public Map(int x, int y)
        {
            Tiles = new MapTile[x, y];
        }
    }
}
