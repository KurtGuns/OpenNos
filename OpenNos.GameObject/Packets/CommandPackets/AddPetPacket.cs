﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject
{
    [PacketHeader("$AddPet", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class AddPetPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short MonsterVNum { get; set; }

        [PacketIndex(1)]
        public byte Level { get; set; }

        public override string ToString()
        {
            return $"AddPet Command MonsterVNum: {MonsterVNum} Level: {Level}";
        }

        #endregion
    }
}