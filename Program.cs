using System;
using System.Collections.Generic;
using System.Linq;
namespace SOLIDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemePark warwarLand = new ThemePark();

            warwarLand.TicketCost = 90;
            warwarLand.AverageDailyAttendance = 50000;         
            warwarLand.ThemeParkName = "War War Land";
            
            warwarLand.themeParkRides.Add( new ThemeParkRide("Haunted Mansion", 5)) ;  
            warwarLand.themeParkRides.Add( new ThemeParkRide("Teacups", 7)) ; 
            warwarLand.themeParkRides.Add( new ThemeParkRide("Pirates of the Caribean", 5)) ; 

            
            
            warwarLand.PrintRides();

            warwarLand.themeParkFood.Add(new ThemeParkRestaurant("Pizzasaurus Rex",5,3));
            warwarLand.themeParkFood.Add(new ThemeParkRestaurant("Planet Mars Burgers",8,7.5F));
            warwarLand.themeParkFood.Add(new ThemeParkRestaurant("Salads Undersea",3,6));

            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
