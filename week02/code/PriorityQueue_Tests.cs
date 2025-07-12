using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add multiple items with different priorities and dequeue one item
    // Expected Result: Volleyball should be returned
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Basketball", 6);
        priorityQueue.Enqueue("Volleyball", 10);
        priorityQueue.Enqueue("Soccer", 6);
        priorityQueue.Enqueue("Pickleball", 9);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Volleyball", result);

    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority and ensure the first one added is dequeued first
    // Expected Result: Basketball should be returned
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Basketball", 6);
        priorityQueue.Enqueue("Soccer", 6);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Basketball", result);
    }

    // Add more test cases as needed below.
}