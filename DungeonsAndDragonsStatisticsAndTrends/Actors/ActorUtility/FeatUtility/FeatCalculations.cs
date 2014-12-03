using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{
    public enum Feats
    {
        Alert,
        Athlete,
        Actor,
        Charge,
        Crossbow_Expert,
        Defensive_Duelist,
        Dual_Wielder,
        Dungeon_Delver,
        Durable,
        Elemental_Adept,
        Grappeler,
        Great_Weapon_Master,
        Healer,
        Heavily_Armored,
        Heavy_Armor_Master,
        Inspiring_Leader,
        Keen_Mind,
        Lightly_Armored,
        Linguist,
        Lucky,
        Mage_Slayer,
        Magic_Initiate,
        Martial_Adept,
        Medium_Armor_Master,
        Mobile,
        Moderately_Armored,
        Mounted_Combatant,
        Observant,
        Polearm_Master,
        Resilient,
        Ritual_Caster,
        Savage_Attacker,
        Sentinel,
        Sharpshooter,
        Shield_Master,
        Skilled,
        Skulker,
        Spell_Sniper,
        Tavern_Brawler,
        Tough,
        War_Caster,
        Weapon_Master
    }

    public static class FeatCalculations
    {
        public static int GetID(Feats feat)
        {
            switch(feat)
            {
                case Feats.Alert:
                    return 1;
                case Feats.Athlete:
                    return 2;
                case Feats.Actor:
                    return 3;
                case Feats.Charge:
                    return 4;
                case Feats.Crossbow_Expert:
                    return 5;
                case Feats.Defensive_Duelist:
                    return 6;
                case Feats.Dual_Wielder:
                    return 7;                   
                case Feats.Dungeon_Delver:
                    return 8;
                case Feats.Durable:
                    return 9;
                case Feats.Elemental_Adept:
                    return 10;
                case Feats.Grappeler:
                    return 11;
                case Feats.Great_Weapon_Master:
                    return 12;
                case Feats.Healer:
                    return 13;
                case Feats.Heavily_Armored:
                    return 14;
                case Feats.Heavy_Armor_Master:
                    return 15;
                case Feats.Inspiring_Leader:
                    return 16;
                case Feats.Keen_Mind:
                    return 17;
                case Feats.Lightly_Armored:
                    return 18;
                case Feats.Linguist:
                    return 19;
                case Feats.Lucky:
                    return 20;
                case Feats.Mage_Slayer:
                    return 21;
                case Feats.Magic_Initiate:
                    return 22;
                case Feats.Martial_Adept:
                    return 23;
                case Feats.Medium_Armor_Master:
                    return 24;
                case Feats.Mobile:
                    return 25;
                case Feats.Moderately_Armored:
                    return 26;
                case Feats.Mounted_Combatant:
                    return 27;
                case Feats.Observant:
                    return 28;
                case Feats.Polearm_Master:
                    return 29;
                case Feats.Resilient:
                    return 30;
                case Feats.Ritual_Caster:
                    return 31;
                case Feats.Savage_Attacker:
                    return 32;
                case Feats.Sentinel:
                    return 33;
                case Feats.Sharpshooter:
                    return 34;
                case Feats.Shield_Master:
                    return 35;
                case Feats.Skilled:
                    return 36;
                case Feats.Skulker:
                    return 37;
                case Feats.Spell_Sniper:
                    return 38;
                case Feats.Tavern_Brawler:
                    return 39;
                case Feats.Tough:
                    return 40;
                case Feats.War_Caster:
                    return 41;
                case Feats.Weapon_Master:
                    return 42;
            }
            return 0;
        }

    }
}
