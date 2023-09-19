// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число дня недели ");
string WeekDay = Console.ReadLine();
if (WeekDay == "1") 
Console.WriteLine($"{WeekDay} -> Понедельник ");
else if (WeekDay == "2") 
Console.WriteLine($"{WeekDay} -> Вторник ");
else if (WeekDay == "3") 
Console.WriteLine($"{WeekDay} -> Среда ");
else if (WeekDay == "4") 
Console.WriteLine($"{WeekDay} -> Четверг ");
else if (WeekDay == "5") 
Console.WriteLine($"{WeekDay} -> Пятница ");
else if (WeekDay == "6") 
Console.WriteLine($"{WeekDay} -> Суббота ");
else if (WeekDay == "7") 
Console.WriteLine($"{WeekDay} -> Воскресенье ");
else
    Console.WriteLine("Некорректно набран день недели");

