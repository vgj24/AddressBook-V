// See https://aka.ms/new-console-template for more information
using MyAddressBook;

Console.WriteLine("Address book Program");

    string selection = "";
    AddressPrompt prompt = new AddressPrompt();

    prompt.displayMenu();

while (!selection.ToUpper().Equals("Q"))
{
    Console.WriteLine("Selection: ");
    selection = Console.ReadLine();
    prompt.PerformAction(selection);
}

Console.ReadKey();



