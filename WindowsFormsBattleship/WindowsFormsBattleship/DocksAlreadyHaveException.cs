using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    public class DocksAlreadyHaveException : Exception
    {
        public DocksAlreadyHaveException() : base("В доках уже есть такой корабль")
            { }

    }
}
