using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Builder
{
    class CharacterInfoBuilder
    {
        public HeroInfo CreateHeroine(CharacterBuilder builder)
        {
            return builder
                .SetName("Brilliance of the sun")
                .SetHeight("175 cm")
                .SetStature("Athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Green")
                .SetClothes("Robes")
                .AddToInventory("Sword")
                .AddToInventory("Shield")
                .AddActing("Saved a people")
                .AddActing("Killed the lord of the evil kingdom")
                .Build();
        }

        public HeroInfo CreateEnemy(CharacterBuilder builder)
        {
            return ((EnemyBuilder)builder)
                .SetName("Ghost of the moon")
                .SetHeight("185 cm")
                .SetStature("Massive")
                .SetHairColor("Black")
                .SetEyeColor("Brown")
                .SetClothes("Armor")
                .AddToInventory("Dark Sword")
                .AddToInventory("Shield")
                .AddActing("Destruction of cities")
                .AddActing("Killed the king")
                .Build();
        }
    }
}
