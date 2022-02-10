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