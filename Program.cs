
void ArrayOutput(string[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

void TransferArray(string[] array1, string[] array2, int minLength)
{
    int count=0;
    int lenghtElement = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        lenghtElement =  array1[i].Length;
        if (lenghtElement<=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }  
}

int CountingLenElements (string[] array,int minLength)
{
    int count = 0;
    int lenghtElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        lenghtElement =  array[i].Length;
        if (lenghtElement<=3)
        {
            count++;
        }
    }  
    return count;
}

string[] ArrayEntry(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = DataEntry("Введите значение: ");
    }
    return array;
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int quantity = Convert.ToInt32(DataEntry("Введите количество элементов массива: "));
string[]array = new string[quantity];
array = ArrayEntry(array);
int j = CountingLenElements(array,3);
string[] resultArray = new string[j];
TransferArray(array, resultArray, 3);

ArrayOutput(array);
ArrayOutput(resultArray);