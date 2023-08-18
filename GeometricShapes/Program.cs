﻿
using GeometricShapes;

var rect1 = new Rect() {
    Side1 = 3, Side2 = 5
};

Console.WriteLine($"Perimeter is {rect1.Perimeter()}, Area is {rect1.Area()}");

var quad1 = new Quad() {
    Side1 = 3, Side2 = 4, Side3 = 5, Side4 = 6
};

var perimeter = quad1.Perimeter();

Console.WriteLine($"Quad1 perimeter is {perimeter}");