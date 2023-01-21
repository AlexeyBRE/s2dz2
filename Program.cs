//  Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//   что третьей цифры нет.
Console.WriteLine("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
while(n>1)
{
if(n<999 && n>99) 
{
    n=n%100;
    Console.WriteLine($"{n=n%10}") ;
    break;
}
else if(n>999){
    n=n/10;
    continue;
}
else if(n<100)
{
Console.WriteLine($"третьей цифры нет") ;
break;
}
}