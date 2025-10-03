string ShowMessage(string name)
{
    return $"Hola, {name}!"; 
}

Console.WriteLine(ShowMessage(args.Length > 0 ? args[0] : "Nombre1"));
Console.WriteLine(ShowMessage(args.Length > 1 ? args[1] : "Nombre2"));