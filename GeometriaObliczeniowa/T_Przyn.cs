using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class T_Przyn
    {
        Point p;
        Point lineS;
        Point lineE;

        public T_Przyn(Point p, Point lineS, Point lineE) 
        {
            this.p = p;
            this.lineS = lineS;
            this.lineE = lineE;
        }

        public bool T()
        {
            int det;
            det = ((lineE.X - p.X) * (lineS.Y - p.Y) - (lineE.Y - p.Y) * (lineS.X - p.X));
            if (det == 0 && p.X >= lineS.X && p.X <= lineE.X && p.Y >= lineS.Y && p.Y <= lineE.Y)
            { return true; }
            else { return false; }
        }
        public string T(bool t)
        {
            if(T())
                return "Punkt nalezy do odcinka";
            else
                return "Punkt nie nalezy do odcinka";
        }
    }
}
