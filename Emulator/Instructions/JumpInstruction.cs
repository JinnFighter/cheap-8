namespace Emulator.Instructions
{
    internal class JumpInstruction : IInstruction
    {
        private readonly ushort _opcode;

        public JumpInstruction(ushort opcode)
        {
            _opcode = opcode;
        }

        public void Execute(Memory memory)
        {
            memory.SetProgramCounter(_opcode);
        }
    }
}
