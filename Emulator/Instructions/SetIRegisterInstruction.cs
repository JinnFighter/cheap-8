namespace Emulator.Instructions
{
    internal class SetIRegisterInstruction : IInstruction
    {
        private readonly RegistersContainer _registersContainer;
        private readonly ushort _registerValue;

        public SetIRegisterInstruction(RegistersContainer registersContainer, ushort registerValue)
        {
            _registersContainer = registersContainer;
            _registerValue = registerValue;
        }


        public void Execute()
        {
            _registersContainer.WriteIRegister(_registerValue);
        }
    }
}
