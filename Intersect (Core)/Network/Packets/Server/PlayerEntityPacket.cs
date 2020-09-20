﻿using System;

using Intersect.Enums;

namespace Intersect.Network.Packets.Server
{

    public class PlayerEntityPacket : EntityPacket
    {

        public int AccessLevel { get; set; }

        public Gender Gender { get; set; }
        public Factions Faction { get; set; } = Factions.Neutral;
        public Guid ClassId { get; set; }

        public EquipmentPacket Equipment { get; set; }

        public CustomSpriteLayersPacket CustomSpriteLayers { get; set; }

        public long CombatTimeRemaining { get; set; }

    }

}
