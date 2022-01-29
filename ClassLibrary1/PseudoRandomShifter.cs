namespace ClassLibrary1;
public static class PseudoRandomShifter {
    static Random? prng;    
    static int amp;
    public static string? Seed { get; private set; }
    public static void Init(string seed, int amp = 100) {
        if (string.IsNullOrWhiteSpace(seed)) throw new ArgumentNullException(nameof(seed));
        if (amp < 1) throw new ArgumentOutOfRangeException(nameof(amp));
        PseudoRandomShifter.amp = amp;
        prng = new Random((Seed = seed).Select(s => (int)s).Sum());
    }
    public static int Shift(int number) => (prng?.Next(-amp, amp) ?? throw new InvalidOperationException()) + number;

}