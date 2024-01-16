namespace GroupingOfPeople.Classes
{
   public static class RandomUnicNumber
{    
	static Random random = new Random();
	public static List<int> Generate(int max,int lenght)
	{
		List<int> Max= new List<int>();
        List<int> Number= new List<int>();
		for (int i = 0; i <= max; i++)
		{
			Max.Add(i);
		}

		List<int> randomAndUniqueNumbers = Max.GenerateRandom(lenght);
        for (int i = 0; i < randomAndUniqueNumbers.Count; i++)
        {
            Number.Add(randomAndUniqueNumbers[i]);
        }
        return(Number);
	}
}

public static class Extensions
{
	static Random random = new Random();
	public static List<T> GenerateRandom<T>(this List<T> collection, int count)
	{
		return collection.OrderBy(d => random.Next()).Take(count).ToList();
	}
}
}