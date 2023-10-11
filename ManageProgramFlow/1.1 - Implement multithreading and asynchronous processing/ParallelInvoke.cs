namespace ManageProgramFlow;

#region Considerações

/* Classe encontrada em System.Threading.Tasks
Aceita um número de Action delegates e cria uma Task para cada uma deles.
Um delegate de Action é a encapsulação de um método que não aceita parametros e não retorna 
um resultado.

Retorna quando todas as tarefas estiverem completas.
*/

#endregion
public class ParallelInvoke
{
    static void TaskOne()
    {
        Console.WriteLine("Task 1 starting...");
        Thread.Sleep(2000);
        Console.WriteLine("Task 1 ending...");
    }
    static void TaskTwo()
    {
        Console.WriteLine("Task 2 starting...");
        Thread.Sleep(1000);
        Console.WriteLine("Task 2 ending...");
    }

    static void Main()
    {
        Parallel.Invoke(TaskOne, TaskTwo);
        Console.WriteLine("Finished processing. Press a key to end.");
        Console.ReadKey();
    }
}
