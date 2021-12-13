using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    /// Класс-ошибка "Если на парковке уже заняты все места"
    public class DocksOverflowException : Exception
    {
        public DocksOverflowException() : base("Свободных доков нет")
        { }

    }
}
