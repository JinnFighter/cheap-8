namespace Emulator.Instructions
{
    internal class PopSubroutineInstruction : IInstruction
    {
        private readonly AddressStack _addressStack;

        public PopSubroutineInstruction(AddressStack addressStack)
        {
            _addressStack = addressStack;
        }

        public void Execute(Memory memory)
        {
            memory.SetProgramCounter(_addressStack.PopAddress());
        }
    }
}
