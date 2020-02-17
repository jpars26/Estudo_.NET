using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6 {
    class Conversor {

        public static double IOF = 6.0;

        public static double Covert(double dollar, double cotacao) {
            double total = cotacao * dollar;
            return total + total * IOF / 100;
        }

    }
}
