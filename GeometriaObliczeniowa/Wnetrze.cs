using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class Wnetrze
    {
        List<Point> lista;
        Point p;
        int size;
        public Wnetrze(List<Point> lista, Point p, int size)
        {
            this.lista = lista;
            this.p = p;
            this.size = size;
        }
        public bool T()
        {
            int l = 0;
            PointF f;
            Point temp, u, d;
            
            for (int i = 0; i < lista.Count() - 1; i++) 
            {
                u = lista[i];
                d = lista[i + 1];
                if (u.Y < d.Y)
                {
                    temp = u;
                    u = d;
                    d = temp;
                }
                if (p.Y < u.Y &&
                    p.Y > d.Y &&
                    new T_PrzecOdc(u, d, new Point(-size / 2, p.Y), p).T()
                    )
                {
                    f = punktPrzec(u, d, new Point(-size / 2, p.Y), p);
                    l++;
                }               
            }
            if(l % 2 == 1)
                return true;
            else
                return false;
        }
        public bool Tw()
        {
			List<Point> ptk = lista.OrderBy(z => z.Y).ToList();
			Point s = new Point((ptk[0].X + ptk.Last().X) / 2, (ptk[0].Y + ptk.Last().Y) / 2);
            return TwR(lista, s);
        }
        bool TwR(List<Point> punkty, Point s)
        {
            List<Point> tab1 = punkty.GetRange(0, punkty.Count() / 2 + 1);
            bool kat;
            if (new T_Orientacji(s, tab1[0], tab1.Last()).T() == 1)
                kat = new T_Orientacji(p, s, tab1[0]).T() == 1 && new T_Orientacji(p, s, tab1.Last()).T() == -1;
            else
                kat = new T_Orientacji(p, s, tab1[0]).T() == 1 || new T_Orientacji(p, s, tab1.Last()).T() == -1;
            if (kat)
            {
                if (tab1.Count() > 2)
                {
                    return TwR(tab1, s);
                }
                else
                    if (new T_Orientacji(p, tab1[0], tab1[1]).T() == 1)
                        return true;
                    else
                        return false;
            }
            else
            {
                List<Point> tab2 = punkty.GetRange(punkty.Count() / 2, punkty.Count() - punkty.Count() / 2);
                if (tab2.Count() > 2)
                    return TwR(tab2, s);
                else
                    if (new T_Orientacji(p, tab2[0], tab2[1]).T() == 1)
                        return true;
                    else
                        return false;
            }
        }
        PointF punktPrzec(Point p1, Point p2, Point p3, Point p4)
        {
            PointF pr = new PointF();
            pr.X = (
                (p2.X - p1.X) * (p4.X * p3.Y - p4.Y * p3.X) -
                (p4.X - p3.X) * (p2.X * p1.Y - p2.Y * p1.X)) /
                ((p2.Y - p1.Y) * (p4.X - p3.X) - (p4.Y - p3.Y) * (p2.X - p1.X));
            pr.Y = (
                (p4.Y - p3.Y) * (p2.X * p1.Y - p2.Y * p1.X) -
                (p2.Y - p1.Y) * (p4.X * p3.Y - p4.Y * p3.X)) /
                ((p4.Y - p3.Y) * (p2.X - p1.X) - (p2.Y - p1.Y) * (p4.X - p3.X));
            return pr;
        }
    }
}
