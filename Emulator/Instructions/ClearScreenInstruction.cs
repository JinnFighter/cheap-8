namespace Emulator.Instructions
{
    internal class ClearScreenInstruction : IInstruction
    {
        private readonly Display _display;

        public ClearScreenInstruction(Display display)
        {
            _display = display;
        }

        public void Execute(Memory memory)
        {
            for(var i = 0; i < _display.Width; i++)
            {
                for (var j = 0; j < _display.Height; j++)
                {
                    _display.Pixels[i, j] = false;
                }
            }
        }
    }
}
