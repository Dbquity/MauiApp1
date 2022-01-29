namespace MauiLib1;
using ClassLibrary1;
// All the code in this file is included in all platforms.
public class Class1 {
#if ANDROID || IOS || MACCATALYST || WINDOWS
    static Class1() => PlatformClass1.Init();
#endif
    public static string Seed => PseudoRandomShifter.Seed;
    public static int Shift(int x) => PseudoRandomShifter.Shift(x);
}