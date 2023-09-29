using Entities;

Console.WriteLine("Calendar App");

Meeting meeting1 = new()
{
    Title = "YetGen Jump & Akbank Backend Dersi",
    Details = new List<string>()
    {
        "Derse katılım sağlanacak"
    },
    StartTime = new DateTime(2023, 09, 28, 20, 00, 00),
    FinishTime =   new DateTime(2023, 09, 28, 22, 00, 00),
    Guests = new() { "sueda@deneme.com", "yetgen@deneme.com"},
};

Todo todo1 = new()
{
    Title = "Calendar Uygulaması Yapımı",
    Details = new List<string>()
    {
        "Uygulama programlanıp Github'a atılması",
        "URL'sinin moodlea yüklenmesi"
    },
    StartTime = new DateTime(2023, 09, 25, 00, 00, 00),
    FinishTime =   new DateTime(2023, 09, 26, 00, 00, 00),
    Importance = "High Priority",
};

meeting1.GetNotification();

todo1.GetNotification();

Console.ReadLine();
