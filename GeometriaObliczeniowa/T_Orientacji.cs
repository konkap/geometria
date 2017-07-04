using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class T_Orientacji
    {
        Point p;
        Point lineS;
        Point lineE;
        public T_Orientacji(Point p, Point lineS, Point lineE) 
        {
            this.p = p;
            this.lineS = lineS;
            this.lineE = lineE;
        }
        public int T()
        {
            int det;
            det = ((lineS.X - p.X) * (lineE.Y - p.Y) - (lineS.Y - p.Y) * (lineE.X - p.X));
            if (det < 0) { return 1; }
            else if (det > 0) { return -1; }
            else { return 0; }
        }
        public string T(bool t)
        {
            if(T() > 0)
                return "Punkt jest po prawej odcinka"; 
            else if(T() < 0)
                return "Punkt jest po lewej odcinka";
            else
                return "Punkty są współliniowe";            
        }
        
    }
}
