using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TankMania
{
    class Arrow
    {
        public Tacka T;
        public bool active;

        public Arrow(Tacka t, bool active = true)
        {
            T = t;
            this.active = active;
        }

        public void Crtaj(Graphics G)
        {
            if (!active) { return; }
            T.Spoji(new Tacka(T.X - 5 * Tacka.Koef, T.Y + 5 * Tacka.Koef), G, Color.DarkGray, 2);
            T.Spoji(new Tacka(T.X + 5 * Tacka.Koef, T.Y + 5 * Tacka.Koef), G, Color.DarkGray, 2);
            T.Spoji(new Tacka(T.X, T.Y + 20 * Tacka.Koef), G, Color.DarkGray, 2);
        }
    }
}
