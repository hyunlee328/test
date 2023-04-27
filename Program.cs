// See https://aka.ms/new-console-template for more information
public class Program
{

    private int to_square;
    public Program(int to_be_squared)
    {
        to_square = to_be_squared;
    }

    public int square()
    {
        return to_square * to_square;   
    }
}
    
