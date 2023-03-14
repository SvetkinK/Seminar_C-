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
int NumberShow(int[] mean, int c)
{
  int b = mean.Length;
  int index = 0;
  int number = 0;
  for (index = 0; index < b; index++)
  {
    if (index == c)
    {
      number = mean[index];
    }
    else
    {
      Console.WriteLine("третья цифра отсутствует");
      break;
    }
  }
  return number;
}

int[] array = new int[3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int c = NumberShow(array, 2);
Console.WriteLine(c);

