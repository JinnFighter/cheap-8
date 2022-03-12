namespace Emulator.Instructions
{
    internal class JumpInstruction : IInstruction
    {
        private readonly RegistersContainer _registers;
        private readonly ushort _opcode;

        public JumpInstruction(RegistersContainer registersContainer, ushort opcode)
        {
            _registers = registersContainer;
            _opcode = opcode;
        }

        public void Execute()
        {
            _registers.ProgramCounter = _opcode;
        }
    }
}
