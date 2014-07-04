
namespace LevelEditor.Model
{
    class MapTile
    {
        public Vector2I Position
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public MapTile(int x, int y, string type)
            : this(new Vector2I(x, y), type)
        {
        }

        public MapTile(Vector2I position, string type)
        {
            this.Position = position;
            this.Type = type;
        }
    }
}
