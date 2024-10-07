using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeetingRoomBooking.WebApp.Models;

namespace MeetingRoomBooking.WebApp.Data
{
    public class MeetingRoomBookingWebAppContext : DbContext
    {
        public MeetingRoomBookingWebAppContext (DbContextOptions<MeetingRoomBookingWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MeetingRoomBooking.WebApp.Models.User> User { get; set; } = default!;
    }
}
