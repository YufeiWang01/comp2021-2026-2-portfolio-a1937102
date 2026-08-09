
class TodoApp
{
    public static void Run()

    {
        List<string> tasks = new List<string>();

        Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();

        while (true)

        {
            Console.Write("Enter command (add, show, remove, clear, tag, get-tagged): ");
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

                    ShowTasks(tasks);
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

                case "tag":
                Console.Write("Enter index: ");
                int tagIndex;

                if (!int.TryParse(Console.ReadLine(), out tagIndex) ||
                    tagIndex < 0 || tagIndex >= tasks.Count)
                {
                    Console.WriteLine("Invalid index.");
                    break;
                }

                Console.Write("Enter tag: ");
                string tagName = Console.ReadLine() ?? "";

                if (!tags.ContainsKey(tagName))
                {
                    tags[tagName] = new List<int>();
                }

                if (tags[tagName].Contains(tagIndex))
                {
                    Console.WriteLine("Tag already added.");
                    break;
                }

                tags[tagName].Add(tagIndex);
                Console.WriteLine("Tag added.");
                break;

                case "get-tagged":
                Console.Write("Enter tag: ");
                string searchTag = Console.ReadLine() ?? "";

                if (!tags.ContainsKey(searchTag))
                {
                    Console.WriteLine("Tag not found.");
                    break;
                }

                foreach (int taskIndex in tags[searchTag])
                {
                    Console.WriteLine($"{taskIndex}: {tasks[taskIndex]}");
                }
                break;



                default:
                    Console.WriteLine("Invalid command.");
                    break;


                
            }
        }

    }

    static void ShowTasks(List<string> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
        }


}