// Alex Bell

namespace CSharpResearch;
public abstract class AbstractComputerType: IComparable {

    private static int _counter;
    private string _manufacturer;
    private double _cpuClock;
    private short _ram;			
    private int _hardDrive;

    protected AbstractComputerType() {
        _manufacturer = "";
        _cpuClock = 0.0;
        _ram = 0;
        _hardDrive = 0;
        _counter++;
    }
    protected string GetManufacturer() {
        return _manufacturer;
    }

    public double GetCpu() {
        return _cpuClock;
    }
    
    public short GetRam() {
        return _ram;
    }
    public int GetHardDrive() {
        return _hardDrive;
    }	
    protected void SetParams(string aManufacturer, double aCpu, short aRam, int aHardDrive) {
        _manufacturer = aManufacturer;
        _cpuClock = aCpu;
        _ram = aRam;
        _hardDrive = aHardDrive;
    }
    public static int GetCounter() {
        return _counter;
    }
    
    
    public override string ToString() {
        return "ComputerType [manufacturer=" + _manufacturer + ", CPU=" + _cpuClock + ", RAM=" + _ram + ", hardDrive="
               + _hardDrive + "]";
    }
    
    public int CompareTo(object? other) {
        if(other == null) {
            throw new ArgumentException("other was null");
        }
        
        var theOther = (AbstractComputerType) other;
        if (Math.Abs(_cpuClock - theOther._cpuClock) < 0.000001) {
            return 0;
        }
            
        if (_cpuClock < theOther._cpuClock) {
            return -1;
        }
        return 1;
    }
}