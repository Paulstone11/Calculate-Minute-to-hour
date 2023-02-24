Console.WriteLine("Enter minute = ");
int amn = int.Parse(Console.ReadLine());

int amh = amn / 60;
int rmn = amn % 60;
Console.WriteLine("The amount you enter equal to {0} hour {1} minute", amh, rmn);
