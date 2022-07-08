Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int k = 2;
Console.WriteLine("Чётные числа от 0 до " + num + ":");
while(i < num)
{
    if(num % 2 == 0)
    {
      Console.WriteLine(k);
      k = k + 2;
      num = num - 2;
      
    }
    else
    {
        num = num - 1;
        i++;
    } 
}