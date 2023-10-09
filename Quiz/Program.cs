Console.WriteLine("Var bor jag?  A: Bromma   B: Vällingby   C: Hässelby     Svara A, B eller C.");

int sum = 0;

string hem = Console.ReadLine().ToLower();



if(hem == "c") 
{

sum++;
Console.WriteLine($"Helt rätt! Du har {sum} poäng.");
}
else if (hem == "a" || hem == "b") {
    Console.WriteLine("Fel, jag bor inte där. Försök igen.");
    Thread.Sleep(2000);
    System.Environment.Exit(1);
}

else {
    Console.WriteLine("Välj ett av alternativen. Försök igen.");
    Thread.Sleep(1500);
    System.Environment.Exit(1);
}

Console.WriteLine("Heter jag Elnur?    A: Ja   B:Nej   C: Kanske    Svara ja, nej, eller kanske.");
string elnur = Console.ReadLine().ToLower();
if (elnur == "ja" || elnur == "kanske")
{
    sum++;
    Console.WriteLine($"Rätt igen! Du har {sum} poäng.");
}

else if (elnur == "nej")
{
    Console.WriteLine("Fel, jag heter elnur. Försök igen.");
    Thread.Sleep(1500);
    System.Environment.Exit(1);
}

else {
    Console.WriteLine("Välj ett av alternativen. Försök igen.");
    Thread.Sleep(1500);
    System.Environment.Exit(1);
}


    Console.WriteLine("Vilken lärare är goated?   A: Alexander   B: Nathalie    C: Vera    Svara Alexander, Nathalie, eller Vera.");
    string goat = Console.ReadLine().ToLower();
if (goat == "alexander" || goat == "nathalie")
{
    sum++;
    Console.WriteLine("Rätt igen, både Alexander och Nathalie är dock goated.");
    Console.WriteLine($"Du klarade dig igenom quizen. Du fick totalt {sum} poäng!");
    Thread.Sleep(2000);
    System.Environment.Exit(1);
}

else if (goat =="vera")
{
    Console.WriteLine("Vera?? No offense till henne men man somnar typ på hennes lektioner.");
    Console.WriteLine("Det är fel, försök igen.");
    Thread.Sleep(1500);
    System.Environment.Exit(1);
}

else {
    Console.WriteLine("Välj ett av svaren. Försök igen.");
    Thread.Sleep(1500);
    System.Environment.Exit(1);
}

Console.ReadLine();