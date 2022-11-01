using System;

namespace Builder
{
    class Movie
    {
		private string Title { get; set; }
		private Genre? Genre { get; set; }
		private string Director { get; set; }
		private DateTime? ReleaseDate { get; set; }
		private string Description { get; set; }

		public Movie(string title): this(title, null)
		{			
		}

		public Movie(string title, Genre? genre): this(title, genre, null)
		{
		}

		public Movie(string title, Genre? genre, string director): this(title, genre, director, null)
		{
		}

		public Movie(string title, Genre? genre, string director, DateTime? releaseDate): this(title, genre, director, null, null)
		{
		}

		public Movie(string title, Genre? genre, string director, DateTime? releaseDate, string description)
		{
			this.Title = title;
			this.Genre = genre;
			this.Director = director;
			this.ReleaseDate = releaseDate;
			this.Description = description;
		}

		// We can not create a constructor for every scenario, below code would lead to errors because of a duplicate method signature.
		//	public Movie(String title, String director);
		//	public Movie(String title, String description);
	}
}
