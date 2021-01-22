public class ThemeParkRestaurant {

    public string name;
    public float income;
    public float loss;
    public static float totalIncome;
    public static float totalLoss;
    public ThemeParkRestaurant(string Name, float Income, float Loss)
    {
         this.name=Name;
         this.income=Income;
         this.loss=Loss;
         totalIncome += Income;
         totalLoss += Loss;
  
    }

    public string RestaurantDetails(){
        return this.name + " which generates " + this.income + " in income and costs " +  this.loss+ "\n";
    }


}