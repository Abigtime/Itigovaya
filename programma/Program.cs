System.Console.Write("Введите количество элементов: ");
int size = System.Convert.ToInt32(System.Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.Write($"Введите {i+1}-й элемент: "); 
    string element = System.Console.ReadLine(); 
    arrayStrings[i] = element;
}
string[] arrayElements = new string[size];
int leng = 3;
int position = 0;

for (int j = 0; j < size; j++) 
{
    if (arrayStrings[j].Length <= leng) 
    {
        arrayElements[position] = arrayStrings[j];
        position++;
    }
}
System.Console.WriteLine();
PrintArray(arrayElements);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Элементы соответствующие требованиям массива [{array[i]}]");
    }   
     
    System.Console.WriteLine();
}

