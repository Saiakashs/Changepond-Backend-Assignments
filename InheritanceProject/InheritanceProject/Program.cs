
namespace InheritanceProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person[] p = new Person[3];
            p[0] = new Student(Console.ReadLine());
            p[1] = new Student(Console.ReadLine());
            p[2] = new Teacher(Console.ReadLine());

            ((Student)p[0]).Study();
            ((Student)p[1]).Study();
            ((Teacher)p[2]).Explain();
        }
    }
}