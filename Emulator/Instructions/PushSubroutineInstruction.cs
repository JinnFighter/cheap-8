namespace Emulator.Instructions
{
    internal class PushSubroutineInstruction : IInstruction
    {
        private readonly AddressStack _addressStack;
        private readonly RegistersContainer _registersContainer;
        private readonly ushort _opcode;

        public PushSubroutineInstruction(AddressStack addressStack, RegistersContainer registersContainer, ushort opcode)
        {
            _addressStack = addressStack;
            _registersContainer = registersContainer;
            _opcode = opcode;
        }

        public void Execute()
        {
            _addressStack.PushAddress(_registersContainer.GetProgramCounter());
            _registersContainer.SetProgramCounter(_opcode);
        }
    }
}
