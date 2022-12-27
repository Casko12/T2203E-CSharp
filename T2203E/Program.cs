using T2203E_CSharp.session1;
using T2203E_CSharp.session2;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            throw new Exception("Y bang 0 kia");
            y++;
            float z = x / y;
            Console.WriteLine("z ="+z);
        }catch(Exception e) 
        {
            Console.WriteLine(e.Message);    
        }
        finally
        {

        }
    }
}