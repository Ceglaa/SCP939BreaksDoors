namespace SCP939BreaksDoors
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using System;

    public class Plugin : Plugin<Config>
    {
        private static readonly Plugin Singleton = new Plugin();
        private Handler handler;
        private Plugin(){}
        public static Plugin Instance => Singleton;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public override string Author { get; } = "Cegla";
        public override string Name { get; } = "SCP939BreaksDoors";
        public override string Prefix { get; } = "SCP939BD";
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        public override Version Version { get; } = new Version(1, 0, 0);

        public override void OnEnabled(){
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled(){
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents(){
            handler = new Handler();
            Exiled.Events.Handlers.Player.InteractingDoor += handler.OnInteractingDoor;
        }
        private void UnregisterEvents(){
            Exiled.Events.Handlers.Player.InteractingDoor -= handler.OnInteractingDoor;
            handler = null;
        }
    }
}