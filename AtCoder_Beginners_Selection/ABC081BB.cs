using System;
class Program
{
    public static void Main(string[] args)
    {
      // 整数の数とスペース区切りの整数入力
      string input1 = Console.ReadLine();
      string input2 = Console.ReadLine();
      string[] input22 = input2.Split(" ");
      int count = 0;
      bool flag = false;
      
      // 操作をカウント
      while(true)
      {
        foreach(var i in input22)
        {
          if (i % 2 == 0)
          {
            i = i / 2;
          }
          else
          {
            flag = true;
          }
        }
        if (flag)
        {
          break;
        }
        count++;
      }
      Console.WriteLine(count);
    }
}