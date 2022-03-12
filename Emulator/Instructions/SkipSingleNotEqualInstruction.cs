namespace Emulator.Instructions
{
    internal class SkipSingleNotEqualInstruction
    {
        private readonly RegistersContainer _container;
        private readonly byte _opcode;
        private readonly int _index;

        public SkipSingleNotEqualInstruction(RegistersContainer container, byte opcode, int index)
        {
            _container = container;
            _opcode = opcode;
            _index = index;
        }

        public void Execute()
        {
            if (_container.Vs[_index] != _opcode)
            {
                _container.IncreaseCounterAddress();
            }
        }
    }
}
