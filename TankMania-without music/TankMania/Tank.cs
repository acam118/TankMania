using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Schema;

namespace TankMania
{
    class Tank
    {
        Tacka T;
        int n;
        int HP;
        public int a, b;
        Color boja;

        public Tank(Tacka t, int N, int A, int B, Color Boja)
        {
            T = new Tacka(t);
            n = N;
            HP = 60;
            a = A;
            b = B;
            boja = Boja;
        }

        public int N
        {
            get { return n; }
        }
        public Tacka t
        {
            get { return T; }
        }

        public void Pomeri(int x, Terrain a)
        {
            n += x;
            NamestiY(a);
        }

        public void NamestiY(Terrain a)
        {
            T = new Tacka(a.a[n].X, a.a[n].Y + 2 * Tacka.Koef);
        }

        public void Crtaj(Graphics G, int x, int color)
        {
            switch (color){
                case 0: G.DrawImage(Image.FromFile("Red tank fin.png"), T.izDuG().X - 8 * Tacka.Koef, T.izDuG().Y, 32 * Tacka.Koef, 32 * Tacka.Koef);
                    break;
                case 1:
                    G.DrawImage(Image.FromFile("Blue tank fin.png"), T.izDuG().X - 8 * Tacka.Koef, T.izDuG().Y, 32 * Tacka.Koef, 32 * Tacka.Koef);
                    break;
                default: G.DrawImage(Image.FromFile("Red tank fin.png"), T.izDuG().X - 8 * Tacka.Koef, T.izDuG().Y, 32 * Tacka.Koef, 32 * Tacka.Koef);
                    break;
            }
            //G.FillRectangle(new SolidBrush(boja), T.izDuG().X - 6 * Tacka.Koef, T.izDuG().Y, 12 * Tacka.Koef, 8 * Tacka.Koef); //old tank
            T.Spoji(new Tacka(T.X + 5 * Tacka.Koef * (float)Math.Sin(x * Math.PI / 180), T.Y + -5 * Tacka.Koef * (float)Math.Cos(x * Math.PI / 180)), G, Color.Gray, 3);
        }
    }
}
