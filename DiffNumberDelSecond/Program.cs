// Вывести число любой разрядности, удалить вторую цифру числа
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
    Console.Write(pen[index]);
    index++;
  }
}
void NumberShow(int[] mean)
{
  int b = mean.Length;
  int temp = 0;
  int index = 1;
  while (index < b - 1)
  {
    temp = mean[index];
    mean[index] = mean[index + 1];
    mean[index + 1] = temp;
    index++;
  }
  for (index = 0; index < b - 1; index++)
  {
    Console.Write(mean[index]);
  }
}


int[] array = new int[9];

FillArray(array);
PrintArray(array);
Console.WriteLine();

NumberShow(array);
Console.WriteLine();
