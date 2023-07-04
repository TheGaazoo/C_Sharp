 // Console.WriteLine("Введите первое число:");
 // int a = Convert.ToInt32(Console.ReadLine());
 // Console.WriteLine("Введите второе число:");
 // int b = Convert.ToInt32(Console.ReadLine());
 // Console.WriteLine("Введите третье число:");
 // int c = Convert.ToInt32(Console.ReadLine());
 // Console.WriteLine(a*a);
 // Console.WriteLine(b*b);
// Console.WriteLine(c*c); 
Console.WriteLine("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
    Console.WriteLine("День недели - понедельник");
else if (a==2)
Console.WriteLine("День недели - вторник");
else if (a==3)
Console.WriteLine("День недели - среда");
else if (a==4)
Console.WriteLine("День недели - четверг");
else if (a==5)
Console.WriteLine("День недели - пятница");
else if (a==6)
Console.WriteLine("День недели - суббота");
else if (a==7)
Console.WriteLine("День недели - воскресенье");
else Console.WriteLine("Такого дня недели не существует");