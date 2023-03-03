// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("1 - Программа для подсчета количества чисел больше 0, которые ввёл пользователь.");
Console.WriteLine("2 - Программа для подсчета суммы чисел в массиве, стоящих на нёчетных позициях.");
int numberOfTask = Prompt("Введите номер задачи");
     
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_41();
                break;

                case 2:
                Console.Clear();
                Task_43();
                break;

              
                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }
static int Prompt(string message)// Метод запроса числа.
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] InputArray(int length)
{
int[] array = new int [length];
for (int i = 0; i<array.Length; i++)
{
array[i] = Prompt($"Input numbers: ");
  
// string[] msg = Console.ReadLine().Split(" "); // string split метод

// foreach( string el in msg)
// System.Console.WriteLine(el);

// int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
}
return array;
}

void PrintArray(int[] array)
{
  for (int i=0;i<array.Length;i++)
  {
    Console.WriteLine($"a[{i}] = {array[i]}");
  }
}

int Examles(int [] array)
{
  int count = 0;
  for (int i=0;i<array.Length;i++)
  {
    if (array[i]>0)
    {
      count++;
    }
  }
  return count;
}

void Task_41()
{
int length=Prompt("Введите количество элементов >");
int[]array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше > 0 -> {Examles(array)}");

}

void Task_43()
{
  int co=0;
  int c=1;
  int x=0;
  int y=1;
  int l1=1;
  int l2=2;

  double[] linedata1=InputLineData(l1);
  double[] linedata2=InputLineData(l2);

if (ValidateLine(linedata1, linedata2))
  {
     double[] coord=FindCoords(linedata1, linedata2);
     Console.WriteLine($"Точка пересечений уравнений у={linedata1[co]}*x+{linedata1[c]} и у={linedata2[co]}*x+{linedata2[c]}");
     Console.WriteLine($"имеет координаты ({coord[x]}, {coord[y]})");
  }

double Prompt(string message)
{
   System.Console.WriteLine(message);
   string value = Console.ReadLine();
   double result = Convert.ToDouble(value);
   return result;
}

double[]  InputLineData(int numberOfLine)
  {
    double[] linedata =  new double[2];
    linedata [co]= Prompt($"Введите коэфициент для {numberOfLine} прямой >");
    linedata [c]= Prompt($"Введите коэфициент для {numberOfLine} прямой >");
    return linedata;
  }

double[] FindCoords(double[] linedata1,double[] linedata2)
{
  double[] coord = new double[2];
  coord[x] = (linedata1 [co] - linedata2[co])/(linedata2[c]-linedata1[c]);
  coord[y] = linedata1 [co]*coord[x]+linedata1 [co];
  return coord;
}
bool ValidateLine(double[] linedata1, double[] linedata2)
{
  if (linedata1 [co] == linedata2 [co])
  {
    if (linedata1 [c] == linedata2 [c])
    {
      Console.WriteLine("Прямые совпадают");
      return false;
    }
    else
    { Console.WriteLine("Прямые параллельны");
      return false;
      }
  }
  return true;
}

}







// string[] msg = Console.ReadLine().Split(" "); // string split метод

// foreach( string el in msg)
// System.Console.WriteLine(el);

//int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray()

