using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace classe_frazione_cahino
{
    class Frazione
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public Frazione(int den, int num)
        {
            a = num;
            b = den;
        }
            public Frazione Somma(Frazione sum)
            {
            int somma= (sum.a/sum.b)+(sum.b/sum.c);
            return sum;
            }
        

    }
}
