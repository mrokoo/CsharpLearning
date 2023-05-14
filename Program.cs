namespace 学习Csharp
{
    internal class Program
    {

        enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }
        static void Main()
        {

            var a = new Angle(1, 2, 3);
            object b = a;
            //a.Degrees = 123;
            Console.WriteLine(b.Equals(a));
        }
    }

    public class Person
    {
        public string Name { get; set; } = "bob";

        static public void SayHello(string name)
        {
            Console.WriteLine("Hello World!" + name);

        }

        static public void CheckName()
        {
            Console.WriteLine("OK");
        }
    }

    struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }


        public int Degrees { get; set; }
        public int Minutes { get; }
        public int Seconds { get; }


#pragma warning disable
        public Angle Move(int degrees, int minutes, int seconds)
        {
            return new Angle(degrees, minutes, seconds);
        }
    }

    readonly struct Date
    {
        public int A { get; }
        public bool IsNot { get; }

        //public string Motto { get; }
        public Date()
        {

        }
    }

    class Cat
    {
        public bool Gender;
        public string ID { get; set; }
        public int Age { get; set; }

        public Cat(string id)
        {
            ID = id;
        }
    }
}