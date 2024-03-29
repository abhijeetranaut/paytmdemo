using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PaytmApp.BoundedContext.SqlContext;
using PaytmApp.Models.Main;
using PaytmApp.Models;
using PaytmApp.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace PaytmApp.BoundedContext.Main
{
    public class BookingMasterContext : BaseBoundedContext, IBookingMasterContext
    {
        public BookingMasterContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

        #region DbSets
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightBooking> FlightBookings { get; set; }
        public DbSet<FlightAvailableSeat> FlightAvailableSeats { get; set; }
        public DbSet<FlightTravellerDetail> FlightTravellerDetails { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusBooking> BusBookings { get; set; }
        public DbSet<BusAvailableSeat> BusAvailableSeats { get; set; }
        public DbSet<BusTravellerDetail> BusTravellerDetails { get; set; }
        #endregion DbSets

    }


    public interface IBookingMasterContext : IDbContext
    {
    }
}

