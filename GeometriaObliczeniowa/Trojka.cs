using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class Trojka
    {
        public Point p1;
        public Point p2;
        public double odl;

        public Trojka(){}
        public Trojka(Point p1, Point p2, double odl)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.odl = odl;
        }
        public string Wyswietl()
        {
            return string.Format("Punkty: {0} i {1} ({2})",p1,p2,odl);
        }
    }
}
