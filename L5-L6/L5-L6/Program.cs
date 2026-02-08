using L5_L6.shapes;
using L5_L6.storage;
using L5_L6.transport;

namespace L5_L6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var point = new Point();
            point.x = 20;
            point.y = 10;
            Console.WriteLine(point.DistanceFromZero());

            //Exercise 4
            Console.WriteLine(MathHelper.Add(20, 10));
            Console.WriteLine(MathHelper.Substract(20, 10));
            Console.WriteLine(MathHelper.Multiply(20, 10));

            //Exercise 5
            var fileStore = new FileStorage();
            var memoryStore = new MemoryStorage();
            fileStore.Save();
            memoryStore.Save();

            //Exercise 6
            var stepCounter = new StepCounter();
            stepCounter.AddSteps(100);
            stepCounter.AddSteps(-100);
            stepCounter.AddSteps(50);
            Console.WriteLine(stepCounter.GetSteps()); 
            stepCounter.Reset();
            Console.WriteLine(stepCounter.GetSteps());

            //Exercise 7
            var car = new Car();
            car.Speed = 100;
            var bicycle = new Bicycle();
            bicycle.Speed = 10;
            car.Move();
            bicycle.Move();

            //Exercise 8 
            var circle = new Circle();
            circle.Radius = 10;
            var rectangle = new Rectangle(); 
            rectangle.Width = 15;
            rectangle.Height = 15;

            Shape[] shapes = { circle, rectangle };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
        }
    }
}
