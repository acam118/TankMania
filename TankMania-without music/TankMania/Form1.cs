using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankMania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            MP1.URL = "Ambient Sound.wav";
            MP1.settings.playCount = 9999;
            LoadMenu(true);
        }
        Terrain a;
        Missile[] b;
        int bn;
        Tank[] tank = new Tank[2];
        int[] moves = new int[2];
        int maxMoves;
        bool movesRefilable;
        int moveDistance = 8;
        int player = 0;
        Arrow Strelica;
        float sv = 2 * Tacka.Koef; //strelica velocity
        int label5info = 0;
        int label6info = 0;
        SoundPlayer soundPlayerTankFiring = new SoundPlayer("Tank firing.wav");
        SoundPlayer soundPlayerNormalExplosion = new SoundPlayer("Normal Explosion.wav");
        SoundPlayer soundPlayerVictorySoundEffect = new SoundPlayer("Victory Sound Effect.wav");
        bool vsComputer;
        string gamemode;
        bool limitedWeapons;
        bool winner;

        #region menu
        private void menuButton1_Click(object sender, EventArgs e)
        {
            LoadMenu(false);
            LoadGame();
        }
        public void LoadMenu(bool b)
        {
            label1.Visible = !b;
            label2.Visible = !b;
            listBox1.Visible = !b;
            listBox2.Visible = !b;
            label5.Visible = !b;
            label6.Visible = !b;
            pictureBox1.Visible = !b;
            button4.Visible = !b;
            numericUpDown1.Visible = !b;
            numericUpDown2.Visible = !b;
            label3.Visible = !b;
            label7.Visible = !b;
            button1.Visible = !b;
            button2.Visible = !b;
            button3.Visible = !b;
            menuButton5.Visible = !b;

            menuButton1.Visible = b;
            menuButton2.Visible = b;
            menuButton3.Visible = b;
            menuButton4.Visible = b;
            menuLabel1.Visible = b;
            menuPictureBox1.Visible = b;

            creditsVisible(false);
            settingsVisible(false);

            if (!b) MP1.Ctlcontrols.play();
            else MP1.Ctlcontrols.stop();
        }
        public void LoadGame()
        {

            Tacka.O = new PointF(0, pictureBox1.Height / 2);
            Tacka.Koef = 3;
            a = new Terrain(pictureBox1);
            a.Generate(tank, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            b = new Missile[100];
            bn = 0;
            Strelica = new Arrow(new Tacka(tank[0].t.X, tank[0].t.Y + 5 * Tacka.Koef));
            pictureBox1.Refresh();
            maxMoves = (int)settingsNumericUpDown1.Value;
            for(int i = 0; i <= 1; i++) moves[i] = maxMoves; 
            label3.Text = moves[0].ToString();
            movesRefilable = (settingsComboBox3.SelectedItem.ToString() == "Per turn");
            vsComputer = (settingsComboBox2.SelectedItem.ToString() == "1 player vs Computer");
            gamemode = settingsComboBox1.SelectedItem.ToString();
            limitedWeapons = (settingsComboBox1.SelectedItem.ToString() == "Limited Classic");
            LoadWeapons();
            timer1.Start();
        }

        private void menuButton2_Click(object sender, EventArgs e)
        {
            creditsVisible(false);
            settingsVisible(!settingsLabel1.Visible);
        }
        public void settingsVisible(bool b)
        {
            settingsComboBox1.Visible = b;
            settingsComboBox2.Visible = b;
            settingsComboBox3.Visible = b;
            settingsLabel1.Visible = b;
            settingsLabel2.Visible = b;
            settingsLabel3.Visible = b;
            settingsNumericUpDown1.Visible = b;
        }

        private void menuButton3_Click(object sender, EventArgs e)
        {
            settingsVisible(false);
            creditsVisible(!creditsLabel1.Visible);
        }
        public void creditsVisible(bool b)
        {
            creditsLabel1.Visible = b;
            creditsLabel2.Visible = b;
            creditsLabel3.Visible = b;
            creditsLabel4.Visible = b;
            creditsLabel5.Visible = b;
            creditsLabel0.Visible = b;
        }


        private void menuButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuButton5_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            a.ObojiZemlju(e.Graphics, pictureBox1);
            a.Crtaj(e.Graphics);
            for (int i = 0; i < bn; i++)
            {
                b[i].Crtaj(e.Graphics);
            }
            tank[0].Crtaj(e.Graphics, tank[0].a, 0);
            tank[1].Crtaj(e.Graphics, tank[1].a, 1);
            Strelica.Crtaj(e.Graphics);
        }

        #region gametime
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bn; i++)
            {
                b[i].Move();
                if (b[i].K.X < 0 || b[i].K.X >= a.N || b[i].K.Y < pictureBox1.Height / -2)
                {
                    b[i] = b[bn - 1];
                    i--;
                    bn--;
                }
                else if(a.IspodZemlje(b[i].K))
                {
                    a.Explosion((int)b[i].K.X, b[i]);
                    int SMALL_DAMAGE_ADD = 5; //game works better this way
                    int d1 = b[i].Power - (int)Math.Floor(tank[0].t.Rastojanje(b[i].K));
                    if(d1 > 0) { d1 = Math.Max(d1 + b[i].Damage_amp + SMALL_DAMAGE_ADD, 0); label5info += d1; label5.Text = "" + label5info; }
                    int d2 = b[i].Power - (int)Math.Floor(tank[1].t.Rastojanje(b[i].K));
                    if(d2 > 0) { d2 = Math.Max(d2 + b[i].Damage_amp + SMALL_DAMAGE_ADD, 0); label6info += d2; label6.Text = "" + label6info; }
                    b[i] = b[bn - 1];
                    i--;
                    bn--;
                    tank[0].NamestiY(a);
                    tank[1].NamestiY(a);
                    Strelica = new Arrow(new Tacka(tank[player].t.X, tank[player].t.Y + 5 * Tacka.Koef), false);
                    soundPlayerNormalExplosion.Play();
                }
            }
            if (bn == 0)
            {
                if (listBox2.Items.Count == 0)
                {
                    winner = false;
                    int score1 = int.Parse(label5.Text);
                    int score2 = int.Parse(label6.Text);
                    if (score1 < score2)
                    {
                        player = 0;
                        winner = true;
                    }
                    else if (score2 > score1)
                    {
                        player = 1;
                        winner = true;
                    }
                    if (winner)
                    {
                        label8.Location = new Point((int)tank[player].t.Transliraj(40, 60).izDuG().X, (int)tank[player].t.Transliraj(40, 60).izDuG().Y);
                        label8.Visible = true;
                        soundPlayerVictorySoundEffect.Play();
                        Refresh();
                        timer1.Stop();
                    }
                }
                if (player == 0 || !vsComputer) PlayerEnabled(true);
                else
                {
                    Refresh();
                    Thread.Sleep(500);
                    for (int i = moves[player]; i > 0; i--)
                    {
                        if (R.NextDouble() < 0.75) { button2_Click(sender, new EventArgs()); Refresh(); }
                        else break;
                    }
                    Thread.Sleep(500);
                    numericUpDown1.Value = R.Next(190, 260);
                    button11_Click(sender, new EventArgs());
                    if(listBox2.Items.Count > 0) listBox2.SelectedIndex = R.Next(listBox2.Items.Count);
                    Thread.Sleep(500);
                    button1_Click(sender, new EventArgs());
                }
            }
            Strelica.T = Strelica.T.Transliraj(0, sv);
            if (Strelica.T.Y < tank[player].t.Y + 5 * Tacka.Koef || Strelica.T.Y > tank[player].t.Y + 10 * Tacka.Koef) sv *= -1;
            Refresh();
        }

        bool aimControl = true;
        public void PlayerEnabled(bool b)
        {
            button1.Enabled = b;
            button2.Enabled = b;
            button3.Enabled = b;
            numericUpDown1.Enabled = b;
            numericUpDown2.Enabled = b;
            aimControl = b;
            Strelica.active = b;
        }
        #endregion

        #region Weapons
        string
            s10 = "Armor Piercing Shell - 10",
            s20 = "High Explosive Shell - 20",
            s30 = "Small Missile - 30",
            s40 = "Large Missile - 40",
            s50 = "MOAB - 50",
            s100 = "ICBM - 100",
            m2x25 = "Boom Boom - 2x25",
            m2x50 = "Snake Eyes - 2x50",
            m3x20 = "Triple Trouble - 3x20",
            m3x33 = "Devil's desire - 3x33",
            m5x20 = "HellFire - 5x20",
            m10x10 = "Shotgun - 10x10",
            m100x10 = "Literally Hailstorm - 100x10",
            bs50 = "Builder Granade - +50",
            bs100 = "Mountain Maker - +100",
            bm3x33 = "Castle Creator - +3x33",
            bm50_3x20_50 = "Fortress for you - +[50,3x33,50]",
            d80s20 = "Sniper Bullet - 20/100",
            d25s25 = "Angry Ginger - 25/50",
            d40m2x20 = "Hard Nuts - 2x 20/60",
            d30m3x30 = "Angry Piggies - 3x 30/60",
            s0 = "Probe - 0",
            m5x0 = "Angle Tester - 5x0",
            bdr50m50_30x20_50 = "Fortress for me - +[50,3x33,50]/0",
            tommygun = ""; //concept for firing not all bullets at the same time

        public void LoadWeapons()
        {
            ListBox[] listBoxes_1_and_2 = { listBox1, listBox2 };
            string[] allWeapons = {s10, s20, s30, s40, s50, s100, m2x25, m2x50, m3x20, m3x33, m5x20, m10x10, m100x10, bs50, bs100, bm3x33,
            bm50_3x20_50, d80s20, d25s25, d40m2x20, d30m3x30, s0, m5x0, bdr50m50_30x20_50};
            switch (gamemode)
            {
                case "Unlimited Weapons":
                    for (int i = 0; i <= 1; i++)
                    {
                        ListBox lb = listBoxes_1_and_2[i];
                        for (int j = 0; j < allWeapons.Length; j++)
                        {
                            lb.Items.Add(allWeapons[j]);
                        }/*
                        lb.Items.Add(s10); lb.Items.Add(s20); lb.Items.Add(s30); lb.Items.Add(s40); lb.Items.Add(s50); lb.Items.Add(s100);
                        lb.Items.Add(m2x25); lb.Items.Add(m2x50); lb.Items.Add(m3x20); lb.Items.Add(m3x33); lb.Items.Add(m5x20);
                        lb.Items.Add(m10x10); lb.Items.Add(m100x10);
                        lb.Items.Add(bs50); lb.Items.Add(bs100); lb.Items.Add(bm3x33); lb.Items.Add(bm50_3x20_50);
                        lb.Items.Add(d80s20); lb.Items.Add(d25s25); lb.Items.Add(d40m2x20); lb.Items.Add(d30m3x30);
                        lb.Items.Add(s0); lb.Items.Add(m5x0); lb.Items.Add(bdr50m50_30x20_50);*/
                    }
                    break;
                case "Limited Classic":
                    for (int i = 0; i < 1; i++)
                    {
                        listBox1.Items.Add(allWeapons[R.Next(allWeapons.Length)]);
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        listBox2.Items.Add(allWeapons[R.Next(allWeapons.Length)]);
                    }
                    break;
                case "Only Sniper":
                    for (int i = 0; i <= 1; i++)
                    {
                        ListBox lb = listBoxes_1_and_2[i];
                        lb.Items.Add(d80s20); lb.Items.Add(d25s25); lb.Items.Add(d40m2x20);
                        lb.Font = new Font("Microsoft Sans Serif", 12);
                    }
                    break;
                default:
                    break;
            }
        }
        public void FireShot(string sw)
        {
            switch (sw)
            {
                case string n when n == s10: FireShot(10); break;
                case string n when n == s20: FireShot(20); break;
                case string n when n == s30: FireShot(30); break;
                case string n when n == s40: FireShot(40); break;
                case string n when n == s50: FireShot(50); break;
                case string n when n == s100: FireShot(100); break;

                case string n when n == m2x25: for (float i = -2.5f; i <= 2.5; i += 5) { FireShot(25, i); } break;
                case string n when n == m2x50: for (float i = -2.5f; i <= 2.5; i += 5) { FireShot(50, i); } break;
                case string n when n == m3x20: for (int i = -5; i <= 5; i += 5) { FireShot(20, i); } break;
                case string n when n == m3x33: for (int i = -5; i <= 5; i += 5) { FireShot(33, i); } break;
                case string n when n == m5x20: for (int i = -10; i <= 10; i += 5) { FireShot(20, i); } break;
                case string n when n == m10x10: for (float i = -4.5f; i <= 4.5; i += 1) { FireShot(10, i); } break;
                case string n when n == m100x10: for (float i = -9.9f; i <= 9.9; i += 0.2f) { FireShot(10, i); } break;

                case string n when n == bs50: FireShot(50, 0, true); break;
                case string n when n == bs100: FireShot(100, 0, true); break;
                case string n when n == bm3x33: for (int i = -5; i <= 5; i += 5) { FireShot(33, i, true); } break;
                case string n when n == bm50_3x20_50: 
                    for (int i = -10; i <= 10; i += 20) { FireShot(50, i, true); } 
                    for (int i = -5; i <= 5; i += 5) { FireShot(20, i, true); } 
                    break;

                case string n when n == d80s20: FireShot(20, 0, false, 80); break;
                case string n when n == d25s25: FireShot(25, 0, false, 25); break;
                case string n when n == d40m2x20: for (float i = -2.5f; i <= 2.5; i += 5) { FireShot(20, i, false, 40); } break;
                case string n when n == d30m3x30: for (int i = -5; i <= 5; i += 5) { FireShot(30, i, false, 30); } break;

                case string n when n == s0: FireShot(0); break;
                case string n when n == m5x0: for (int i = -10; i <= 10; i += 5) { FireShot(0, i); } break;

                case string n when n == bdr50m50_30x20_50:
                    for (int i = -10; i <= 10; i += 20) { FireShot(50, i, true, -100); }
                    for (int i = -5; i <= 5; i += 5) { FireShot(20, i, true, -100); }
                    break;

                default: MessageBox.Show("No such weapons.", "Oops."); break;
            }
        }
        #endregion

        #region controls
        //firing from the end of the barrel(not great) 
        //b[bn++] = new Missile(new Tacka(tank[player].N + 5 * Tacka.Koef * (float)Math.Sin((int)numericUpDown1.Value * Math.PI / 180), a.a[tank[player].N].Y + -5 * Tacka.Koef * (float)Math.Cos((int)numericUpDown1.Value * Math.PI / 180)), new Tacka((float)Math.Sin((int)numericUpDown1.Value * Math.PI / 180) * (float)numericUpDown2.Value / 10, -1 * (float)Math.Cos((int)numericUpDown1.Value * Math.PI / 180) * (float)numericUpDown2.Value / 10), P, build);
        public void FireShot(int Power, float deltaangle = 0, bool build = false, int damage_amp = 0)
        {
            b[bn++] = new Missile(
                new Tacka(tank[player].N, 
                a.a[tank[player].N].Y + 2 * Tacka.Koef), 
                new Tacka((float)Math.Sin(((int)numericUpDown1.Value + deltaangle) * Math.PI / 180) * (float)numericUpDown2.Value / 10, 
                -1 * (float)Math.Cos(((int)numericUpDown1.Value + deltaangle) * Math.PI / 180) * (float)numericUpDown2.Value / 10), 
                Power, 
                build,
                damage_amp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            string sw = s10; //selected weapon
            if (player == 0) 
            { 
                if (listBox1.SelectedItem != null) 
                { 
                    sw = listBox1.SelectedItem.ToString(); 
                    if(limitedWeapons) listBox1.Items.Remove(listBox1.SelectedItem);
                } 
            }
            else 
            {
                if (listBox2.SelectedItem != null)
                {
                    sw = listBox2.SelectedItem.ToString();
                    if (limitedWeapons) listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            FireShot(sw);
            player += 1;
            player %= 2;
            numericUpDown1.Value = tank[player].a;
            numericUpDown2.Value = tank[player].b;
            PlayerEnabled(false);
            Strelica = new Arrow(new Tacka(tank[player].t.X, tank[player].t.Y + 5 * Tacka.Koef), false);
            if(movesRefilable) moves[player] = maxMoves;
            label3.Text = moves[player].ToString();
            soundPlayerTankFiring.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (moves[player] > 0)
            {
                if (tank[player].N > moveDistance) { tank[player].Pomeri(-moveDistance, a); moves[player]--; label3.Text = moves[player].ToString(); }
                Strelica = new Arrow(new Tacka(tank[player].t.X, tank[player].t.Y + moveDistance * Tacka.Koef));
                //pictureBox1.Refresh();
            }
            else MessageBox.Show("You have no moves left.","Oops.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (moves[player] > 0)
            {
                if (tank[player].N < a.N - 1 - moveDistance) { tank[player].Pomeri(moveDistance, a); moves[player]--; label3.Text = moves[player].ToString(); }
                Strelica = new Arrow(new Tacka(tank[player].t.X, tank[player].t.Y + moveDistance * Tacka.Koef));
                pictureBox1.Refresh();
            }
            else MessageBox.Show("You have no moves left.","Oops.");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tank[player].a = (int)numericUpDown1.Value;
            pictureBox1.Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tank[player].b = (int)numericUpDown2.Value;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!aimControl) return;
                float dx = e.X - tank[player].t.izDuG().X;
                float dy = tank[player].t.izDuG().Y - e.Y;
                double theta = Math.Atan2(dy,dx);
                int degree = (int)Math.Ceiling(theta * 180 / Math.PI) + 90;
                degree = (degree + 360) % 360;
                numericUpDown1.Value = degree;
            }
        }
        #endregion

        #region side buttons
        private void button4_Click(object sender, EventArgs e)
        {
            a = new Terrain(pictureBox1);
            a.Generate(tank, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Strelica = new Arrow(new Tacka(tank[player].t.X, tank[player].t.Y + 5 * Tacka.Koef));
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a.Mountain((int)numericUpDown1.Value, 50);
            pictureBox1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a.Hole((int)numericUpDown1.Value, 50);
            pictureBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a.Smooth();
            pictureBox1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*a.Explosion((int)numericUpDown1.Value, 10); //outdated
            pictureBox1.Refresh();*/
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b[bn++] = new Missile(new Tacka(0, a.a[0].Y + 5), new Tacka((float)Math.Sin((int)numericUpDown1.Value * Math.PI / 180) * (float)numericUpDown2.Value / 10, -1 * (float)Math.Cos((int)numericUpDown1.Value * Math.PI / 180) * (float)numericUpDown2.Value / 10), 10); //(float)numericUpDown2.Value / 10, 2
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = "10";
            label6.Text = "10";
        }
        #endregion

        #region computer plays
        public double calculateShot(int x0, int y0, int x1, int y1, float g, float alfa)
        {
            return Math.Sqrt((g * (x1 - x0) * (x1 - x0)) / (2 * Math.Cos(alfa) * Math.Cos(alfa) * (y0 - y1 + (x1 - x0) * Math.Tan(alfa))));
        }
        private void button11_Click(object sender, EventArgs e)
        {
            double something = 10 * calculateShot(tank[player].N, -(int)a.a[tank[player].N].Y, tank[(player + 1) % 2].N, -(int)a.a[tank[(player + 1) % 2].N].Y, Missile.g, (float)((int)numericUpDown1.Value * Math.PI / 180));
            if (!(something <= 100 && something >= 0)) something = 100;
            numericUpDown2.Value = (decimal)something;
        }
        Random R = new Random();/*
        public void slightlyMiss()
        {
            R.NextDouble();
        }*/
        #endregion
    }
}
