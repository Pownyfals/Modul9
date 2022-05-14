using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
		//FPB
		Console.WriteLine("Hasil FPB : "+UtilityLibraries.StringLibrary.FPB(60,45));

		//KPK
		Console.WriteLine("Hasil KPK : " + UtilityLibraries.StringLibrary.KPK(12, 8));

		//Turunan
		int[] turunan = { 1, 4, -12, 9 };
		Console.WriteLine("Hasil Turunan : "+UtilityLibraries.StringLibrary.Turunan(turunan));

		//Integral
		int[] integral = { 4, 6, -12, 9 };
		Console.WriteLine("Hasil Integral : " + UtilityLibraries.StringLibrary.Integral(integral));

	

	}
}