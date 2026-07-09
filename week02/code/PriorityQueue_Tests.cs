using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items: Bag (3), Pencil (5), Notebook(1), Laptop (2), Water (4)
    // Expected Result: Pencil (5), Water (4), Bag (3), Laptop (2), Notebook(1), 
    // Defect(s) Found: Dequeue is not saving the highest priority index and 
    //                  not removing the item with the highest priority from the queue.
    public void TestPriorityQueue_DifferentPriorities()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bag", 3);
        priorityQueue.Enqueue("Pencil", 5);
        priorityQueue.Enqueue("Notebook", 1);
        priorityQueue.Enqueue("Laptop", 2);
        priorityQueue.Enqueue("Water", 4);

        int i = 0;
        while (priorityQueue.ToString() != "[]")
        {
            //Check if priority queue is empty
            if (priorityQueue.ToString() == "[]")
            {
                Assert.Fail("The queue is empty.");
            }

            var item = priorityQueue.Dequeue();
            switch (i)
            {
                case 0:
                    Assert.AreEqual("Pencil", item);
                    break;
                case 1:
                    Assert.AreEqual("Water", item);
                    break;
                case 2:
                    Assert.AreEqual("Bag", item);
                    break;
                case 3:
                    Assert.AreEqual("Laptop", item);
                    break;
                case 4:
                    Assert.AreEqual("Notebook", item);
                    break;
            }
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create an empty high priority queue with same priorities and attempt to dequeue.
    // Create a queue with the following items: Bag (1), Pencil (4), Notebook(3), Laptop (4), Water (3)
    // Expected Result: Pencil (4), Laptop (4), Notebook(3), Water (3), Bag (1)
    // Defect(s) Found: Dequeue is not removing the highest priority in accordance to FIFO when there are same priorities in the queue.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bag", 1);
        priorityQueue.Enqueue("Pencil", 4); //first priority
        priorityQueue.Enqueue("Notebook", 2);
        priorityQueue.Enqueue("Laptop", 4); //Second priority
        priorityQueue.Enqueue("Water", 3);

        int i = 0;
        while (priorityQueue.ToString() != "[]")
        {
            //Check if priority queue is empty
            if (priorityQueue.ToString() == "[]")
            {
                Assert.Fail("The queue is empty.");
            }

            var item = priorityQueue.Dequeue();
            switch (i)
            {
                case 0:
                    Assert.AreEqual("Pencil", item);
                    break;
                case 1:
                    Assert.AreEqual("Laptop", item);
                    break;
                case 2:
                    Assert.AreEqual("Water", item);
                    break;
                case 3:
                    Assert.AreEqual("Notebook", item);
                    break;
                case 4:
                    Assert.AreEqual("Bag", item);
                    break;
            }
            i++;
        }
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Create an empty high priority queue and attempt to dequeue
    // Expected Result: It should raise and error and show an error mesage
    // Defect(s) Found: No Defects Found!
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException error was not thrown.");
        }
        catch (InvalidOperationException err)
        {
            Assert.AreEqual("The queue is empty.", err.Message);
        }
    }
}