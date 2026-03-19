using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public static class Logger
    {
        static public Action<string>? LogHandler; //в трикутних аргументи
        static public void Log(string message)
        {
            LogHandler?.Invoke(message);
            //нижче довший вираз
            //if (message != null)
                //LogHandler(message); //виклик делегату схожий на виклик функції тобто ім'я(аргумент)
        }

    }
}
