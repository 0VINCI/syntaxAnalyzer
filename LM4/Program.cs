using System;
using System.Text.RegularExpressions;

// Definicja wzorca wyrażenia regularnego
string pattern = @"[0-9]+([+*-/^][0-9]+)+(;[0-9]+([+*-/^][0-9]+)+)*";

// Utworzenie obiektu Regex
Regex regex = new Regex(pattern);

Console.WriteLine("Wprowadz wyrażenie arytmetyczne do walidacji (lub wpisz 'q' aby zakończyc):");

while (true)
{
    Console.Write("Wprowadz wyrazenie: ");
    string? userInput = Console.ReadLine();

    // Zakończenie programu, jeśli użytkownik wpisze 'q'
    if (userInput?.ToLower() == "q")
    {
        break;
    }

    // Walidacja wprowadzonego ciągu znaków
    if (userInput != null && regex.IsMatch(userInput))
    {
        Console.WriteLine("Wprowadzone wyrażenie: " + userInput + " jest zgodne z gramatyką");
    }
    else
    {
        Console.WriteLine("Wprowadzone wyrażenie: " + userInput + " nie jest zgodne z gramatyką");
    }
}

Console.WriteLine("Wykonanie programu zostało zakończone");