namespace AdvancedPartal1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the partial class
            Myclass obj = new Myclass();

            // Call methods from both parts of the partial class
            obj.Method1();
            obj.Method2();
        }
    }
}
