namespace Emulator.Instructions
{
    internal class PushSubroutineInstruction : IInstruction
    {
        private readonly AddressStack _addressStack;
        private readonly ushort _opcode;

        public PushSubroutineInstruction(AddressStack addressStack, ushort opcode)
        {
            _addressStack = addressStack;
            _opcode = opcode;
        }

        public void Execute(Memory memory)
        {
            _addressStack.PushAddress(memory.GetProgramCounter());
            memory.SetProgramCounter(_opcode);
        }
    }
}
