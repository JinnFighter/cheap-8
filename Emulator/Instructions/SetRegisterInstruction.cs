namespace Emulator.Instructions
{
    internal class SetRegisterInstruction : IInstruction
    {
        private readonly int _index;
        private readonly byte _registerValue;

        public SetRegisterInstruction(int index, byte registerValue)
        {
            _index = index;
            _registerValue = registerValue;
        }

        public void Execute(Memory memory)
        {
            memory.Vs[_index] = _registerValue;
        }
    }
}
