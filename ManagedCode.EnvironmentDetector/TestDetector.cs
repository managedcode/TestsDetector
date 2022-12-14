namespace ManagedCode.EnvironmentDetector;

public static class TestDetector
{
    static TestDetector()
    {
        IsInTest = MSTestDetector.IsInTest || NUnitDetector.IsInTest || XUnitDetector.IsInTest;
    }

    public static bool IsInTest { get; }
}