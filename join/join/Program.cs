string join(string[] arr, string ayırıcı)
{
    string cavab = string.Empty;
	for (int i = 0; i < arr.Length; i++)
	{
		cavab = cavab + arr[i];
		if (i < arr.Length - 1)
		{
			cavab =cavab+ ayırıcı;
		}
	}
    return cavab;
}
