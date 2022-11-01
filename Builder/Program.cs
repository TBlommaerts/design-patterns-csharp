using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
		{
			Movie movie1 = new Movie("Iron Man", Genre.ACTION, "Jon Favreau", new DateTime(2008, 5, 2), "Iron Man tells the story of Tony Stark, "
			+ "a billionaire industrialist and genius inventor who is kidnapped and forced to build a devastating weapon. "
			+ "Instead, using his intelligence and ingenuity, Tony builds a high-tech suit of armor and escapes captivity.");

			Movie movie2 = new Movie("The Simpsons Movie", Genre.COMEDY, "David Silverman");
			Movie movie3 = new Movie("Harry Potter and the Philosopher's Stone");

			// Telescoping constructors don't prevent the need to pass null values in some cases:
			Movie movie4 = new Movie("The Shawshank Redemption", Genre.DRAMA, null, new DateTime(1994, 9, 23));
			Movie movie5 = new Movie("The Hobbit", null, "Peter Jackson");
		}
	}
}
