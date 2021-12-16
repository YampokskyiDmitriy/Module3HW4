namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var task1 = new Task1();
            var task2 = new Task2();
            task1.Run();
            task2.Run(2, 4);
        }
    }
}