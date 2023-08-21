using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes;

internal class Sqr {

    public int Side1 { get; set; }

    public int Perimeter() {
        return Side1 * 4;
    }

    public int Area() {
        return Side1 * Side1;
    }

}
