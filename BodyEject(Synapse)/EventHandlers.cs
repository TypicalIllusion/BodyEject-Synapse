using Synapse;
using Synapse.Api;
using static RoomInformation;

namespace BodyEject_Synapse_
{
    class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Player.PlayerDeathEvent += Player_PlayerDeathEvent;
        }

        private void Player_PlayerDeathEvent(Synapse.Api.Events.SynapseEventArguments.PlayerDeathEventArgs ev)
        {
            if (ev.HitInfo.GetDamageType() == DamageTypes.Pocket)
            {
                if (Plugin.Config.RemoveItems)
                {
                    ev.Victim.Inventory.Clear();
                }
                else
                {
                    ev.Victim.Inventory.DropAll();
                }
                foreach (Room room in Map.Get.Rooms)
                {
                    System.Random rnd = new System.Random();
                    RoomType[] _roomTypes = { RoomType.HCZ_106, RoomType.HCZ_939, RoomType.HCZ_CURVE, RoomType.HCZ_3_WAY_INTERSECTION };
                    int _value = rnd.Next(0, _roomTypes.Length);
                    if (room.RoomType == _roomTypes[_value])
                    {
                        float posx = room.Position.x;
                        float posy = room.Position.y + 2;
                        float posz = room.Position.z;
                        ev.Victim.Position = new UnityEngine.Vector3(posx, posy, posz);
                    }
                }
            }
        }
    }
}
