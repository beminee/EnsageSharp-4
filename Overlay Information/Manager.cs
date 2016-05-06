using System.Collections.Generic;
using System.Linq;
using Ensage;
using Ensage.Common.Objects;

namespace OverylayInformationV2
{
    internal class Manager
    {
        internal class HeroManager
        {
            public static List<Hero> GetHeroes()
            {
                return Members.Heroes;
            }

            public static List<Hero> GetViableHeroes()
            {
                return Members.Heroes.Where(x => x.IsVisible && x.IsAlive).ToList();
            }

            public static List<Hero> GetAllyViableHeroes()
            {
                return Members.AllyHeroes.Where(x => x.IsVisible && x.IsAlive).ToList();
            }

            public static List<Hero> GetEnemyViableHeroes()
            {
                return Members.EnemyHeroes.Where(x => x.IsVisible && x.IsAlive).ToList();
            }

            public static List<Item> GetItemList(Hero h)
            {
                return Members.ItemDictionary.Count == 0 ? new List<Item>() : Members.ItemDictionary[h.StoredName()];
            }

            public static List<Ability> GetAbilityList(Hero h)
            {
                return Members.AbilityDictionary.Count==0 ? new List<Ability>() : Members.AbilityDictionary[h.StoredName()];
            }

            public static List<Item> GetItemList(string s)
            {
                return Members.ItemDictionary.Count == 0 ? new List<Item>() : Members.ItemDictionary[s];
            }

            public static List<Ability> GetAbilityList(string s)
            {
                return Members.AbilityDictionary.Count == 0 ? new List<Ability>() : Members.AbilityDictionary[s];
            }
        }
        internal class PlayerManager
        {
            public static List<Player> GetPlayer()
            {
                return Members.Players;
            }
            public static List<Player> GetViablePlayers()
            {
                return Members.Players.Where(x => x.IsVisible && x.IsAlive).ToList();
            }
            public static List<Player> GetAllyViablePlayers()
            {
                return Members.AllyPlayers.Where(x => x.IsVisible && x.IsAlive).ToList();
            }
            public static List<Player> GetEnemyViablePlayers()
            {
                return Members.EnemyPlayers.Where(x => x.IsVisible && x.IsAlive).ToList();
            }
        }
        internal class BaseManager
        {
            public static List<Unit> GetBaseList()
            {
                return Members.BaseList.ToList();
            }
        }
    }
}