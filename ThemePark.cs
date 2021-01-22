using System;
using System.Collections.Generic;

public class ThemePark {

    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;
    public List<ThemeParkRide> themeParkRides;
    public List<ThemeParkRestaurant> themeParkFood;

    private float TotalIncome {get;set;}
    private float TotalCost { get; set; }
    

    public ThemePark()
    {
        themeParkRides = new List<ThemeParkRide>();
        themeParkFood = new List<ThemeParkRestaurant>();
    }
 
    private void CalculateTotalRestaurantIncome() {
        TotalIncome += AverageDailyAttendance * ((ThemeParkRestaurant.totalIncome )/3);
    }

    private void CalculateTotalRestaurantCost() {
        TotalCost += AverageDailyAttendance * ((ThemeParkRestaurant.totalLoss)/3);
    }

    private void CalculateTotalRideIncome() {
        TotalIncome += TicketCost * AverageDailyAttendance;
    }

    private void CalculateTotalRideCost() {
        TotalCost += (float)(ThemeParkRide.TotalSpeed * .50 * 12);
    }

    private float CalculateProfit()  
    {  
        CalculateTotalRestaurantIncome();
        CalculateTotalRestaurantCost();
        CalculateTotalRideCost();
        CalculateTotalRideIncome();
        return TotalIncome - TotalCost;  
    }

    public void PrintRides() {

        Console.WriteLine(ThemeParkName + " contains the following rides: \n");

        foreach (ThemeParkRide ride in themeParkRides) {
           Console.WriteLine(ride.RideDetails());
        }
    }

    public void PrintRestaurants() {
        Console.WriteLine(ThemeParkName + " contains the following restaurants: \n");
        foreach ( ThemeParkRestaurant restaurant in themeParkFood) {
            Console.WriteLine(restaurant.RestaurantDetails());
        }
    }

    public void PrintProfit() {
        Console.WriteLine(ThemeParkName + " makes " + CalculateProfit() + " in income.");
    }
}