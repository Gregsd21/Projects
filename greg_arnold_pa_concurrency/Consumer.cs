/****************************************************************
 * Name: Greg Arnold
 * Date: 12/5/2023
 * Assignment: CIS317 Week 5 GP – Concurrency
 * Consumer class used to use (or consume) items that the producer
 * places in the buffer.
 */

public class Consumer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    private string Name;
    private int SleepTime;
    private int StartConsuming;
    private int StopConsuming;

    public Consumer(BlockingBuffer sharedLocation, string name, 
        int startConsuming, int stopConsuming, int sleepTime)
    {
        SharedLocation = sharedLocation;
        Name = name;
        SleepTime = sleepTime;
        StartConsuming = startConsuming;
        StopConsuming = stopConsuming;
    }

    public async Task Run()
    {
        int sum =0;

        for (int count = StartConsuming; count <= StopConsuming; count++)
        {
            //Sleep for a random time up to SleepTime seconds
            await Task.Delay(Generator.Next(SleepTime * 1000));
            sum += SharedLocation.BlockingGet(Name);
        }

        Console.WriteLine(
            "\nConsumer {0} read values totaling {1}\n"
            + "Terminating Consumer {0}\n",
            Name, sum);
    }
}
