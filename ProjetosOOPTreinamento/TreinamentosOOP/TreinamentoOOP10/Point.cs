using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoOOP10
{
    // Criando uma struct
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

    }
}
