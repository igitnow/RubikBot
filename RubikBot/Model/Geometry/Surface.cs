using System.Drawing;

namespace RubikBot.Model.Geometry
{

    public class Surface:Plane
    {
        public Surface(Vector normal, string styleClass)
        {
            StyleClass = styleClass;
            Normal = normal;
        }
        public string StyleClass{ get; set; }
    }
}
