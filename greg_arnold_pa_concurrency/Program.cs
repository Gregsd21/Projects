/****************************************************************
 * Name: Greg Arnold
 * Date: 12/5/2023
 * Assignment: CIS317 Week 5 PA – Concurrency  - Multiple Producers
 * & Consumers
 * 
 * Main application class.
 */
public class AsyncPA
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 5 Concurrrency GP\n");

        BlockingBuffer sharedLocation = new BlockingBuffer(5);

        Task producer1 = new Producer(sharedLocation, "P1", 10, 16, 2).Run();
        Task producer2 = new Producer(sharedLocation, "P2", 25, 29, 3).Run();
        Task producer3 = new Producer(sharedLocation, "P3", 30, 39, 1).Run();
        Task consumer1 = new Consumer(sharedLocation, "C1", 1, 9, 3).Run();
        Task consumer2 = new Consumer(sharedLocation, "C2", 1, 13, 2).Run();

        await producer1;
        await producer2;
        await producer3;
        await consumer1;
        await consumer2;
    }
}
