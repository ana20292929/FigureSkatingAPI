using System;
namespace FigureSkatingAPI.Models
{
	public class Skater
	{
		public int SkaterId { get; set; }
		public string SkaterFirstName { get; set; }
		public string SkaterLastName { get; set; }
		public string SkaterCountry { get; set; }
		public int SkaterAge { get; set; }
	}
}