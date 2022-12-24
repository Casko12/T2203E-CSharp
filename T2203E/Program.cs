using T2203E_CSharp.session1;
public class Program
{
    static void Main(string[] args)
    {
        Human h = new Human();
        h.Run;
        Human dvt = new Human();
        dvt.Run;
        h.Age = 19;
        h.Email = "abc@xyz";
        Console.WriteLine(h.Age);
        Student s = new Student();
        s[0] = "09011111";
        s[1] = "092888888";
        List<string> ls = new List<string>();
        ls.Add("hello");
        ls.Add("world!");

        for (int i = 0; i <ls.Count; i++)
        {
            Console.WriteLine(ls[i]);
        }
        foreach(string l in ls)
        {
            Console.WriteLine(l);
        }

    }
}