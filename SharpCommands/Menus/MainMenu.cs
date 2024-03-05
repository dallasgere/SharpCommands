namespace SharpCommands.Menus;
using SharpCommands.Commands;

public class MainMenu
{
    /// <summary>
    /// this is the ls class that gets injected from dependency injection
    /// </summary>
    public Ls LsCommand { get; set; }

    /// <summary>
    /// constructor that takes in a ls class that comes from DI
    /// </summary>
    /// <param name="lsCommand"></param>
    public MainMenu(Ls lsCommand)
    {
        this.LsCommand = lsCommand;
    }

    /// <summary>
    /// starting the application
    /// </summary>
    public void Start()
    {
        // the loop to start the menu
        string continueChoice = string.Empty;
        while (continueChoice.ToLower() != "q")
        {
            try
            {
                // getting user input
                Console.Write("what would you like to do: ");
                continueChoice = Console.ReadLine();
                Console.WriteLine(continueChoice);

                // checking if string is null or empty
                if (!string.IsNullOrEmpty(continueChoice))
                {
                    if (continueChoice.ToLower() == "ls")
                    {
                        string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        string directory = Path.Combine(homeDirectory, "dev");
                        this.LsCommand.LsCommand(directory);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in main menu: {e}");
            }
        }
    }
}
