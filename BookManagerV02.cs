using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerV02
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Init();
            app.Run();
            app.Exit();
        }
    }
}
