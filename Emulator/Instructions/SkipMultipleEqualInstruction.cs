namespace Emulator.Instructions
{
    internal class SkipMultipleEqualInstruction : IInstruction
    {
        private readonly RegistersContainer _container;
        private readonly int _xIndex;
        private readonly int _yIndex;

        public SkipMultipleEqualInstruction(RegistersContainer container, int xIndex, int yIndex)
        {
            _container = container;
            _xIndex = xIndex;
            _yIndex = yIndex;
        }

        public void Execute()
        {
            if (_container.Vs[_xIndex] == _container.Vs[_yIndex])
            {
                _container.IncreaseCounterAddress();
            }
        }
    }
}
