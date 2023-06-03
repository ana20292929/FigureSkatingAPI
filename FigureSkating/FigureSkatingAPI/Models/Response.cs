using System;
namespace FigureSkatingAPI.Models
{
	public class Response
	{
		public int statusCode { get; set; }
		public string statusDescription { get; set; }
		public List<Skater> SkatersList { get; set; } = new(); //list for Skaters
		public List<Competition> CompetitionsList { get; set; } = new(); //list for Competitions
	}
}

