// На вход цифра обозначающая день недели, проверить выходной или нет

Console.WriteLine("Введите день недели ");
int n = Convert.ToInt32(Console.ReadLine());

if(n>5 && n<8)
{
  Console.WriteLine("да");
}
if(n>0 && n<6)
{
  Console.WriteLine("нет");
}

