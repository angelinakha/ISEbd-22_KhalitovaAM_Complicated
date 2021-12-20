using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    public class ShipComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Battleship && y is Battleship)
            {
                return ComparerBattleship((Battleship)x, (Battleship)y);
            }
            if (x is Ship && y is Ship)
            {
                return ComparerShip((Ship)x, (Ship)y);
            }
            if (x is Ship && y is Battleship)
            {
                return 1;
            }
            if (x is Battleship && y is Ship)
            {
                return -1;
            }
            return 0;
        }
        private int ComparerShip(Ship x, Ship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerBattleship(Battleship x, Battleship y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Rocket != y.Rocket)
            {
                return x.Rocket.CompareTo(y.Rocket);
            }
            if (x.Cannon != y.Cannon)
            {
                return x.Cannon.CompareTo(y.Cannon);
            }
            if (x.InterDop != y.InterDop)
            {
                return x.InterDop.CompareTo(y.InterDop);
            }
            if (x.Guns.ToString() != y.Guns.ToString())
            {
                return x.Guns.ToString().CompareTo(y.Guns.ToString());
            }
            return 0;
        }

    }
}
