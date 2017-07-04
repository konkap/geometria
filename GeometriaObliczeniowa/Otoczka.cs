using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class Otoczka
    {
        List<Point> Q = new List<Point>();
        List<Point> OtoczkaP = new List<Point>();
        public Otoczka(List<Point> lista)
        {
            this.Q = lista;
        }
        double C(Point p)
        {
            double r = Math.Sqrt(
                Math.Pow(Convert.ToDouble(p.X), 2) +
                Math.Pow(Convert.ToDouble(p.Y), 2)
                );
            return Math.Acos(p.X / r) * Math.Sign(p.Y);
        }
        public void OtoczkaQ()
        {
            List<Point> Q = new List<Point>(this.Q.OrderBy(p => p.X).ToList());
            Point A = Q.First();
            Point B = Q.Last();
            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();
            foreach (Point p in Q)
            {
                if (new T_Orientacji(p, A, B).T() == 1)
                    S1.Add(p);
                if (new T_Orientacji(p, A, B).T() == -1)
                    S2.Add(p);
            }
            OtoczkaP.Add(A);
            quickhull(A, B, S1);
            OtoczkaP.Add(B);
            quickhull(B, A, S2);
        }
        public List<Point> Zwroc()
        {
            return this.OtoczkaP.OrderByDescending(p => C(p)).ToList();
        }
        public List<Point> test(List<Point> L)
        {
            return L;
        }
        void quickhull(Point A, Point B, List<Point> S)
        {
            if (S.Count() == 0){}
            if (S.Count() == 1)
                OtoczkaP.Add(S.First());
            if (S.Count() > 1)
            {
                double maxDist = 0;
                int index = 0;
                for (int i = 0; i < S.Count(); i++)
                {
                    if (dist(A, B, S.ElementAt(i)) > maxDist)
                    {
                        maxDist = dist(A, B, S.ElementAt(i));
                        index = i;
                    }
                }
                Point C = S.ElementAt(index);
                OtoczkaP.Add(C);
                List<Point> S1 = new List<Point>();
                List<Point> S2 = new List<Point>();
                foreach (Point p in S)
                {
                    if (new T_Orientacji(p, A, C).T() == 1)
                        S1.Add(p);
                    if (new T_Orientacji(p, B, C).T() == -1)
                        S2.Add(p);
                }
                quickhull(A, C, S1);
                OtoczkaP.Add(C);
                quickhull(C, B, S2);
            }
        }
        double dist(Point A, Point B, Point C)
        {
            return Math.Abs((B.X - A.X) * (A.Y - C.Y) - (B.Y - A.Y) * (A.X - C.X));
        }
        Point Ntt(Stack<Point> St)
        {
            Point t = St.Pop();
            Point nnt = St.Peek();
            St.Push(t);
            return nnt;
        }
        public List<Point> Algo()
        {
            Point p0;
            Stack<Point> S = new Stack<Point>();
            List<Point> Q = this.Q.OrderBy(p => p.Y).ToList();
            p0 = Q.ElementAt(0);
            Q = Q.Skip(1).OrderByDescending(p => C(p)).ToList();
            for (int i = 0; i < Q.Count() - 1; i++)
            {
                if (C(Q.ElementAt(i)) == C(Q.ElementAt(i + 1)))
                {
                    Q.RemoveAt(i);
                    i--;
                }
            }
            S.Push(p0);
            S.Push(Q.ElementAt(1));
            S.Push(Q.ElementAt(2));
            for (int i = 3; i < Q.Count(); i++)
            {
                while (new T_Orientacji(Ntt(S), S.Peek(), Q.ElementAt(i)).T() == 1)
                    S.Pop();
                S.Push(Q.ElementAt(i));
            }
            return S.ToList();
        } 
    }
}