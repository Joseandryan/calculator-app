class Calcuator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		console.writeLine("hasil penambahan: {0} + {1} ={2}", a, b, penambahan(a,b));
		console.writeLine("hasil penambahan: {0} - {1} ={2}", a, b, pengurangan(a,b));
		
		console.writeLine("\ntekan sembarang key untuk keluar");
		console.ReadKey();
	}
	
	static int penambahan(int a, int b)
	{
		return a + b;
	}
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
}	