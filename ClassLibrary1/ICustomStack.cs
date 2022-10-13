using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  interface ICustomStack<T>
    {
        int Count();

        void Push(T str);

        T Pop();
    }
}
