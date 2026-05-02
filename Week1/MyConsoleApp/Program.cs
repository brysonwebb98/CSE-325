Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");

DateTime today = DateTime.Now;
DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
int daysLeft = (christmas - today).Days;

Console.WriteLine(today);
Console.WriteLine(christmas);

Console.WriteLine($"Only {daysLeft} left until Christmas!");