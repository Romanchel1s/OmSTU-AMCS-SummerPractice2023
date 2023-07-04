namespace spacebattle;
public class Spacebattle
{
    public static double[] FindPosition(double[] position, double[] speed, bool can_move)
    {
        var road = new double[2];
        if(can_move)
        {
            try
            {
                road[0] = position[0] + speed[0];
                road[1] = position[1] + speed[1];
            }   
            catch
            {
                throw new System.Exception();
            }
        }
        else throw new System.Exception();
        return road; 
    }
}