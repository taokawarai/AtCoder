using System;
class Program
{
	static void Main(string[] args)
	{
		// 文字列を入力
		string input = Console.ReadLine();
		// 文字列中の1の数をカウントして表示
		Console.WriteLine(CountChar(input, '1'));
	}

	public static int CountChar(string input, char c)
	{
		return input.Length - input.Replace(c.ToString(), "").Length;
	}
}