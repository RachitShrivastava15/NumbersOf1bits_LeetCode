namespace NumbersOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 00000000000000000000000000001011;
            var result = 0;
            var maxBits = 32;
            for (int bit = 0; bit < maxBits; ++bit) {
                if (((n >> bit) & 1) == 1) {
                    ++result;
                }
            }   
            Console.WriteLine(result);
        }
    }
}