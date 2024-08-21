using implementingOCP.Services.Abstraction;

namespace implementingOCP.Services
{
    public class ShapeDrawer
    {
        /*
            the ShapeDrawer class doesn't need to know the specific type of shape.

            The OCP can be achieved through techniques like polymorphism, inheritance, and interfaces, 
            which allow you to add new functionality by extending existing components rather than altering them.

            In this case I defined a abstract Shape class, which will be used by other class to implement it.

            So, we have 2 different kind of shapes, Circle and Rectangle. Both are inherit from Shape class and implement
            the Draw method.

            When the Draw method is called inside the DrawShape class, it will need to be instanciate the Circle or the Rectangle
            class so it can choose which one to use.

            Check the program class. 
        */
        public void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}