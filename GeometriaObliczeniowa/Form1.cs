using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometriaObliczeniowa
{
    public partial class Form1 : Form
    {
        Graphics gb, gt;
        List<Point> Linie = new List<Point>();
        List<Point> Punkty = new List<Point>();
        List<Point> PunktyW = new List<Point>();
        Pen pen = new Pen(Color.Black);
        Point p1, pt, pt2, pozycja;
        string position = "";
        int i1, i2;
        static int pSize = 500;
        T_Orientacji testOrient;
        T_Przyn testPrzyn;
        T_PrzecProst testPrzecProst;
        #region skalowanie
        public static Point rysowanie(Point p)
        {
            p.X = p.X + pSize / 2;
            p.Y = -p.Y + pSize / 2;
            return p;
        }
        public static PointF rysowanieF(PointF p)
        {
            p.X = p.X + pSize / 2;
            p.Y = -p.Y + pSize / 2;
            return p;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            bialy.Image = new Bitmap(pSize, pSize);
            trans.Image = new Bitmap(pSize, pSize);
            gb = Graphics.FromImage(bialy.Image);
            gt = Graphics.FromImage(trans.Image);
            trans.Parent = bialy;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gt.DrawLine(pen, pSize / 2, 0, pSize / 2, pSize);
            gt.DrawLine(pen, 0, pSize / 2, pSize, pSize / 2);
        }

        private void trans_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (radioButtonLinie.Checked == true))
            {
                Linie.Add(new Point(e.X - pSize / 2, -e.Y + pSize / 2));
                position += "(" + (e.X - pSize / 2) + "," + (-e.Y + pSize / 2) + ")";
            }
            else if ((e.Button == MouseButtons.Left) && (radioButtonKropki.Checked == true))
            {
                Punkty.Add(new Point(e.X - pSize / 2, -e.Y + pSize / 2));
                gt.FillEllipse(Brushes.Black, e.X - 3, e.Y - 3, 5, 5);
                bialy.Refresh();
                position += "(" + (e.X - pSize / 2) + "," + (-e.Y + pSize / 2) + ")";
                listBoxPtk.Items.Add(position);
                position = "";
            }
            else if ((e.Button == MouseButtons.Left) && (radioButtonW.Checked == true))
            {
                PunktyW.Add(new Point(e.X - pSize / 2, -e.Y + pSize / 2));
                gt.FillEllipse(Brushes.Black, e.X - 3, e.Y - 3, 5, 5);
                bialy.Refresh();
                position += "(" + (e.X - pSize / 2) + "," + (-e.Y + pSize / 2) + ")";
                listBoxPtkW.Items.Add(position);
                position = "";
                if (PunktyW.Count() > 1)
                {
                    pt = rysowanie(PunktyW[PunktyW.Count - 2]);
                    gt.DrawLine(pen, pt, e.Location);
                    position = "";
                    bialy.Refresh();
                }
            }
            else if ((e.Button == MouseButtons.Right) && (radioButtonW.Checked == true))
            {
                if (PunktyW.Any())
                {
                    pt = rysowanie(PunktyW.First());
                    pt2 = rysowanie(PunktyW.Last());
                    gt.DrawLine(pen, pt, pt2);
                    trans.Refresh();
                }   
            }
        }

        private void trans_MouseMove(object sender, MouseEventArgs e)
        {
            pozycja = rysowanie(new Point(e.X - pSize, e.Y));
            textBoxWsp.Text = pozycja.ToString();
            if ((e.Button == MouseButtons.Left) && (radioButtonLinie.Checked == true))
            {
                pt = rysowanie(Linie.Last());
                gb.DrawLine(Pens.White, pt, p1);
                gb.DrawLine(pen, pt, e.Location);
                p1 = e.Location;
                bialy.Refresh();
            }
        }

        private void trans_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (radioButtonLinie.Checked == true))
            {
                pt = rysowanie(Linie.Last());
                gb.DrawLine(pen, pt, e.Location);
                gt.DrawLine(pen, pt, e.Location);
                Linie.Add(new Point(e.X - pSize / 2, -e.Y + pSize / 2));
                gb.Clear(Color.White);
                position += "(" + (e.X - pSize / 2) + "," + (-e.Y + pSize / 2) + ")";
                listBoxOdc1.Items.Add(position);
                listBoxOdc2.Items.Add(position);
                position = "";
                bialy.Refresh();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // TEST ORIENTACJI
            if (radioButtonTest1.Checked && Linie.Any() && Punkty.Any())
            {
                i1 = listBoxOdc1.SelectedIndex;
                if (i1 < 0)
                {
                    listBoxOdc1.SetSelected(0, true);
                    i1 = 0;
                }
                i2 = listBoxPtk.SelectedIndex;
                if (i2 < 0)
                {
                    listBoxPtk.SetSelected(0, true);
                    i2 = 0;
                }
                testOrient = new T_Orientacji(Punkty[i2], Linie[i1 * 2], Linie[i1 * 2 + 1]);
                wyniki.Text = testOrient.T(true);
            }
            // TEST PRZYNALEŻNOŚCI DO ODCINKA
            if (radioButtonTest2.Checked && Linie.Any() && Punkty.Any())
            {
                i1 = listBoxOdc1.SelectedIndex;
                if (i1 < 0)
                {
                    listBoxOdc1.SetSelected(0, true);
                    i1 = 0;
                }
                i2 = listBoxPtk.SelectedIndex;
                if (i2 < 0)
                {
                    listBoxPtk.SetSelected(0, true);
                    i2 = 0;
                }
                testPrzyn = new T_Przyn(Punkty[i2], Linie[i1 * 2], Linie[i1 * 2 + 1]);
                wyniki.Text = testPrzyn.T(true);
            }
            // TEST PRZECIĘCIA PROSTOKĄTNYCH OGRANICZEŃ
            if (radioButtonTest3.Checked && Linie.Any())
            {
                i1 = listBoxOdc1.SelectedIndex;
                if (i1 < 0)
                {
                    listBoxOdc1.SetSelected(0, true);
                    i1 = 0;
                }
                i2 = listBoxOdc2.SelectedIndex;
                if (i2 < 0)
                {
                    listBoxOdc2.SetSelected(0, true);
                    i2 = 0;
                }
                testPrzecProst = new T_PrzecProst(
                    Linie[i1 * 2], Linie[i1 * 2 + 1], Linie[i2 * 2], Linie[i2 * 2 + 1]);
                wyniki.Text = testPrzecProst.T(true);

            }
            // TEST PRZECIĘCIA ODCINKÓW
            if (radioButtonTest4.Checked && Linie.Any())
            {
                i1 = listBoxOdc1.SelectedIndex;
                if (i1 < 0)
                {
                    listBoxOdc1.SetSelected(0, true);
                    i1 = 0;
                }
                i2 = listBoxOdc2.SelectedIndex;
                if (i2 < 0)
                {
                    listBoxOdc2.SetSelected(0, true);
                    i2 = 0;
                }
                wyniki.Text = new T_PrzecOdc(
                    Linie[i1 * 2], Linie[i1 * 2 + 1], Linie[i2 * 2], Linie[i2 * 2 + 1]).T(true);

            }
        }

        #region dostep_do_list
        private void radioButtonTest1_CheckedChanged(object sender, EventArgs e)
        {
            listBoxOdc1.Enabled = true;
            listBoxOdc2.Enabled = false;
            listBoxPtk.Enabled = true;
            listBoxOdc2.ClearSelected();
        }

        private void radioButtonTest2_CheckedChanged(object sender, EventArgs e)
        {
            listBoxOdc1.Enabled = true;
            listBoxOdc2.Enabled = false;
            listBoxPtk.Enabled = true;
            listBoxOdc2.ClearSelected();
        }

        private void radioButtonTest3_CheckedChanged(object sender, EventArgs e)
        {
            listBoxOdc1.Enabled = true;
            listBoxOdc2.Enabled = true;
            listBoxPtk.Enabled = false;
            listBoxPtk.ClearSelected();
        }

        private void radioButtonTest4_CheckedChanged(object sender, EventArgs e)
        {
            listBoxOdc1.Enabled = true;
            listBoxOdc2.Enabled = true;
            listBoxPtk.Enabled = false;
            listBoxPtk.ClearSelected();
        }
        #endregion

        private void buttonPNOP_Click(object sender, EventArgs e)
        {   //  PNOP
            PNOP pnop = new PNOP(Punkty);
            Trojka tr;
            if (radioButtonPNOPf.Checked == true)
                tr = pnop.AlgoB(); // BRUTAL
            else
                tr = pnop.Algo(); // FAST
            Point ch1 = rysowanie(tr.p1);
            Point ch2 = rysowanie(tr.p2);
            wyniki.Text = tr.Wyswietl();
            gt.FillEllipse(Brushes.Green, ch1.X - 3, ch1.Y - 3, 5, 5);
            gt.FillEllipse(Brushes.Green, ch2.X - 3, ch2.Y - 3, 5, 5);
            gt.DrawLine(pen, ch1, ch2);
            trans.Refresh();
        }

        private void buttonOtoczka_Click(object sender, EventArgs e)
        {   //  OTOCZKA
            Otoczka x = new Otoczka(Punkty);
            x.OtoczkaQ();
            Point o1;
            Point o2;
            List<Point> Ot = x.Zwroc();
            wyniki.Text = Ot.Count().ToString();
            foreach (Point p in Ot)
                wyniki.Text += p.ToString();
            for (int i = 0; i < Ot.Count() - 1; i++)
            {
                pen.Color = Color.Red;
                o1 = rysowanie(Ot.ElementAt(i));
                o2 = rysowanie(Ot.ElementAt(i + 1));
                gt.DrawLine(pen, o1, o2);
                trans.Refresh();   
            }
            o1 = rysowanie(Ot.Last());
            o2 = rysowanie(Ot.First());
            gt.DrawLine(pen, o1, o2);
            pen.Color = Color.Black;
            trans.Refresh();
        }

        private void buttonPrzeciecia_Click(object sender, EventArgs e)
        {
            if (Linie.Any())
            {
                PPO ppo = new PPO(Linie);
                List<PointF> przec = new List<PointF>(ppo.TestM());
                PointF tP;
                foreach (PointF p in przec)
                {
                    tP = rysowanieF(p);
                    gt.FillEllipse(Brushes.Red, tP.X - 3, tP.Y - 3, 5, 5);
                    trans.Refresh();
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {   // RESET
            pen.Color = Color.Black;
            gt.Clear(Color.Transparent);
            gt.DrawLine(pen, pSize / 2, 0, pSize / 2, pSize);
            gt.DrawLine(pen, 0, pSize / 2, pSize, pSize / 2);
            bialy.Refresh();
            trans.Refresh();
            listBoxPtk.Items.Clear();
            listBoxPtkW.Items.Clear();
            listBoxOdc1.Items.Clear();
            listBoxOdc2.Items.Clear();
            wyniki.Clear();
            Linie.Clear();
            Punkty.Clear();
            PunktyW.Clear();
            radioButtonTest1.Checked = true;
            listBoxOdc2.Enabled = false;
        }

        private void buttonTriangulacja_Click(object sender, EventArgs e)
        {
            // TRIANGULACJA
            if (PunktyW.Any())
            {
                Triangulacja tr = new Triangulacja(PunktyW);
                List<Point> rys = tr.T();
                Point o1;
                Point o2;
                pen.Color = Color.Red;
                for (int i = 0; i < rys.Count() - 1; i = i + 2)
                {
                    o1 = rysowanie(rys[i]);
                    o2 = rysowanie(rys[i + 1]);
                    gt.DrawLine(pen, o1, o2);
                    trans.Refresh();
                }
            }
        }

        private void buttonWnetrze_Click(object sender, EventArgs e)
        {
            // WNETRZE
            if (radioButtonWnetrzeZ.Checked)
            {
                if (PunktyW.Any() && Punkty.Any())
                {
                    i1 = listBoxPtk.SelectedIndex;
                    if (i1 < 0)
                    {
                        listBoxPtk.SetSelected(0, true);
                        i1 = 0;
                    }
                    List<Point> tempPunktyW = new List<Point>(PunktyW);
                    tempPunktyW.Add(PunktyW[0]);
                    Wnetrze wn = new Wnetrze(tempPunktyW, Punkty[i1], pSize);
                    wyniki.Text = Punkty[i1].ToString() + System.DateTime.Now.ToLongTimeString() + " " + wn.T().ToString();
                }
            }
            else if (radioButtonWnetrzeW.Checked)
            {
                if (PunktyW.Any() && Punkty.Any()) 
                {
                    i1 = listBoxPtk.SelectedIndex;
                    if (i1 < 0)
                    {
                        listBoxPtk.SetSelected(0, true);
                        i1 = 0;
                    }
                    List<Point> tempPunktyW = new List<Point>(PunktyW);
                    tempPunktyW.Add(PunktyW[0]);
                    Wnetrze wn = new Wnetrze(tempPunktyW, Punkty[i1], pSize);
                    wyniki.Text = Punkty[i1].ToString() + System.DateTime.Now.ToLongTimeString() + " " + wn.Tw().ToString();
                }
            }
        }
    }
}