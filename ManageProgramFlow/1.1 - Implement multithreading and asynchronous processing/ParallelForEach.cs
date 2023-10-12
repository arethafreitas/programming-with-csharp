namespace ManageProgramFlow;

/*
The Parallel.ForEach method accepts two parameters. 
The first parameter is an IEnumerable collection (in this case the list items). 
The second parameter provides the action to be performed on each item in the list. 
You can see some of the output from this program below. 
Note that the tasks are not completed in the same order that they were started.
Miles, Rob. Exam Ref 70-483 Programming in C# (pp. 4-5). Pearson Education. Edição do Kindle. 
 */
public class ParallelForEach
{
    static void WorkOnItem(object item)
    {
        Console.WriteLine("Started working on: " +item);
        Thread.Sleep(100);
        Console.WriteLine("Finished working on: " +item);
    }

    static void Main(string[] args)
    {
     var items = Enumerable.Range(0, 20);
     Parallel.ForEach(items, item => 
     {
        WorkOnItem(item);
     });
     Console.WriteLine("Finished processing. Press a key to end.");
     Console.ReadKey();
    }
}
