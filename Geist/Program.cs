// See https://aka.ms/new-console-template for more information
Console.WriteLine("Aufgabe 1");
Console.WriteLine(" .-. ");
Console.WriteLine("(o o)  ");
Console.WriteLine("| O |");
Console.WriteLine("|   |");
Console.WriteLine("'~~~'");

Console.WriteLine("");
Console.WriteLine("Aufgabe 2");
string Vorname = "Nihat";
string Nachname = " Artan";
string Alter = "16";
string Wohnort = "Rösrath";
string Postleitzahl = "51503";

Console.WriteLine("Der Name des Geistes lautet {0}", Vorname + Nachname);
Console.WriteLine("Der Geiist wohnt in {0} und die Postleitzahl lautet {1}", Wohnort, Postleitzahl);
Console.WriteLine("Und der Geist ist {0} Jahre alt", Alter);

Console.WriteLine("");
Console.WriteLine("Aufgabe 3");
string Vorname1;
string Alter1;
string Klasse1;

Console.WriteLine("Wie heißt du?");
Vorname1 = Console.ReadLine();
Console.WriteLine("Wie alt bist du?");
Alter1 = Console.ReadLine();
Console.WriteLine("in welche Klasse gehst du?");
Klasse1 = Console.ReadLine();

Console.WriteLine($"{Vorname1} ist {Alter1} Jahre alt und besucht die {Klasse1} des Georg-Simon-Ohm Berufskollegs.");



