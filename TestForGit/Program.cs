using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //  this is a test of the unix operating system.
            IPProvider iprovider = new IPProvider();
            iprovider.SetValue(4);
        }
    }
}
