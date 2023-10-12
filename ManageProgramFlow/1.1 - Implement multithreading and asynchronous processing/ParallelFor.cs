namespace ManageProgramFlow;

/*
This implements a counter starting at 0 (the first parameter of the Parallel.For method),
 for the length of the items array (the second parameter of the Parallel.For method). 
 The third parameter of the method is a lambda expression, 
 which is passed a variable that provides the counter value for each iteration.
Miles, Rob. Exam Ref 70-483 Programming in C# (p. 5). Pearson Education. Edição do Kindle.  */
public class ParallelFor
{
    static void Main(string[] args)
    {
        var items = Enumerable.Range(0, 500).ToArray();

        Parallel.For(0, items.Length, i => {
            WorkOnItem(items[i]);
        });
        Console.WriteLine("Finished processing. Press a key to end.");
        Console.ReadKey();
    }

    static void WorkOnItem(object item)
    {
        Console.WriteLine("Started working on: " +item);
        Thread.Sleep(100);
        Console.WriteLine("Finished working on: " +item);
    }
}
