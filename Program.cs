Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string [size];
string [] result = new string[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
}
Console.Write("[" + string.Join (" ",array)+"]");
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        result[i] = array[i];
    } 
}
Console.WriteLine();
Console.Write("[" + string.Join (" ",result)+"]");
