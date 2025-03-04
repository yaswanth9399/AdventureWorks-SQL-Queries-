using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr ={1,2,3,4,5,6,7,8,9,0};
        int[] newarr = new int[arr.Length];
        for(int i=0;i<arr.Length;i++){
            newarr[i] = arr[i];
        }
         for(int i=0;i<arr.Length;i++){
        Console.WriteLine ("Original array:"+arr[i]);
        }
        for(int i=0;i<arr.Length;i++){
        Console.WriteLine ("New array :" +newarr[i]);
        }
    }
}
