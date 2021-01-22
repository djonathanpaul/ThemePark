public class ThemeParkRide {

    public string name;
    public float speed;

    public static float ? TotalSpeed=0;


    public ThemeParkRide(string Name, float Speed)
    {
         this.name=Name;
         this.speed=Speed;
         TotalSpeed += Speed;
        
    }

    public string RideDetails(){
        return this.name+ " which goes "+ this.speed + "\n";
    }


}