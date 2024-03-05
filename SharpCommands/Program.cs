using Microsoft.Extensions.DependencyInjection;
using SharpCommands.Commands;
using SharpCommands.Menus;

var serviceCollection = new ServiceCollection()
    .AddScoped<MainMenu>()
    .AddScoped<Ls>()
    .BuildServiceProvider();

var menu = serviceCollection.GetService<MainMenu>();
menu.Start();