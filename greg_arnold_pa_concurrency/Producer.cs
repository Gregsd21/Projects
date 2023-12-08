/****************************************************************
 * Name: Greg Arnold
 * Date: 12/5/2023
 * Assignment: CIS317 Week 5 GP – Concurrency
 * Producer class used to produce items and place them in the buffer.
 */

public class Producer
{
    private BlockingBuffer SharedLocation;
    private Random Generator = new Random();
    private string Name;
    private int SleepTime;
    private int StartProducing;
    private int StopProducing;


    public Producer(BlockingBuffer sharedLocation, string name, 
        int startProducing, int stopProducing, int sleepTime)
    {
        SharedLocation = sharedLocation;
        Name = name;
        SleepTime = sleepTime;
        StartProducing = startProducing;
        StopProducing = stopProducing;
    }

    public async Task Run()
    {
        for (int count = StartProducing; count <= StopProducing; count++)
        {
                //Sleep for a random time up to sleepTime second
                await Task.Delay(Generator.Next(SleepTime * 1000));
                SharedLocation.BlockingPut(count, Name);
        }

        Console.WriteLine(
            "Producer {0} done producing\nTerminating Producer {0}\n", Name);
    }
}
