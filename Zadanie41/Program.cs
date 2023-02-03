Console.WriteLine ("Введите числа:");
string numbers = Console.ReadLine();
string [] newNumbers = new string [numbers.Length];
int x = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    x++;
  }
  else
  {
    newNumbers[x] = newNumbers[x]+$"{numbers[i]}";
  }
}
x++;
int [] resultNumbers = new int[x];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < x; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}