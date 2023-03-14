//На вход трёхзначное число, на выход вторая цифра этого числа

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
int NumberOf(int[] mean, int c)
{
  int b = mean.Length;
  int index = 0;
  int number = 0;
  while (index < b)
  {
    if (index == c)
    {
      number = mean[index];
    }
    index++;
  }
  return number;
}

int[] array = new int[3];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int c = NumberOf(array, 1);
Console.WriteLine(c);
