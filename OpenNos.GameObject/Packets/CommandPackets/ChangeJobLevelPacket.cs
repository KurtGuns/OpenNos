﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject
{
    [PacketHeader("$JLvl", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class ChangeJobLevelPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte JobLevel { get; set; }

        [PacketIndex(1)]

        public string Name { get; set; }

        #endregion
    }
}