extern alias UnityEngineCoreModule;

using System.Collections.Generic;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;

namespace HordeServer
{

    class SkillSystem
    {
        private static Dictionary<UnturnedPlayer, Skill> playersSkills = [];

        public static void ResetPlayersSkills()
        {
            playersSkills = [];

            foreach (UnturnedPlayer player in HordeServerPlugin.onlinePlayers)
            {
                playersSkills.Add(player, new());
            }
        }

        public static void ResetPlayerSkills(UnturnedPlayer player)
        {
            if (playersSkills.TryGetValue(player, out Skill _)) playersSkills[player] = new();
            else playersSkills.Add(player, new());
        }

        public static void RefreshPlayersSkills()
        {
            foreach (KeyValuePair<UnturnedPlayer, Skill> entry in playersSkills)
            {
                UnturnedPlayer player = entry.Key;
                player.SetSkillLevel(UnturnedSkill.Agriculture, entry.Value.Agriculture);
                player.SetSkillLevel(UnturnedSkill.Cardio, entry.Value.Cardio);
                player.SetSkillLevel(UnturnedSkill.Cooking, entry.Value.Cooking);
                player.SetSkillLevel(UnturnedSkill.Crafting, entry.Value.Crafting);
                player.SetSkillLevel(UnturnedSkill.Dexerity, entry.Value.Dexerity);
                player.SetSkillLevel(UnturnedSkill.Diving, entry.Value.Diving);
                player.SetSkillLevel(UnturnedSkill.Engineer, entry.Value.Engineer);
                player.SetSkillLevel(UnturnedSkill.Exercise, entry.Value.Exercise);
                player.SetSkillLevel(UnturnedSkill.Fishing, entry.Value.Fishing);
                player.SetSkillLevel(UnturnedSkill.Healing, entry.Value.Healing);
                player.SetSkillLevel(UnturnedSkill.Immunity, entry.Value.Immunity);
                player.SetSkillLevel(UnturnedSkill.Mechanic, entry.Value.Mechanic);
                player.SetSkillLevel(UnturnedSkill.Outdoors, entry.Value.Outdoors);
                player.SetSkillLevel(UnturnedSkill.Overkill, entry.Value.Overkill);
                player.SetSkillLevel(UnturnedSkill.Parkour, entry.Value.Parkour);
                player.SetSkillLevel(UnturnedSkill.Sharpshooter, entry.Value.Sharpshooter);
                player.SetSkillLevel(UnturnedSkill.Sneakybeaky, entry.Value.Sneakybeaky);
                player.SetSkillLevel(UnturnedSkill.Strength, entry.Value.Strength);
                player.SetSkillLevel(UnturnedSkill.Survival, entry.Value.Survival);
                player.SetSkillLevel(UnturnedSkill.Toughness, entry.Value.Toughness);
                player.SetSkillLevel(UnturnedSkill.Vitality, entry.Value.Vitality);
                player.SetSkillLevel(UnturnedSkill.Warmblooded, entry.Value.Warmblooded);
            }
        }

        public static void RefreshPlayerSkills(UnturnedPlayer player)
        {
            if (playersSkills.TryGetValue(player, out Skill skill))
            {
                player.SetSkillLevel(UnturnedSkill.Agriculture, skill.Agriculture);
                player.SetSkillLevel(UnturnedSkill.Cardio, skill.Cardio);
                player.SetSkillLevel(UnturnedSkill.Cooking, skill.Cooking);
                player.SetSkillLevel(UnturnedSkill.Crafting, skill.Crafting);
                player.SetSkillLevel(UnturnedSkill.Dexerity, skill.Dexerity);
                player.SetSkillLevel(UnturnedSkill.Diving, skill.Diving);
                player.SetSkillLevel(UnturnedSkill.Engineer, skill.Engineer);
                player.SetSkillLevel(UnturnedSkill.Exercise, skill.Exercise);
                player.SetSkillLevel(UnturnedSkill.Fishing, skill.Fishing);
                player.SetSkillLevel(UnturnedSkill.Healing, skill.Healing);
                player.SetSkillLevel(UnturnedSkill.Immunity, skill.Immunity);
                player.SetSkillLevel(UnturnedSkill.Mechanic, skill.Mechanic);
                player.SetSkillLevel(UnturnedSkill.Outdoors, skill.Outdoors);
                player.SetSkillLevel(UnturnedSkill.Overkill, skill.Overkill);
                player.SetSkillLevel(UnturnedSkill.Parkour, skill.Parkour);
                player.SetSkillLevel(UnturnedSkill.Sharpshooter, skill.Sharpshooter);
                player.SetSkillLevel(UnturnedSkill.Sneakybeaky, skill.Sneakybeaky);
                player.SetSkillLevel(UnturnedSkill.Strength, skill.Strength);
                player.SetSkillLevel(UnturnedSkill.Survival, skill.Survival);
                player.SetSkillLevel(UnturnedSkill.Toughness, skill.Toughness);
                player.SetSkillLevel(UnturnedSkill.Vitality, skill.Vitality);
                player.SetSkillLevel(UnturnedSkill.Warmblooded, skill.Warmblooded);
            }
        }

        public static void UpdatePlayerSkill(UnturnedPlayer player, string skillUpdated, byte level)
        {
            if (playersSkills.TryGetValue(player, out Skill skill))
            {
                switch (skillUpdated)
                {
                    case "Agriculture": skill.Agriculture = level; return;
                    case "Cardio": skill.Cardio = level; return;
                    case "Cooking": skill.Cooking = level; return;
                    case "Crafting": skill.Crafting = level; return;
                    case "Dexerity": skill.Dexerity = level; return;
                    case "Diving": skill.Diving = level; return;
                    case "Engineer": skill.Engineer = level; return;
                    case "Exercise": skill.Exercise = level; return;
                    case "Fishing": skill.Fishing = level; return;
                    case "Healing": skill.Healing = level; return;
                    case "Immunity": skill.Immunity = level; return;
                    case "Mechanic": skill.Mechanic = level; return;
                    case "Outdoors": skill.Outdoors = level; return;
                    case "Overkill": skill.Overkill = level; return;
                    case "Parkour": skill.Parkour = level; return;
                    case "Sharpshooter": skill.Sharpshooter = level; return;
                    case "Sneakybeaky": skill.Sneakybeaky = level; return;
                    case "Strength": skill.Strength = level; return;
                    case "Survival": skill.Survival = level; return;
                    case "Toughness": skill.Toughness = level; return;
                    case "Vitality": skill.Vitality = level; return;
                    case "Warmblooded": skill.Warmblooded = level; return;
                }

                playersSkills[player] = skill;
            }
        }

        public static void Disconnect(UnturnedPlayer player) => playersSkills.Remove(player);
    }
}