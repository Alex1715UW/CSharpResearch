// Alex Bell

namespace CSharpResearch;
public static class Driver {
    public static void Main(string[] theArgs) {
        		
        var laptop1 = new LaptopType();
        var laptop2 = new LaptopType();
        var laptop3 = new LaptopType();
		
        laptop1.SetParams("Lenovo", 2.80,  16, 475, 18, 13.3);
        laptop2.SetParams("MacBook Air", 3.49,  16, 100, 24, 15.0);
		
        TestAllGetters(laptop1);
		
        Console.WriteLine(laptop1);
        Console.WriteLine(laptop2);
        Console.WriteLine(laptop3);
        Console.WriteLine(laptop1.CompareTo(laptop3));
        Console.WriteLine(laptop1.CompareTo(laptop2));
        Console.WriteLine(laptop1.CompareTo(laptop1));
    }
    private static void TestAllGetters(LaptopType laptop) {
        Console.WriteLine(laptop.GetManufacturer());
        Console.WriteLine(laptop.GetCpu());
        Console.WriteLine(laptop.GetRam());
        Console.WriteLine(laptop.GetHardDrive());
        Console.WriteLine(laptop.BatteryLife);
        Console.WriteLine(laptop.GetScreenSize());
        Console.WriteLine(laptop.GetScreenSize(true));	
		
        Console.WriteLine(AbstractComputerType.GetCounter());
    }
}