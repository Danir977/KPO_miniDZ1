using KPO_mini_DZ1;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<VetClinic>()
    .AddSingleton<Zoo>()       
    .BuildServiceProvider();

var zoo = serviceProvider.GetRequiredService<Zoo>();
Menu menu = new Menu(zoo);
menu.ShowMainMenu();