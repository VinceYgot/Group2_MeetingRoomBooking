
using System.ComponentModel.DataAnnotations;

namespace MeetingRoomBooking.WebApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public User BookingUser { get; set; }
        public Room BookingRoom { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DateTime { get; set; }
        public int Duration { get; set; }

    }
}
