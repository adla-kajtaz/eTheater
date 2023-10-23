using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services.Database
{
    public partial class ETheaterContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>().HasData(new Hall[]
             {
                new Hall()
                {
                    HallId = 1,
                    Name = "Mala sala",
                    TotalSeats = 100,
                    TotalRows = 10,
                    NumberOfSeatsPerRow = 10,
                    CreatedAt = DateTime.Now.Date,
                    ModifiedAt = null,
                    IsDeleted = false
                },
                new Hall()
                {
                    HallId = 2,
                    Name = "Velika sala",
                    TotalSeats = 150,
                    TotalRows = 10,
                    NumberOfSeatsPerRow = 15,
                    CreatedAt = DateTime.Now.Date,
                    ModifiedAt = null,
                    IsDeleted = false
                }
            });
        }
    }
}
