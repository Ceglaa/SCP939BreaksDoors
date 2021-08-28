namespace SCP939BreaksDoors
{
    using Exiled.Events.EventArgs;
    internal sealed class Handler
    {
        public void OnInteractingDoor(InteractingDoorEventArgs ev){
            if(ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989){
                ev.Door.BreakDoor();
            }
        }
    }
}
