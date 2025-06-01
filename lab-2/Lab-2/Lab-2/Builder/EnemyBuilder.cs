using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Builder
{
    public class EnemyBuilder : CharacterBuilder
    {
        private HeroInfo _heroInfo = new HeroInfo();

        public CharacterBuilder SetHeight(string height)
        {
            _heroInfo.Height = height;
            return this;
        }
        public CharacterBuilder SetName(string name)
        {
            _heroInfo.Name = name;
            return this;
        }
        public CharacterBuilder SetStature(string stature)
        {
            _heroInfo.Stature = stature;
            return this;
        }

        public CharacterBuilder SetHairColor(string hairColor)
        {
            _heroInfo.HairColor = hairColor;
            return this;
        }

        public CharacterBuilder SetEyeColor(string eyeColor)
        {
            _heroInfo.EyeColor = eyeColor;
            return this;
        }

        public CharacterBuilder SetClothes(string clothes)
        {
            _heroInfo.Clothes = clothes;
            return this;
        }

        public CharacterBuilder AddToInventory(string item)
        {
            _heroInfo.Inventory.Add(item);
            return this;
        }

        public CharacterBuilder AddActing(string acting)
        {
            _heroInfo.Acting.Add(acting);
            return this;
        }

        public HeroInfo Build()
        {
            return _heroInfo;
        }

        // Спеціальний метод для ворога
        public EnemyBuilder SetEnemyActions()
        {
            _heroInfo.Acting.AddRange(new List<string> { "Destruction of cities", "Steal treasure", "Lying" });
            return this;
        }
    }
}
