
class TodoApp
{
    public static void Run()

    {
        List<string> tasks = new List<string>();

        while (true)

        {
            Console.Write("Enter command (add, show, remove, clear): ");
            string command = Console.ReadLine() ?? "";

            switch (command)

            {
                case "add":
                
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine() ?? "";


                    if (task != "")
                    {
                        tasks.Add(task);
                    }
                    else
                    {
                        Console.WriteLine("Task cannot be empty.");
                    }
                    break;

                case "show":

                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i}: {tasks[i]}");
                    }
                    break;

                case "remove":

                    Console.Write("Enter index: ");
                    int index;

                    if (int.TryParse(Console.ReadLine(), out index) &&
                        index >= 0 && index < tasks.Count)
                    {
                        tasks.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "clear":
                    tasks.Clear();
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}