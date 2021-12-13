using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    class DocksOccupiedPlaceException : Exception
    {
        public DocksOccupiedPlaceException() : base("Данное место занято")
        { }
    }
}
