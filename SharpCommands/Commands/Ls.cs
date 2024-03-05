namespace SharpCommands.Commands;

public class Ls
{
    public Ls() { }

    public void LsCommand(string targetDirectory)
    {
        List<string> files = Directory.GetFiles(targetDirectory).ToList();
        List<string> directories = Directory.GetDirectories(targetDirectory).ToList();
        this.DisplayFiles(files, directories);
    }

    public void DisplayFiles(List<string> files, List<string> directories)
    {
        foreach (string group in directories)
            Console.WriteLine(group);
        foreach (string file in files)
            Console.WriteLine(file);
    }
}
