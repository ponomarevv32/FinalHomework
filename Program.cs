//Написать программу, которая из имеющегося массива строк формирует новый массив из строк
//, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
        array[i] = Console.ReadLine();
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ,");
    Console.WriteLine();
}    

void CrerateNewArray(string[]array,int size)
{
    string[] num = new string[size];
    for (int i = 0; i < num.Length; i++)
    {
       if (array[i].Length <= 3)
       num[i] = array[i];
        Console.Write(num[i]+',') ;
    }
}
Console.WriteLine("Введите размер массива");
int size=Convert.ToInt32(Console.ReadLine());
string[] StringArray = CreateArray(size);
ShowArray(StringArray);
CrerateNewArray(StringArray,size);

