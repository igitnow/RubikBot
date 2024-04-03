using System.Drawing;

namespace RubikBot.Model.Geometry
{
    public class Plane
    {
        private Vector _normal;
        private Vector _position;

        public double d { get; set; }

        public Plane()
        {
        }
        public Plane(Vector normal, Vector position)
        {
            _normal = normal;
            _position = position;
            Reset();
        }

        private void Reset()
        {
            if (_normal != null && _position != null) 
            { 
                d = _normal.X * _position.X + _normal.Y * _position.Y + _normal.Z * _position.Z;
            }
        }
        public Vector Normal
        {
            get
            { return _normal; 
            }
            set
            {
                _normal = value;
                Reset();

            }
        }
        public Vector Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
                Reset();

            }
        }


    }
}
