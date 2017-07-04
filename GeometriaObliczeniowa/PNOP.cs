using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class PNOP
    {
        List<Point> Q = new List<Point>();
        Trojka T;
        public PNOP(List<Point> lista) 
        {
            this.Q = lista;
        }
        double Euk(Point p, Point q)
        {
            return Math.Sqrt(
                Math.Pow(Convert.ToDouble(p.X) - Convert.ToDouble(q.X), 2) + 
                Math.Pow(Convert.ToDouble(p.Y) - Convert.ToDouble(q.Y), 2) );    
        }
        public Trojka AlgoB()
        {
            List<Point> P = new List<Point>(this.Q);
            Trojka t = new Trojka();
            double odl = Double.MaxValue;
            for (int i = 0; i < P.Count(); i++) 
            {
                for (int j = 0; j < P.Count(); j++)
                {
                    if (i != j)
                    {
                        if (Euk(P.ElementAt(i), P.ElementAt(j)) < odl) 
                        {
                            odl = Euk(P.ElementAt(i), P.ElementAt(j));
                            t = new Trojka(P.ElementAt(i), P.ElementAt(j), odl);
                        }     
                    }
                }
            }
            return t;
        }
        public Trojka Algo()
        {
            List<Point> P = new List<Point>(this.Q);
            List<Point> X = new List<Point>(P).OrderBy(p => p.X).Cast<Point>().ToList();
            List<Point> Y = new List<Point>(P).OrderBy(p => p.Y).Cast<Point>().ToList();
            return Algo_Rek(P, X, Y);
        }
        Trojka Algo_Rek(List<Point> P, List<Point> X, List<Point> Y) 
        {
            double odl, odl2;
            if (P.Count() > 3)
            {
                int l = (int)Math.Ceiling((float)X.Count() / 2);
                List<Point> Pl = X.Take(l).ToList();
                List<Point> Pr = X.Skip(l).ToList();
                List<Point> Xl = new List<Point>(Pl).OrderBy(p => p.X).Cast<Point>().ToList();
                List<Point> Xr = new List<Point>(Pr).OrderBy(p => p.X).Cast<Point>().ToList();
                List<Point> Yl = new List<Point>(Pl).OrderBy(p => p.Y).Cast<Point>().ToList();
                List<Point> Yr = new List<Point>(Pr).OrderBy(p => p.Y).Cast<Point>().ToList();
                Trojka t1 = Algo_Rek(Pl, Xl, Yl);
                Trojka t2 = Algo_Rek(Pr, Xr, Yr);
                Trojka t3 = new Trojka();
                odl = Math.Min(t1.odl, t2.odl);
                odl2 = odl;
                List<Point> Yprim = new List<Point>();
                foreach (Point element in Y)
                {
                    if ((element.X <= l + odl) && (element.X >= l - odl))
                        Yprim.Add(element);
                }
                Yprim = Yprim.OrderBy(p => p.Y).Cast<Point>().ToList();
                for (int i = 0; i < Yprim.Count(); i++)
                {
                    for (int j = 0; j < Math.Min(7, Yprim.Count() - i); j++)
                    {
                        if (Euk(Yprim.ElementAt(i), Yprim.ElementAt(i + j)) < odl2)
                        {
                            odl2 = Euk(Yprim.ElementAt(i), Yprim.ElementAt(i + j));
                            t3 = new Trojka(Yprim.ElementAt(i), Yprim.ElementAt(i + j), odl2);
                        }
                    }
                }
                odl = Math.Min(odl, t3.odl);
                if (odl > odl2)
                    return t3;
                else
                {
                    if (t1.odl < t2.odl)
                        return t1;
                    else
                        return t2;
                }
            }
            else if (P.Count() == 1 )
                return T = new Trojka(P.ElementAt(0), P.ElementAt(0), 0);
            else
                return T = this.AlgoB();
        }
    }
}