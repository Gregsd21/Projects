/******************************************************************************************
* Name: Greg Arnold
* Date: 12/5/2023
*Assignment: CIS317 Week 5 GP - Concurrency
*
*Main application class.
*/

public class AsyncDemo
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\nGreg Arnold, Week 5 Concurrency GP\n");

        BlockingBuffer sharedLocation = new BlockingBuffer();

        Task producer = new Producer(sharedLocation).Run();
        Task consumer = new Consumer(sharedLocation).Run();

        await producer;
        await consumer;
    }
}