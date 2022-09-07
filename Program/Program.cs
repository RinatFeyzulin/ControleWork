Console.WriteLine("Введите массив строк");
string consolеRead = Console.ReadLine();

string [] overwritingArray(string str)
{
    string[] firstArray  = str.Split(' ');
    int i =0;
    foreach (var item in firstArray)
    {
        if(item.Length<=3) i++; 
    }
    string[] arraySecond = new string [i];
    int k=0;
    foreach (var item in firstArray)
    {
        if(item.Length<=3)
        {
            arraySecond[k] = item;
            k++;
        } 
    }
    return arraySecond;
}

void Print(string[]arr)
{
}

if(consolеRead == "")Console.WriteLine("Пустая строка");
else Print(overwritingArray(consolеRead));