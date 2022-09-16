// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма.
using static System.Console;
Clear();
string[] array = {"Hello","2","World",":)"};
string[] NewArray=GetNewArray(array);
PrintArray(NewArray);

string[] GetNewArray(string[] array)  
{
    int newLength=0;
    for (int i = 0; i < array.Length; i++) //посчитаем кол-во элементов длиной менее 3
    {
        if (array[i].Length<=3) newLength++;
    }
    string[] newAr=new string[newLength];
    int j=0;
    for (int i = 0; i < array.Length; i++)  //соберем новый массив
    {
        if (array[i].Length<=3) 
        {
            newAr[j]=array[i];
            j++;
        }
    }
    return newAr;
}

void PrintArray(string[] ar)
{
    int k= ar.Length;
    string quote = "\"";
    Write("[");
    for (int i = 0; i < ar.Length; i++)
    {
        Write($"{quote}{ar[i]}{quote}");
        if(i!=ar.Length-1) Write(", ");
    }
    Write("]");
}