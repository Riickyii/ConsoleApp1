// See https://aka.ms/new-console-template for more information
Console.WriteLine("Print logs? y/n");
string l = Console.ReadLine().ToUpper();
while (l != "Y")
{
    if (l == "N") { break; }
    Console.WriteLine("Print logs? y/n");
    l = Console.ReadLine().ToUpper();
}
bool s = false;
if (l == "Y") { s = true; }
Console.ReadKey();