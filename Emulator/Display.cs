namespace Emulator
{
    internal class Display
    {
        public int Width { get; }
        public int Height { get; }
        public bool[,] Pixels { get; }

        public Display()
        {
            Width = 64;
            Height = 32;
            Pixels = new bool[Width, Height];
        }
    }
}
