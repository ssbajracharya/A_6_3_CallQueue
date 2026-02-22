namespace A_6_3_CallQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Call Queue");

            var callQueue = new CustomerQueue<string>();

            callQueue.Enqueue("Alice");
            callQueue.Enqueue("Bob");
            callQueue.Enqueue("Carol");
            callQueue.Enqueue("David");
            callQueue.Enqueue("Emma");

            callQueue.Display();

        }
    }
}
