using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TankMania
{
    class Tacka
    {
        static PointF _O;
        static float koef = 1;
        static float vel = 5;// velicina tacke

        float x, y;
        //System.Drawing.Color boja;
        Color boja;
        #region konstruktori
        public Tacka(float x = 0, float y = 0)
        {
            this.x = x; this.y = y; boja = Color.Black;
        }
        public Tacka(float x, float y, Color boja)
        {
            this.x = x; this.y = y; this.boja = boja;
        }
        public Tacka(Tacka A)
        {
            x = A.x;
            y = A.y;
            boja = A.boja;
        }
        public Tacka(string s)//(x;y)
        {
            try
            {
                s = s.Substring(1, s.Length - 2);

                string[] r = s.Split(';');
                x = float.Parse(r[0]);
                y = float.Parse(r[1]);
                boja = Color.Black;
            }
            catch (Exception e) { throw new Exception("pogresa format tacke"); }
            /*
        int p = s.IndexOf(';');

        x = float.Parse(s.Substring(0, p)); // od pozicije 0 p znakova
        y = float.Parse(s.Substring(p + 1));  // od pozicije p+1 do kraja stringa
             * */
        }
        # endregion
        # region svostva
        static public PointF O
        {
            get { return _O; }
            set { _O = value; }
        }

        static public float Koef
        {
            get { return koef; }
            set
            {
                if (koef <= 0) throw new Exception("Greska");
                koef = value;
            }
        }
        public float X
        {
            get { return x; }
        }
        public float Y
        {
            get { return y; }
        }
        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }
        #endregion

        #region crtanje i prevodjenje tacke

        public PointF izDuG() //A.izDuG()
        {
            return new PointF(_O.X + x * koef, _O.Y - y * koef);
        }
        public static Tacka izGuD(PointF T)   //  A=Tacka.izGuD(T) 
        {
            return new Tacka((T.X - _O.X) / koef, (_O.Y - T.Y) / koef);
        }
        public void Crtaj(Graphics g)
        {
            PointF P = this.izDuG();
            g.FillEllipse(new SolidBrush(boja), P.X - vel, P.Y - vel, 2 * vel, 2 * vel);
        }
        // spajanje tacke sa tackom B u grafici g bojom b debljinom d
        public void Spoji(Tacka B, Graphics g, Color b, float d = 1)
        {
            g.DrawLine(new Pen(b, d), this.izDuG(), B.izDuG());
        }
        #endregion

        #region  metode rastojanje, info, kvadrant

        //A.Rastojanje(B)
        public float Rastojanje(Tacka B)
        {
            return (float)Math.Sqrt((this.x - B.x) * (this.x - B.x) + (y - B.y) * (y - B.y));
        }

        public string Info()
        {
            return "(" + x.ToString("0.00") + ";" + y.ToString("0.00") + ")";
        }
        public int kvadrant() // 0 koordinatni pocetak, -1 x osa, -2 y osa
        {
            if (x == 0 && y == 0)
                return 0;
            if (x == 0)
                return -1;
            if (y == 0)
                return -2;
            if (x > 0)
                if (y > 0)
                    return 1;
                else
                    return 4;
            if (y > 0)
                return 2;
            else
                return 3;
        }

        #endregion
        #region transformacije
        public Tacka simX()
        {
            return new Tacka(x, -y, boja);
        }
        public Tacka simY()
        {
            return new Tacka(-x, y, boja);
        }
        public Tacka cSim(Tacka C = null)
        {
            if (C == null) C = new Tacka();
            return new Tacka(2 * C.x - this.x, 2 * C.y - this.y, boja);
        }

        // centralna simetrija tacke ako je centar simetrije tacka M
        // M je sredina duzi A A1
        //M.x=(this.X+x1)/2   x1=2*M.x-this.x  slicno za y1
        public Tacka CentralnaSimetrija(Tacka M = null)
        {
            if (M == null) M = new Tacka(); // ako ne navedemo tacku simetrija je u odnosu na (0,0)
            return new Tacka(2 * M.x - this.x, 2 * M.y - this.y);
        }

        public Tacka Transliraj(float dx, float dy)
        {
            return new Tacka(x + dx, y + dy);
        }
        public void Transliraj2(float dx, float dy)
        {
            x += dx; y += dy;
        }

        public Tacka Rotiraj(double ugao)
        {
            float x1, y1;
            x1 = (float)(x * Math.Cos(ugao) - y * Math.Sin(ugao));
            y1 = (float)(x * Math.Sin(ugao) + y * Math.Cos(ugao));
            return new Tacka(x1, y1, boja);
        }
        public Tacka Rotiraj(Tacka M, double ugao)
        {
            return this.Transliraj(-M.x, -M.y).Rotiraj(ugao).Transliraj(M.x, M.y);
            /**
            float x1 = x - M.x, y1 = y - M.y;
            float x2 = (float)(x1 * Math.Cos(ugao) - y1 * Math.Sin(ugao));
            float y2 = (float)(x1 * Math.Sin(ugao) + y1 * Math.Cos(ugao));
            x2 += M.x; y2 += M.y;
            return new Tacka(x2, y2, boja);
             * */
        }
        #endregion
    }
}
