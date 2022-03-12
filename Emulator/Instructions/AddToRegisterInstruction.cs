namespace Emulator.Instructions
{
    internal class AddToRegisterInstruction : IInstruction
    {
        private readonly RegistersContainer _registersContainer;
        private readonly int _index;
        private readonly byte _registerValue;

        public AddToRegisterInstruction(RegistersContainer registersContainer, int index, byte registerValue)
        {
            _registersContainer = registersContainer;
            _index = index;
            _registerValue = registerValue;
        }

        public void Execute()
        {
            _registersContainer.Vs[_index] += _registerValue;
        }
    }
}
