﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    class ModificGuns : InterDop
    {
        private TypesGunsEnum viewForm;

        public int TypesGuns { set => viewForm = (TypesGunsEnum)value; }

        public Color DopColor { private set; get; }

        public ModificGuns(int numType, Color dopColor)
        {
            TypesGuns = numType;
            DopColor = dopColor;
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
            g.FillRectangle(blackBrush, x + 22, y + 6, 13, 3);
            g.DrawLine(pen, x + 35, y + 6, x + 45, y + (75 / 10));
            g.DrawLine(pen, x + 35, y + 9, x + 45, y + (75 / 10));

            g.DrawLine(pen, x + 17, y + 45, x + 40, y + 45);
            g.DrawLine(pen, x + 17, y + 40, x + 40, y + 40);
            g.DrawLine(pen, x + 17, y + 45, x + 17, y + 40);
            g.DrawLine(pen, x + 40, y + 45, x + 50, y + 42);
            g.DrawLine(pen, x + 40, y + 40, x + 50, y + 42);
            g.FillRectangle(dopBrush, x + 17, y + 40, 23, 5);
            g.FillRectangle(blackBrush, x + 22, y + 41, 13, 3);
            g.DrawLine(pen, x + 35, y + 41, x + 45, y + (425 / 10));
            g.DrawLine(pen, x + 35, y + 44, x + 45, y + (425 / 10));
        }
    }
}