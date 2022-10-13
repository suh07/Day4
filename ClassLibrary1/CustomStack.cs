using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStack<T>: ICustomStack<T> where T : IInterns
    {
        T[] arr;
        int pointer;

        public CustomStack()
        {
            arr = new T[10];
            pointer = 0;
        }

        public void Push(T str)=> arr[pointer++] = str;

        public T Pop()=> arr[--pointer];
        public int Count() => pointer;

       
    }
}
