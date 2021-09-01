namespace SCP939BreaksDoors.Events
{
    using Exiled.Events.EventArgs;
    using Exiled.API.Enums;
    using static Plugin;
    internal sealed class Handler
    {
        public void OnInteractingDoor(InteractingDoorEventArgs ev){
            if(!Instance.Config.Does939DestroyOpenedDoors && ev.Door.IsOpen && (ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989))
            {
                ev.IsAllowed = false;
            }
            else
            {
                if (Instance.Config.Does939DestroyCheckpoints)
                { 
                    if (ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989)
                    {
                        ev.Door.BreakDoor();
                        if(Instance.Config.Does939PryGates) 
                        {
                            ev.Door.TryPryOpen();
                        }
                    }
                }
                else if (!Instance.Config.Does939DestroyCheckpoints)
                {
                    if (ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989)
                    {
                        if (ev.Door.Type == DoorType.CheckpointEntrance || ev.Door.Type == DoorType.CheckpointLczA || ev.Door.Type == DoorType.CheckpointLczB)
                            return;
                        else if (ev.Player.Role == RoleType.Scp93953 || ev.Player.Role == RoleType.Scp93989)
                        {
                            ev.Door.BreakDoor();
                            if (Instance.Config.Does939PryGates)
                            {
                                ev.Door.TryPryOpen();
                            }
                        }
                    }
                }
            }
               
        }
    }
}
