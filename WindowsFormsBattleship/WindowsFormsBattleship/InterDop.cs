using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsBattleship
{
    public interface InterDop
    {
        int TypesGuns { set; }
        void DrawDiffGuns(Graphics g, Color dopColor, float x, float y);
    }
}
