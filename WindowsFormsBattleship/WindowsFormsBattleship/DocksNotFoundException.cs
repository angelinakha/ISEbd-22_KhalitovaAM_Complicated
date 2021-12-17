using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
    /// Класс-ошибка "Если не найден корабль по определенному месту"
    public class DocksNotFoundException : Exception
    {
        public DocksNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}
