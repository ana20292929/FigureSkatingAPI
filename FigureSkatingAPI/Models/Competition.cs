using System;
namespace FigureSkatingAPI.Models
{
	public class Competition
	{
        public int CompetitionId { get; set; }
		public string CompetitionName { get; set; }
		public string CompetitionLocation { get; set; }
		public DateTime CompetitionStartDate { get; set; }
		public DateTime CompetitionEndDate { get; set; }
		public int SkaterID1 { get; set; }
        public int SkaterID2 { get; set; }
        public int SkaterID3 { get; set; }
        public int SkaterID4 { get; set; }
        public int SkaterID5 { get; set; }
        public int SkaterID6 { get; set; }
        public int SkaterID7 { get; set; }
        public int SkaterID8 { get; set; }
        public int SkaterID9 { get; set; }
        public int SkaterID10 { get; set; }
    }
}

