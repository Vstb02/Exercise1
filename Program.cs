using Exercise1;

string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

var selectedTeams = from t in teams
                    where t.ToUpper().StartsWith("Б") 
                    orderby t  
                    select t;
var selectedTeams2 = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);

foreach (string s in selectedTeams)
    Console.WriteLine(s);
foreach (string s in selectedTeams2)
    Console.WriteLine(s);



////////


int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

IEnumerable<int> evens = from i in numbers
                         where i % 2 == 0 && i > 10
                         select i;
foreach (int i in evens)
    Console.WriteLine(i);


int[] numbers2 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
IEnumerable<int> evens2 = numbers.Where(i => i % 2 == 0 && i > 10);

List<User> users = new List<User>
{
    new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
    new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
    new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
    new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};

var selectedUsers = from user in users
                    where user.Age > 25
                    select user;
foreach (User user in selectedUsers)
    Console.WriteLine($"{user.Name} - {user.Age}");


