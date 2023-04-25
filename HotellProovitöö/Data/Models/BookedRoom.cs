namespace HotellProovitöö.Data.Models
{
	public class BookedRoom
	{
		Guid Id { get; set; }

		public HotelRoom Room { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public DateTime CutoffTime => StartDate.AddDays(- SystemConstants.CutoffTimeInDays);

		public decimal TotalPrice { get; set; }
	}
}
