namespace SCP939BreaksDoors
{
    using Exiled.API.Interfaces;
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Does939DestroyCheckpoints { get; private set; } = false;
    }
}
