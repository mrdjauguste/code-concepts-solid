using Open_Closed_Principle.Solution;

List<string> jeremyList =
[
    "apples",
    "bananas",
    "tictacs",
];

List<string> nahumList =
[
    "playstation 5 pro",
    "apple vision pro",
];

Shopper jeremy = new Shopper(new Publix());

Shopper nahum = new Shopper(new Walmart());

Console.WriteLine("Jeremy");

List<string> jeremyItems = jeremy.Shop(jeremyList);
jeremyItems.ForEach(x => Console.WriteLine(x));

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Nahum");

List<string> nahumItems = nahum.Shop(nahumList);
nahumItems.ForEach(x => Console.WriteLine(x));

// Explain dollar sign string
// IEnumerable