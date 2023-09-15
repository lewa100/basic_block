using System;
using System.Runtime.ExceptionServices;
using static System.Console;

string[] sampleFromArr(string[] arr){
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3){
            cnt++;
       } 
    }

    if (cnt == 0) {
        return Array.Empty<string>();
    }

    string[] tmpArr = new string[cnt];

    int iTmp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i].Length <= 3){
            tmpArr[iTmp] = arr[i];
            iTmp++;
       } 
    }
    return tmpArr;
}

string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

WriteLine(string.Join(",",sampleFromArr(arr1)));
WriteLine(string.Join(",",sampleFromArr(arr2)));
WriteLine(string.Join(",",sampleFromArr(arr3)));