// Выводит третью цифру заданного числа или сообщает что третьей цифры нет

void FillArray(int[] fill)
{
  int length = fill.Length;
  int index = 0;
  while (index < length)
  {
    fill[index] = new Random().Next(1, 10);
    index++;
  }
}
void PrintArray(int[] pen)
{
  int a = pen.Length;
  int index = 0;
  while (index < a)
  {
    Console.WriteLine(pen[index]);
    index++;
  }
}
int NumberShow(int[] mean)
{
  int b = mean.Length;
  int number = 0;
  for (int index = 0; index < b; index++)
  {
    if (b < 3)
    {
      Console.WriteLine("третья цифра отсутствует");
    }
    if (index == 2)
    {
      number = mean[index];
    }
  }
  return number;
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int c = NumberShow(array);
Console.WriteLine(c);

