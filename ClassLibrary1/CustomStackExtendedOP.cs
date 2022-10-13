using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(ICustomStack<IInterns> stack)
        {
            while (stack.Count() > 0)
            {

                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
