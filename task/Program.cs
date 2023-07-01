using System;
using static System.Console;

Write("Кол-во строк: ");
int n = int.Parse(ReadLine());
string[] array = new string[n];
string[] array1 = GetArray(n);

string[] GetArray(int n){
    for (int i = 0; i < n; i++){
        Write($"Введите строку {i + 1}: ");
        array[i] = ReadLine();
    }
    return array;
}

string [] inArray(string [] array){
    int count = 0;
    for (int i = 0; i < n; i++){
        if (array[i].Length <= 3){
            count++;
        }
    }
    string [] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < n; i++){
        if (array[i].Length <= 3){
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++){
            WriteLine($"{inArray[i]} ");
    }
}

string [] array2 = inArray(array);
PrintArray(array2);