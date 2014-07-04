
namespace LevelEditor.Model
{
    using System;

    class Map
    {
        public MapTile[,] Tiles
        {
            get;
            set;
        }

        public Map(int width, int height)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Width must be greater than zero.");
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("height", "Height must be greater than zero.");
            }

            this.Tiles = new MapTile[width, height];
        }

        public MapTile this[int x, int y]
        {
            get
            {
                return this.Tiles[x, y];
            }

            set
            {
                this.Tiles[x, y] = value;
            }
        }
    }
}
