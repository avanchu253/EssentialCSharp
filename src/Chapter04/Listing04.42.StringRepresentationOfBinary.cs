namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_42
{
    #region INCLUDE
    public class BinaryConverter
    {
        public static void Main()
        {
            const int size = 64;
            ulong value;
            char bit;

            Console.Write("Enter an integer: ");
            // Use long.Parse() to support negative numbers
            // Assumes unchecked assignment to ulong
            // If ReadLine returns null, use "42" as default input
            value = (ulong)long.Parse(Console.ReadLine() ?? "42");

            // Set initial mask to 100....
            ulong mask = 1UL << size - 1;
            for(int count = 0; count < size; count++)
            {
                bit = ((mask & value) != 0) ? '1' : '0';
                Console.Write(bit);
                // Shift mask one location over to the right
                mask >>= 1;
            }
            Console.WriteLine();
        }
    }
    #endregion INCLUDE
}
