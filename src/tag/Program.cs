using libraries;

namespace tag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner();
            if (args.Length >= 3)
            {
                Console.WriteLine("Too many parameters supplied.");
            }
            else if (args.Length == 2)
            {
                if (args[0] == "list")
                {
                    scanner.list(args[1]);
                }
                else if (args[0] == "build")
                {
                    scanner.build(args[1]);
                }
                else
                {
                    Console.WriteLine("Not understood.");
                }
            }
            if (args.Length == 1)
            {
                if (args[0] == "empty")
                {
                    scanner.empty(); // also creates a backup
                }
                else
                {
                    Console.WriteLine("Not implemented.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Usage:");
                Console.WriteLine("  tag empty");
                Console.WriteLine("  tag list .\\images");
                Console.WriteLine("  tag build .\\images    : Returns batch ID.");
                Console.WriteLine("");
            }

            Console.WriteLine("Finished!");
        }
    }
}