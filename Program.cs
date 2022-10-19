// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Converter;
using Newtonsoft.Linq;
using System.IO;

List<string> ansatte = new List<string>();

void ligg()
{
    Console.WriteLine("Legg inn ansatt");
    string lol = Console.ReadLine();
    ansatte.Add(lol);
    Console.WriteLine(string.Join(", ", ansatte));
    main();
}

void rediger()
{
    Console.WriteLine("Her er dine ansatte:");
    Console.WriteLine(string.Join(", ", ansatte));
    Console.WriteLine("Hvem vil du redigere");
    string lol = Console.ReadLine();
    ansatte.Remove(lol);
    Console.WriteLine("Hva vil du kalle?");
    lol = Console.ReadLine();
    ansatte.Add(lol);
}

void fjerne()
{
    Console.WriteLine("Her er dine ansatte:");
    Console.WriteLine(string.Join(", ", ansatte));
    Console.WriteLine("Hvem vil du fjerne?");
    string lol = Console.ReadLine();
    ansatte.Remove(lol);
    Console.WriteLine(" ");
    Console.WriteLine(string.Join(", ", ansatte));
    main();
}

void main()
{
    Convert_json_to_cs();
    Console.WriteLine("1: Legg inn ny ansatt.");
    Console.WriteLine("2: Rediger ansatt.");
    Console.WriteLine("3: Slett ansatt.");
    Console.WriteLine("4: List alle ansatte.");
    Console.WriteLine();
    string lol = Console.ReadLine();
    if (lol == "1")
    {
        ligg();
    }

    if (lol == "close")
    {
        System.Environment.Exit(1);
    }

    if (lol == "2")
    {
        rediger();
    }

    if (lol == "3")
    {
        fjerne();
    }

    if (lol == "4")
    {
        main();
        Console.WriteLine(string.Join(", ", ansatte));
    }
    else{
        main();
    }
}

    Console.WriteLine("BlackTure jobb ansatte");
    Console.WriteLine("What do you want to do?");

main();