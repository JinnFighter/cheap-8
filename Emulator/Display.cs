namespace Emulator
{
    internal class Display
    {
        public bool[,] Pixels { get; }

        public Display()
        {
            Pixels = new bool[64, 32];
        }
    }
}
