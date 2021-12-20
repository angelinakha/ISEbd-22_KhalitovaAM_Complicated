using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsBattleship
{
    public class ClassDop
    {
        private DopEnum guns;
        public int Guns { set => guns = (DopEnum)value; }

        public void DrawGuns(Graphics g, Pen dopColor, Brush dopBr, float _startPosX, float _startPosY)
        {
            switch (guns)
            {
                case DopEnum.two:
                    Draw2(g, dopColor, dopBr, _startPosX, _startPosY);
                    break;

                case DopEnum.four:
                    Draw4(g, dopColor, dopBr, _startPosX, _startPosY);
                    break;

                case DopEnum.six:
                    Draw6(g, dopColor, dopBr, _startPosX, _startPosY);
                    break;
            }
        }

        public ClassDop(int g_count)
        {
            Guns = g_count;
        }

        public void SetNumCan(string num)
		{
            Guns = Convert.ToInt32(num);
		}

        public void Draw2(Graphics g, Pen dopСolor, Brush dopBr, float x, float y)
        {
            g.DrawEllipse(dopСolor, x + (2 * 70 + 35) / 6, y - 5, 15, 5);
            g.FillEllipse(dopBr, x + (2 * 70 + 35) / 6, y - 5, 15, 5);
            g.DrawEllipse(dopСolor, x + (2 * 70 + 35) / 6, y + 50, 15, 5);
            g.FillEllipse(dopBr, x + (2 * 70 + 35) / 6, y + 50, 15, 5);
            g.FillRectangle(dopBr, x + 33, y - 15, 7, 15);
            g.FillRectangle(dopBr, x + 33, y + 50, 7, 15);
        }

        public void Draw4(Graphics g, Pen dopСolor, Brush dopBr, float x, float y)
        {
            Draw2(g, dopСolor, dopBr, x, y);
            g.DrawEllipse(dopСolor, x + 4 * 70 / 6, y - 5, 15, 5);
            g.FillEllipse(dopBr, x + 4 * 70 / 6, y - 5, 15, 5);
            g.DrawEllipse(dopСolor, x + 4 * 70 / 6, y + 50, 15, 5);
            g.FillEllipse(dopBr, x + 4 * 70 / 6, y + 50, 15, 5);
            g.FillRectangle(dopBr, x + 50, y - 15, 7, 15);
            g.FillRectangle(dopBr, x + 50, y + 50, 7, 15);
        }

        public void Draw6(Graphics g, Pen dopСolor, Brush dopBr, float x, float y)
        {
            Draw4(g, dopСolor, dopBr, x, y);
            g.DrawEllipse(dopСolor, x + 70 / 6, y - 5, 15, 5);
            g.DrawEllipse(dopСolor, x + 70 / 6, y + 50, 15, 5);
            g.FillEllipse(dopBr, x + 70 / 6, y - 5, 15, 5);
            g.FillEllipse(dopBr, x + 70 / 6, y + 50, 15, 5);
            g.FillRectangle(dopBr, x + 15, y - 15, 7, 15);
            g.FillRectangle(dopBr, x + 15, y + 50, 7, 15);
        }
        public override string ToString()
        {
            return
           $"{(int)guns}";
        }
    }
}
