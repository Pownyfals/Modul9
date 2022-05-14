namespace UtilityLibraries;

public static class StringLibrary
{
    public static int FPB(int input1, int input2)
	{
        int sisa;
        sisa = input1 % input2;
        while(sisa != 0)
		{
            input1 = input2;
            input2 = sisa;
            sisa = input1 % input2;
		}
        return input2;
	}

    public static int KPK(int input1, int input2)
	{
        int hasil = input1;
        while(hasil%input2!=0){
            hasil = hasil + input1;
        }
        return hasil;
	}

    public static string Turunan(int[] persamaan)
    {
        string[] result = new string[persamaan.Length];

		for (int i = 0; i < persamaan.Length-1; i++)
		{
            if (persamaan[i] < 0)
            {
                result[i] = ((persamaan.Length - (i + 1)) * persamaan[i]) + "x" + (((persamaan.Length - (i + 2) == 0)) ? "" 
                    : ((persamaan.Length - (i + 2) == 1 )) ? "" : (persamaan.Length - (i + 2)));
            }
            else
            {
                if(i == 0)
				{
                    result[i] = ((persamaan.Length - (i + 1)) * persamaan[i]) + "x" + (persamaan.Length - (i + 2));
                }
				else
				{
                    result[i] = "+"+((persamaan.Length - (i + 1)) * persamaan[i]) + "x" + (((persamaan.Length - (i + 2) == 0)) ? "" 
                        : ((persamaan.Length - (i + 2) == 1)) ? "" : (persamaan.Length - (i + 2)));
                }
            }
		}

        string hasil = "";
        for(int j = 0; j < result.Length; j++)
		{
            if(result[j] != "0")
			{
                hasil += result[j];
            }
		}
        return hasil;
    }

    public static string Integral(int[] persamaan)
    {
        string[] result = new string[persamaan.Length];

        for (int i = 0; i <= persamaan.Length - 1; i++)
        {
            if (persamaan[i] < 0)
            {
                result[i] = (persamaan[i] / (persamaan.Length - i)) + "x" + (persamaan.Length - i);
            }
            else
            {
                if (i == 0)
                {
                    result[i] = (persamaan[i] / (persamaan.Length - i)) + "x" + (persamaan.Length - i);
                }
                else
                {
                    result[i] = "+"+(persamaan[i] / (persamaan.Length - i)) + "x" + (persamaan.Length - i);
                }
            }
        }
        string hasil = "";
        for (int j = 0; j < result.Length; j++)
        {
            if (result[j] != "0")
            {
                hasil += result[j];
            }
        }
        hasil += "+C";
        return hasil;
    }
}