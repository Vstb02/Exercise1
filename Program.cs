static IEnumerable<string> Suits()
{
    yield return "трефы";
    yield return "бубны";
    yield return "червы";
    yield return "пики";
}

static IEnumerable<string> Ranks()
{
    yield return "два";
    yield return "три";
    yield return "четыре";
    yield return "пять";
    yield return "шесть";
    yield return "семь";
    yield return "восемь";
    yield return "девять";
    yield return "десять";
    yield return "валет";
    yield return "королева";
    yield return "король";
    yield return "туз";
}


var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Масть = suit, Значение = rank }));

foreach (var c in startingDeck)
{
    Console.WriteLine(c);
}