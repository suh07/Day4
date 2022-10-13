using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
             Jedi j = new Jedi("s",21);

            Console.WriteLine(j.getName());
            Console.ReadLine();

            CustomStack<String> stack = new CustomStack<String>();  //convert to string

            stack.Push("Jedi-X");
            stack.Pop();
            stack.Push("Jedi");

            stack.Push("SkillsLab");

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            */

            CustomStack<Jedi> customStack2 = new CustomStack<Jedi>();
            customStack2.Push(new Jedi("James", 1));
            customStack2.Push(new Jedi("Jane", 2));
            customStack2.Push(new Jedi("Tom", 3));

            CustomStackExtendedOP.DisplayAllInternsNameAndId(customStack2);
            Console.ReadLine();


        }
    }
}
