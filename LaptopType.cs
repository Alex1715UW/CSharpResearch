// Alex Bell

namespace CSharpResearch;
public class LaptopType: AbstractComputerType {
    private double _screenSize;

    public int BatteryLife { get; private set; }

    public double GetScreenSize() {
        return _screenSize;
    }
    public double GetScreenSize(bool innerDimension) {
        if (innerDimension)
            return _screenSize - 1;
        return _screenSize;
    }
    public new string GetManufacturer() {
        return base.GetManufacturer() + " Laptop";
    }
    public void SetParams(string aManufacturer, double aCpu, short aRam, int aHardDrive, int aBatteryLife, double aScreenSize) {
        base.SetParams(aManufacturer, aCpu, aRam, aHardDrive); 
        BatteryLife = aBatteryLife;
        _screenSize = aScreenSize;
    }
    
    public override string ToString() {
        return base.ToString() + " LaptopType [batteryLife=" + BatteryLife + ", screenSize=" + _screenSize + "]";
    }
    
}