using EstudoLog;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

if (path is null)
    return;

using StreamReader file = new StreamReader(path);
List<User> users = new List<User>();
Dictionary<string, int> lastUpdates = new Dictionary<string, int>();
string? line;

while ((line = file.ReadLine()) is not null)
{
    string[] text = line.Split(" ");
    string name = text[0];
    DateTime date = DateTime.Parse(text[1]);

    User user = new User(name, date);
   
    if (!users.Exists(x => x.Name == user.Name))
    {
        users.Add(user);
        lastUpdates[user.Name] = 1;
    }
    else
    {
        lastUpdates[user.Name] += 1;
    }
}

file.Close();

foreach (var item in lastUpdates)
{
    Console.WriteLine($"Name: {item.Key} Updates: {item.Value}");
}

Console.Write($"Total users: {users.Count}");