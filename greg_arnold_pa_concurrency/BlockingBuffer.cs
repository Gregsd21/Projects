/****************************************************************
* Name:Greg Arnold
* Date: 12/5/2023
* Assignment: CIS317 Week 5 GP – Concurrency
* BlockingBuffer class that acts as the warehouse where the producer
* stores items produced and the consumer retrieves (or reads) items
* to consume.
*/
using System.Collections.Concurrent;

public class BlockingBuffer
{
    private BlockingCollection<int> BColl;

    public BlockingBuffer(int bufferSize)
    {
        BColl = new BlockingCollection<int>(bufferSize);
    }

    // add a value to the collection
    public void BlockingPut(int value, string name)
    {
        BColl.Add(value);
        Console.WriteLine(
            "Producer {0} writes {1}\tBuffer cells occupied: {2}", 
            name,value, BColl.Count);
    }

    // return value from the collection
    public int BlockingGet(string name)
    {
        int readValue = BColl.Take();
        Console.WriteLine(
            "Consumer {0} reads {1}\tBuffer cells occupied: {2}", name,
            readValue, BColl.Count);

        return readValue;
    }
}
