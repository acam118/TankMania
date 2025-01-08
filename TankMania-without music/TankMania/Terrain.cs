using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TankMania
{
    class Terrain
    {
        public Tacka[] a;
        int n;
        Random R = new Random();

        public Terrain(System.Windows.Forms.PictureBox p)
        {
            n = (int)(p.Width / Tacka.Koef) + 1;
            a = new Tacka[n];
            a[0] = new Tacka(0, R.Next((int)(p.Height / 2 / Tacka.Koef)) - p.Height / 4 / Tacka.Koef);
            for (int i = 1; i < n; i++)
            {
                int dy = R.Next(3);
                dy--;
                a[i] = new Tacka(i, a[i - 1].Y + dy);
            }
            a[n - 1] = new Tacka(p.Width / Tacka.Koef, a[n - 2].Y);
        }

        public int N
        {
            get { return n; }
        }

        public void Generate(Tank[] tank, int A, int B, int k = 50)
        {
            for (int i = 0; i < k; i++)
            {
                int f = R.Next(3) - 1;
                if (f == -1) Hole(R.Next(n), 50);
                else if (f == 1) Mountain(R.Next(n), 50);
            }
            for (int i = 0; i < 5; i++)
            {
                Smooth(0, n - 1);
            }
            int tenk1N = 50, tenk2N = n - 50;
            tank[0] = new Tank(new Tacka(a[tenk1N].X, a[tenk1N].Y + 2 * Tacka.Koef), tenk1N, A, B, Color.Red);
            tank[1] = new Tank(new Tacka(a[tenk2N].X, a[tenk2N].Y + 2 * Tacka.Koef), tenk2N, A, B, Color.Blue);
        }

        public void Mountain(int c, int r)
        {
            for (r = r; r > 0; r--)
            {
                for (int i = Math.Max(c - r - 1, 0); i < Math.Min(c + r + 1, n); i++)
                {
                    a[i] = new Tacka(a[i].X, a[i].Y + R.Next(2));
                }
            }
        }
        public void Hole(int c, int r)
        {
            for (r = r; r > 0; r--)
            {
                for (int i = Math.Max(c - r - 1, 0); i < Math.Min(c + r + 1, n); i++)
                {
                    a[i] = new Tacka(a[i].X, a[i].Y - R.Next(2));
                }
            }
        }

        public void Smooth(int l = 0, int d = -1)
        {
            if (d == -1) d += n;
            for (int i = l + 1; i < d; i++)
            {
                a[i] = new Tacka(a[i].X, (a[i - 1].Y + a[i + 1].Y) / 2);
            }
        }

        public void Explosion(int c, Missile m)
        {
            int r = m.Power;
            int sgnBuild = 1;
            if (m.Build) sgnBuild = -1;
            for (int i = Math.Max(c - r, 0); i < Math.Min(c + r, n); i++)
            {
                if (i != c && a[c].Rastojanje(a[i]) < r)
                    a[i] = new Tacka(a[i].X, a[c].Y - sgnBuild * (float)Math.Sqrt((float)(r * r - (c - i) * (c - i))));
            }
            a[c] = new Tacka(a[c].X, a[c].Y - sgnBuild * r);
            Smooth(Math.Max(c - r * 6 / 5, 0), Math.Min(c + r * 6 / 5, n - 1));
        }

        public void Crtaj(Graphics G)
        {
            for (int i = 1; i < n; i++)
            {
                a[i].Spoji(a[i - 1], G, Color.Black, 5); 
            }
        }

        public void ObojiZemlju(Graphics G, PictureBox P)
        {
            PointF[] points = new PointF[n + 2];
            for (int i = 0; i < n; i++)
            {
                points[i] = a[i].izDuG();
            }
            points[n] = new PointF(P.Width, P.Height);
            points[n + 1] = new PointF(0, P.Height);
            G.FillPolygon(Brushes.Green, points);
        }

        public bool IspodZemlje(Tacka K)
        {
            return K.Y < a[(int)K.X].Y;
        }
    }
}
