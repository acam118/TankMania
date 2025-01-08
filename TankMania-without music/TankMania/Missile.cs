using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TankMania
{
    class Missile
    {
        Tacka T, V;
        int power;
        bool build;
        int damage_apm;
        Tacka[] trail = new Tacka[4];
        static public float g = (float)-0.15;

        public Missile(Tacka T, Tacka V, int power, bool build = false, int damage_apm = 0)
        {
            this.T = T;
            this.V = V;
            this.power = power;
            this.build = build;
            this.damage_apm = damage_apm;
        }

        public Tacka K
        {
            get { return T; }
        }
        public int Power
        {
            get { return power; }
        }
        public bool Build
        {
            get { return build; }
        }
        public int Damage_amp
        {
            get { return damage_apm; }
        }

        public void Move()
        {
            for (int i = trail.Length - 1; i > 0; i--)
            {
                trail[i] = trail[i - 1];
                if(trail[i] != null) trail[i].Boja = Color.FromArgb(trail[0].Boja.A / 2, trail[i].Boja.R, trail[i].Boja.G, trail[i].Boja.B);
            }
            trail[0] = T; 
            trail[0].Boja = Color.FromArgb(trail[0].Boja.A / 2, trail[0].Boja.R, trail[0].Boja.G, trail[0].Boja.B);
            T = new Tacka(T.X + V.X, T.Y + V.Y);
            V = new Tacka(V.X, (float)(V.Y + g));
        }

        public void Crtaj(Graphics G)
        {
            T.Crtaj(G);
            for (int i = 0; i < trail.Length; i++)
            {
                if(trail[i] != null)trail[i].Crtaj(G);
            }
        }
    }
}
