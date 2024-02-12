/*Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/

Console.Clear();
int m = 2;
int n = 5;
int res = 0; 
FindAllBetween(m++, n);

int FindAllBetween(int m, int n) {
      if (m < n) {
            m++;
            if (m == n) {
                System.Environment.Exit(0);
            }
            res = m;
            Console.Write(res + ", ");
      }
      return FindAllBetween(m++, n);
}


/*Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/

Console.Clear();
int m = 2;
int n = 3;
Console.Write(Convert.ToString(AckFunc(n, m)));

int AckFunc(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckFunc(n - 1, 1);
    else
        return AckFunc(n - 1, AckFunc(n, m - 1));
}


/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

Console.Clear();
int[] arr = new int[] {2, 6, 9, 7, 8, 10, 569};
PrintArray(arr);

void PrintArray(int[] array, int first = 0)
{
    if(first != array.Length) {
        PrintArray(array, first + 1);
        Console.Write($"{array[first]}\t");
    }
}