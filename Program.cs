namespace A_6_3_CallQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Call Queue");

            var callQueue = new CustomerQueue<string>();

           

            callQueue.Enqueue("James");
            callQueue.Enqueue("Mike");
            callQueue.Enqueue("Kate");
            callQueue.Enqueue("Bob");
            callQueue.Enqueue("Emma");

            callQueue.Display();

            var data = callQueue.Dequeue();

            callQueue.Display();


            var callQueue2 = new CustomerQueue<string>();

            try
            {
                callQueue2.Display();
                callQueue2.Dequeue();
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }


        }
    }
}
