// Collections:

// Array - Can only store items of the same type and it has a set size (that you set). Arrays "pre-allocate" the amount of memory that is needed.

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

Console.WriteLine(cars[0]); // expect Volvo
Console.WriteLine(cars[3]); // expect Mazda
Array.Sort(cars);
foreach (string car in cars)
{
    Console.WriteLine(car);
}

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

char[] characters = { 'a', 'b', 'c', 'd' };
for (int index = 0; index < characters.Length; index++)
{
    Console.WriteLine(characters[index]);
     //character[0] = 'a'
     //character[1] = 'b'
     //character[2] = 'c'
     //character[3] = 'd'
}

string[] letters = { "abc", "def", "ghi" };
Console.WriteLine("Length of array 'letters'");
Console.WriteLine(letters.Length);



/// * * * * * 




// Lists - can store different types and add/remove items to change the size (allocate memory as needed).

List<string> countries = new List<string> { "India", "Australia", "Japan", "Canada", "Mexico" };
countries.Add("Africa");
countries.Add("America");

countries.Remove("Australia"); // can remove the element based on the specific name of the element.
countries.RemoveAt(2); // expect to remove Canada
Console.WriteLine();
Console.WriteLine("Displaying list of countries");

foreach (string country in countries)
{
    Console.WriteLine(country);
}

List<int> numbersList = new List<int>();
numbersList.Add(1);
numbersList.Add(2);
numbersList.Add(3);

foreach(int num in numbersList)
{
    Console.WriteLine(num);
}

numbersList.Add(4);
numbersList.Add(5);
numbersList.Remove(2); // removes 2
numbersList.Add(6); // removes nothing -- tricked ya

// could also you .RemoveAt (to remove a specific section of the index)

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Removes some stuff");
foreach (int nums in numbersList)
{
    Console.WriteLine(nums);
}

var alphabet = new List<char> { 'a', 'b', 'c', 'd' };

foreach (char let in alphabet)
{
    Console.WriteLine(let);
}

alphabet.Insert(1, 'j');
Console.WriteLine("We inserted 'j'");
foreach (char let in alphabet)
{
    Console.WriteLine(let);
}

var bestFriends = new List<string> { "Kelly", "Amanda", "Jason", "Michael", "Blake", "Roger" };
foreach (string friend in bestFriends)
{
    Console.WriteLine(friend);
}
bestFriends.Remove("Amanda");
bestFriends.Add("Jessica");
bestFriends.Insert(0, "Zach");

foreach (string friend in bestFriends)
{
    Console.WriteLine(friend);
}
// Zach
// Kelly
// Jason
// Mike
// Blake
// Roger
// Jessica

//string selection = Console.ReadLine();
// 4 

//int index2 = bestFriends.IndexOf(selection);
//Console.WriteLine($"Found {selection} at {index2}.");

//var movies = new List<string> { "It", "Lord of the Rings", "Jaws", "Ferngully" };

//string moviePick = Console.ReadLine();
//int i = movies.IndexOf(moviePick);

//if (i >= 0 && i < movies.Count)
//{
//    Console.WriteLine($"Great! You picked {moviePick}, that's on aisle #{i}");
//}
//else
//{
//    Console.WriteLine($"Sorry! we don't have {moviePick} in stock. Try again later this week!");
//}


// * * * * *




// Dictionary - collection of "keys" and "values" as pairs of data (similar syntax to list, but different). (key, value) -- proper syntax * * *

Dictionary<string, string> favoriteFoods = new Dictionary<string, string>();
favoriteFoods["Brynn"] = "sunflower seeds";
favoriteFoods["Zach"] = "kimchi";
favoriteFoods["Cameron"] = "budlight";
favoriteFoods["Aaron"] = "mcdonalds";

Console.WriteLine("Tell me Zach's favorite food");
Console.WriteLine($"Zach's favorite food is {favoriteFoods["Zach"]}");

Dictionary<string, decimal> salaries = new Dictionary<string, decimal>();
salaries["Ron"] = 130000m;
salaries["Melody"] = 30000m;
salaries["Brynn"] = 70000m;
salaries["Zach"] = 52000m;

foreach (string key in salaries.Keys) // "key" is a property, like .count or .length) * * *
{
    Console.WriteLine(key);
}

foreach (decimal value in salaries.Values) 
{
    Console.WriteLine(value);
}

foreach (var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes { pair.Value}.");
}



