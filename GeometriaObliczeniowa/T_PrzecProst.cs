using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class T_PrzecProst
    {
        Point lineS;
        Point lineE;
        Point line2S;
        Point line2E;

        public T_PrzecProst(Point lineS, Point lineE, Point line2S, Point line2E) 
        {
            this.lineS = lineS;
            this.lineE = lineE;
            this.line2S = line2S;
            this.line2E = line2E;
        }

        public bool T()
        {
            Point r0 = new Point(Math.Min(lineS.X, lineE.X), Math.Min(lineS.Y, lineE.Y));
            Point r1 = new Point(Math.Max(lineS.X, lineE.X), Math.Max(lineS.Y, lineE.Y));
            Point r2 = new Point(Math.Min(line2S.X, line2E.X), Math.Min(line2S.Y, line2E.Y));
            Point r3 = new Point(Math.Max(line2S.X, line2E.X), Math.Max(line2S.Y, line2E.Y));
            if ((r1.X >= r2.X) && (r3.X >= r0.X) && (r1.Y >= r2.Y) && (r3.Y >= r0.Y))
                return true;
            else
                return false;
        }
        public string T(bool t)
        {
            if(T())
                return "Prostokątne ograniczenia przecinają się";
            else
                return "Prostokątne ograniczenia nie przecinają się";
        }
    }
}
