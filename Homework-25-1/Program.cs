namespace Homework_25_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> p1 = new Person<int>();
            p1.id = new int[] { 33, 15, 99, 10, 88 };
            p1.SortForNumbers();
            Console.WriteLine($"{p1.id[0]}, {p1.id[1]}, {p1.id[2]}, {p1.id[3]}, {p1.id[4]} ");  
            Person<int> p2 = new Person<int>();
            p2.id = new int[] { 1, 2, 3, 4, 5 };
            p2.SortInversion();
            Console.WriteLine($"{p2.id[0]}, {p2.id[1]}, {p2.id[2]}, {p2.id[3]}, {p2.id[4]} ");
            Person<string> p3 = new Person<string>();
            p3.id = new string[] { "001 agent", "002 agent", "003 agent", "004 agent", "005 agent" };
            p3.SortInversion();
            Console.WriteLine($"{p3.id[0]}, {p3.id[1]}, {p3.id[2]}, {p3.id[3]}, {p3.id[4]} ");
        }

    }
    class Person<T>
    {
        public T[] id { get; set; }

        public void SortForNumbers()
        {
            Array.Sort(id);
        }

        public void SortInversion()
        {
            Array.Reverse(id);
        }
    }



}