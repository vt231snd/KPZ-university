using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Builder
{
    public interface CharacterBuilder
    {
        CharacterBuilder SetName(string name);
        CharacterBuilder SetHeight(string height);
        CharacterBuilder SetStature(string stature);
        CharacterBuilder SetHairColor(string hairColor);
        CharacterBuilder SetEyeColor(string eyeColor);
        CharacterBuilder SetClothes(string clothes);
        CharacterBuilder AddToInventory(string item);
        CharacterBuilder AddActing(string acting);
        HeroInfo Build();
    }
}
