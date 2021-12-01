using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    class AutomaticGuns : InterDop
    {
        private TypesGunsEnum viewForm;

        public int TypesGuns { set => viewForm = (TypesGunsEnum)value; }

        public Color DopColor { private set; get; }

        public AutomaticGuns(int numType)
        {
            TypesGuns = numType;
        }

        public void DrawDiffGuns(Graphics g, Color dopColor, float x, float y)
        {
            Brush dopBrush = new SolidBrush(dopColor);
            Brush blackBrush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, x + 17, y + 5, x + 40, y + 5);
            g.DrawLine(pen, x + 17, y + 10, x + 40, y + 10);
            g.DrawLine(pen, x + 17, y + 5, x + 17, y + 10);
            g.DrawLine(pen, x + 40, y + 5, x + 50, y + 7);
            g.DrawLine(pen, x + 40, y + 10, x + 50, y + 7);
            g.FillRectangle(dopBrush, x + 17, y + 5, 23, 5);
            g.DrawLine(pen, x + 30, y + 5, x + 30, y + 2);
            g.DrawLine(pen, x + 30, y + 2, x + 37, y + 5);
            g.DrawLine(pen, x + 30, y + 10, x + 30, y + 13);
            g.DrawLine(pen, x + 30, y + 13, x + 37, y + 10);
            g.FillRectangle(blackBrush, x + 17, y + 6, 8, 3);

            g.DrawLine(pen, x + 17, y + 45, x + 40, y + 45);
            g.DrawLine(pen, x + 17, y + 40, x + 40, y + 40);
            g.DrawLine(pen, x + 17, y + 45, x + 17, y + 40);
            g.DrawLine(pen, x + 40, y + 45, x + 50, y + 42);
            g.DrawLine(pen, x + 40, y + 40, x + 50, y + 42);
            g.FillRectangle(dopBrush, x + 17, y + 40, 23, 5);
            g.DrawLine(pen, x + 30, y + 40, x + 30, y + 37);
            g.DrawLine(pen, x + 30, y + 37, x + 37, y + 40);
            g.DrawLine(pen, x + 30, y + 45, x + 30, y + 48);
            g.DrawLine(pen, x + 30, y + 48, x + 37, y + 45);
            g.FillRectangle(blackBrush, x + 17, y + 41, 8, 3);

        }
    }
}
