Console.WriteLine("введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num1 = new int[size];
FillArrayRandomNumbers(num1);
Console.WriteLine("массив: ");
PrintArray(num1);
int sum = 0;
for (int num2 = 0; num2 < num1.Length; num2+=2)
    sum = sum + num1[num2];
    Console.WriteLine($"всего {num1.Length} числа сумма элементов cтоящих на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] num1)
{
    for(int num3 = 0; num3 < num1.Length; num3++)
        {
            num1[num3] = new Random().Next(1,10);
        }
}
void PrintArray(int[] num1)
{
    Console.Write("[ ");
    for(int num3 = 0; num3 < num1.Length; num3++)
        {
            Console.Write(num1[num3] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}