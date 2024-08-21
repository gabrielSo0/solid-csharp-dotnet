using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace violatingOCP
{
    public class ShapeDrawer
    {
        /*
            Suppose you have a class that draws different shapes. Initially, it supports only circles and rectangles.

            This class is not open for extension, beucase if you need to add another shape, or adding another rule to accomodate
            another shape, you will need to create another "if" statement.

            This is not even closed to modification, since we are modifying the class, the code inside the DrawShape to 
            accomodate a new shape, we are violating the Open Closed Principle
        */
        public void DrawShape(string shapeType)
        {
            if(shapeType == "Circle")
            {
                // Draw a circle
            }
            else if(shapeType == "Rectangle")
            {
                // Draw a rectangle
            }

        }
    }
}