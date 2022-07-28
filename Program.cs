Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] mas = new string [n];
string [] tempMas = new string [n];
void CreateMas(string [] mas, int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine("Введите строку, которую вы хотите добавить в массив: ");
    string element = Convert.ToString(Console.ReadLine());
    mas[i] = element;
  }
}

void ModifyMas(string [] mas, int n, string [] tempMas)
{
  for (int i = 0; i < n; i++)
  {
    if (mas[i].Length <= 3)
    {
      tempMas[i] = mas[i]; 
    }
  }
}

void PrintMas(string [] mas, int n, string [] tempMas)
{
  Console.WriteLine("Преобразованный массив, в котором остались элементы с количеством символов меньше или равно 3: ");
  Console.Write("[");
  int count = 0;
  while(count < n)
  {
    Console.Write(mas[count]);
    count++;
    if (count < n)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]" + "->");
  Console.Write("[");
  int countTemp = 0;
  while(countTemp < n)
  {
    Console.Write(tempMas[countTemp]);
    countTemp++;
    if (countTemp < n)
    {
      Console.Write(", ");
    }
  }
    Console.Write("]");
}
  


CreateMas(mas, n);
ModifyMas(mas, n, tempMas);
PrintMas(mas, n, tempMas);