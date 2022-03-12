namespace Emulator.Instructions
{
    internal class SetIRegisterInstruction : IInstruction
    {
        private readonly ushort _registerValue;

        public SetIRegisterInstruction(ushort registerValue)
        {
            _registerValue = registerValue;
        }

        public void Execute(Memory memory)
        {
            memory.WriteIRegister(_registerValue);
        }
    }
}
