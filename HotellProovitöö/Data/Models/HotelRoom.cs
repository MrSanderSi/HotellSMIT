using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HotellProovitöö.Data.Models
{
	public class HotelRoom
	{
		int Id { get; set; }

		public int RoomNumber { get; set; }

		[Range(SystemConstants.MinAmountOfBeds, SystemConstants.MaxAmountOfBeds)]
		public int BedCount { get; set; }

		public decimal Price { get; set; }

		public bool Enabled { get; set; }
	}
}
