namespace Emulator.Instructions
{
    internal class AddToRegisterInstruction : IInstruction
    {
        private readonly int _index;
        private readonly byte _registerValue;

        public AddToRegisterInstruction(int index, byte registerValue)
        {
            _index = index;
            _registerValue = registerValue;
        }

        public void Execute(Memory memory)
        {
            memory.Vs[_index] += _registerValue;
        }
    }
}
