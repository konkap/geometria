using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    public class PPO
    {
        List<Point> lista;
        List<PointF> wynik;
        public PPO(List<Point> lista)
        {
            this.lista = lista;
            this.wynik = new List<PointF>();
        }
        public List<PointF> TestM()
        {
            for (int i = 0; i < lista.Count(); i=i+2) 
            {
                for (int j = 0; j < lista.Count(); j=j+2)
                {
                    if (i != j && new T_PrzecOdc(lista[i], lista[i + 1], lista[j], lista[j + 1]).T()) 
                        wynik.Add(Test(lista[i], lista[i + 1], lista[j], lista[j + 1]));      
                }
            }
            return wynik; 
        }
        public PointF Test(Point p1, Point p2, Point p3, Point p4)
        {
            if (new T_PrzecOdc(p1, p2, p3, p4).T())
            {
                PointF pr = new PointF();
                pr.X = (
                    (p2.X - p1.X) * (p4.X * p3.Y - p4.Y * p3.X) -
                    (p4.X - p3.X) * (p2.X * p1.Y - p2.Y * p1.X)) /
                    ((p2.Y - p1.Y) * (p4.X - p3.X) - (p4.Y - p3.Y) * (p2.X - p1.X)
                    );
                pr.Y = (
                    (p4.Y - p3.Y) * (p2.X * p1.Y - p2.Y * p1.X) -
                    (p2.Y - p1.Y) * (p4.X * p3.Y - p4.Y * p3.X)) /
                    ((p4.Y - p3.Y) * (p2.X - p1.X) - (p2.Y - p1.Y) *
                    (p4.X - p3.X)
                    );
                return pr;
            }
            else
                return new PointF(); 
        }      
    }
}
