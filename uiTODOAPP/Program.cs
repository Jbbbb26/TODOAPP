



using System.ComponentModel.DataAnnotations;
using TODOService;
namespace uiTODOAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TO DO Application");

        List<Task> list = new List<Task>();
            Task.add("Task 1");
            Task.add("Task 2");
            Task.add("Task 3");
            foreach (var item in Task)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        

        Display task;
    
    public void AddTask(string task)
        {
            Task.Add(task);
        }
        public void RemoveTask(string task)
        {
            Task.Remove(task);
            
        }
        public void UpdateTask(int index, string newTask)
        {
            Task[index] = newTask;
        }
        public void DisplayTasks()
        {
            foreach (var item in Task)
            {
                Console.WriteLine(item);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();


            }
        }

   
    }
        }
    

