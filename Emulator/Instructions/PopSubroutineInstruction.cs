namespace Emulator.Instructions
{
    internal class PopSubroutineInstruction : IInstruction
    {
        private readonly AddressStack _addressStack;
        private readonly RegistersContainer _registersContainer;

        public PopSubroutineInstruction(AddressStack addressStack, RegistersContainer registersContainer)
        {
            _addressStack = addressStack;
            _registersContainer = registersContainer;
        }

        public void Execute()
        {
            _registersContainer.SetProgramCounter(_addressStack.PopAddress());
        }
    }
}
