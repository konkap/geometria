using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GeometriaObliczeniowa
{
    class Triangulacja
    {
        List<Point> lista = new List<Point>();
        List<Point> trian = new List<Point>();
        public Triangulacja(List<Point> lista)
        {
            this.lista = lista;
        }
        public List<Point> T()
        {
            Tr(lista);
            return trian;
        }
        double Euk(Point p, Point q)
        {
            return Math.Sqrt(
                Math.Pow(Convert.ToDouble(p.X) - Convert.ToDouble(q.X), 2) +
                Math.Pow(Convert.ToDouble(p.Y) - Convert.ToDouble(q.Y), 2));
        }
        void Tr(List<Point> l)
        {
            if(l.Count() > 3)
            {
                int indexU;
                int indexD;
                List<Point> maxLewo = l.OrderBy(p => p.X).ToList();
                int indexV = l.FindIndex(z => z == maxLewo.First());
                bool pusty = true;
                List<int> wSrodku = new List<int>();
                indexU = indexV + 1;
                indexD = indexV - 1;
                if (indexV == l.Count - 1)
                    indexU = 0;
                if (indexV == 0)
                    indexD = l.Count - 1;
                for (int i = 0; i < l.Count() - 1; i++)
                {
                    if (
                        i != indexV &&
                        i != indexU &&
                        i != indexD &&
                        new T_Orientacji(l[i], l[indexD], l[indexU]).T() < 0 &&
                        new T_Orientacji(l[i], l[indexU], l[indexV]).T() < 0 &&
                        new T_Orientacji(l[i], l[indexV], l[indexD]).T() < 0
                        )
                    {
                        wSrodku.Add(i);
                        pusty = false;
                    }   
                }
                if (pusty)
                {
                    trian.Add(l[indexU]);
                    trian.Add(l[indexD]);
                    l.RemoveAt(indexV);
                    Tr(l);
                }
                else
                {
                    wSrodku = wSrodku.OrderBy(p => Euk(l[p], l[indexV])).ToList();
                    int indexVp = l.FindIndex(x => x == l[wSrodku[0]]);
                    List<Point> polowa1 = new List<Point>();
                    List<Point> polowa2 = new List<Point>();
                    List<Point> temp = new List<Point>();
                    int wiekszy = Math.Max(indexV, indexVp);
                    int mniejszy = Math.Min(indexV, indexVp);
                    polowa1 = l.GetRange(mniejszy, wiekszy - mniejszy + 1);
                    polowa2 = l.GetRange(wiekszy, l.Count() - wiekszy);
                    temp = l.GetRange(0, mniejszy + 1);
                    polowa2.AddRange(temp);
                    trian.Add(l[indexV]);
                    trian.Add(l[indexVp]);
                    Tr(polowa1);  
                    Tr(polowa2); 
                }
            }    
        }
    }
}
