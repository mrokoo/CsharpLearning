using UserC;

namespace 学习Csharp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("dsf");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            var p = new Person("bob22", 12);
            p.SayHello();
            var u1 = new User("bob", "112233@qq.com", "123344")
            {
                Coke = "Boke"
            };
            Console.WriteLine(u1.Name);
        }
    }

    class Person : IWalk
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public void SayHello()
        {
            Console.WriteLine(Name);
        }
    }

    class Student : Person
    {
        public string Gender { get; set; }

        public Student(string name, int id, string gender) : base(name, id)
        {
            Gender = gender;
        }
    }

    interface IWalk
    {
        void SayHello();
    }
}