using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometriaObliczeniowa
{
    class T_PrzecOdc
    {
        Point lineS;
        Point lineE;
        Point line2S;
        Point line2E;

        public T_PrzecOdc(Point lineS, Point lineE, Point line2S, Point line2E) 
        {
            this.lineS = lineS;
            this.lineE = lineE;
            this.line2S = line2S;
            this.line2E = line2E;
        }
        public bool T()
        {
            Point o1 = lineS;
            Point o2 = lineE;
            Point o3 = line2S;
            Point o4 = line2E;
            bool temp = new T_PrzecProst(o1, o2, o3, o4).T();
            if (temp)
            {
                long det0 = (o3.X - o1.X) * (o4.Y - o1.Y) - (o3.Y - o1.Y) * (o4.X - o1.X);
                long det1 = (o3.X - o2.X) * (o4.Y - o2.Y) - (o3.Y - o2.Y) * (o4.X - o2.X);
                long det2 = (o1.X - o3.X) * (o2.Y - o3.Y) - (o1.Y - o3.Y) * (o2.X - o3.X);
                long det3 = (o1.X - o4.X) * (o2.Y - o4.Y) - (o1.Y - o4.Y) * (o2.X - o4.X);
                if ((det0 * det1) <= 0 && (det2 * det3) <= 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public string T(bool t)
        {
            bool temp = new T_PrzecOdc(lineS, lineE, line2S, line2E).T();
            if (temp)
                return "Odcinki przecinaja sie";
            else
                return "Odcinki nie przecinaja sie";
        }
    }
}
