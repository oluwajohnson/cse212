using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Enqueue a single item and then dequeue it.
    // Expected Result:
    // The same value that was enqueued should be returned.
    // Defect(s) Found:
    // None.
    public void TestPriorityQueue_1()
    {
         var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
        
    }

    [TestMethod]
    // Scenario:
    // Enqueue multiple items with different priorities.
    // Expected Result:
    // The item with the highest priority should be dequeued first.
    // Defect(s) Found:
    // Dequeue does not always return the highest-priority item.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario:
    // Enqueue multiple items with the same highest priority.
    // Expected Result:
    // The item that was enqueued first (FIFO) among the highest priority
    // items should be dequeued first.
    // Defect(s) Found:
    // FIFO order is not preserved for items with the same priority.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 1);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario:
    // Dequeue from an empty queue.
    // Expected Result:
    // An InvalidOperationException should be thrown with the message
    // "The queue is empty."
    // Defect(s) Found:
    // Exception is not thrown or incorrect exception/message is used.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}