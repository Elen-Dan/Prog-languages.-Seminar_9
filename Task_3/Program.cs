/*
Задача 3. 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

Console.Clear();
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Int32 FncAckermann = Ack(m, n);
Console.WriteLine($"Функция Аккермана = {FncAckermann} ");

Int32 Ack(Int32 m, Int32 n)
{
  if (m == 0) 
    {
        return n + 1;
    }
                else if (n == 0)
            {         
                return Ack(m - 1, 1);
            }
                else
                    {
                        return Ack(m - 1, Ack(m, n - 1));
                    } 
    
}
