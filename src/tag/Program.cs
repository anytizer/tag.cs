using libraries;
using libraries.dtos;

namespace tag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
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
                        string[] images = scanner.list(args[1]); // directoryPath

                        Console.WriteLine("{0} images found.", images.Length);

                        foreach (string image in images)
                        {
                            //TagInformationDTO tag = scanner.getTags(image);

                            Console.WriteLine(image);
                            //Console.WriteLine("  Orientation: " + tag.orientation);
                            //Console.WriteLine("  Width: " + tag.width);
                            //Console.WriteLine("  Height: " + tag.height);
                            //Console.WriteLine("  Size: " + tag.filesize);
                            //Console.WriteLine("");
                        }
                    }
                    else if (args[0] == "build")
                    {
                        string batch = scanner.build(args[1]); // dir path
                        Console.WriteLine("Scanned into a batch: "+batch);
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
                        string backup = scanner.empty(); // also creates a backup
                        Console.WriteLine("Session backed up as: " + backup);
                    }
                    else if (args[0] == "new")
                    {
                        scanner.newDB();
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
                    Console.WriteLine("  tag new");
                    Console.WriteLine("  tag empty");
                    Console.WriteLine("  tag list .\\images     : Builds a list of files being scanned for.");
                    Console.WriteLine("  tag build .\\images    : Returns batch ID.");
                    Console.WriteLine("");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("System error happened.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Finished!");
        }
    }
}