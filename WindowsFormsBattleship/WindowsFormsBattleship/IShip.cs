using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
	interface IShip
	{
		void SetPosition(int x, int y, int width, int height);
		void MoveTransport(Direction direction);
		void DrawShip(Graphics g);

	}
}
