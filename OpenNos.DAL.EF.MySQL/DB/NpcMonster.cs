//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class NpcMonster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NpcMonster()
        {
            this.mapnpc = new HashSet<MapNpc>();
            this.mapmonster = new HashSet<MapMonster>();
            this.drop = new HashSet<Drop>();
            this.npcmonsterskill = new HashSet<NpcMonsterSkill>();
        }
    
        public short NpcMonsterVNum { get; set; }
        public string Name { get; set; }
        public byte Speed { get; set; }
        public byte Level { get; set; }
        public byte AttackClass { get; set; }
        public byte AttackUpgrade { get; set; }
        public short DamageMinimum { get; set; }
        public short DamageMaximum { get; set; }
        public short Concentrate { get; set; }
        public byte Element { get; set; }
        public short ElementRate { get; set; }
        public short CriticalRate { get; set; }
        public byte CriticalLuckRate { get; set; }
        public short CloseDefence { get; set; }
        public short DefenceDodge { get; set; }
        public short MagicDefence { get; set; }
        public byte DefenceUpgrade { get; set; }
        public short DistanceDefence { get; set; }
        public short DistanceDefenceDodge { get; set; }
        public sbyte FireResistance { get; set; }
        public sbyte WaterResistance { get; set; }
        public sbyte LightResistance { get; set; }
        public sbyte DarkResistance { get; set; }
        public int MaxHP { get; set; }
        public int MaxMP { get; set; }
        public int RespawnTime { get; set; }
        public int XP { get; set; }
        public int JobXP { get; set; }
        public bool IsHostile { get; set; }
        public short BasicSkill { get; set; }
        public byte BasicRange { get; set; }
        public byte BasicArea { get; set; }
        public short BasicCooldown { get; set; }
        public byte HeroLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapNpc> mapnpc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapMonster> mapmonster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drop> drop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NpcMonsterSkill> npcmonsterskill { get; set; }
    }
}
