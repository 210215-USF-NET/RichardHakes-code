using System;
using System.Collections.Generic;

namespace ToHDL
{
    public class HeroRepoSC : IHeroRepository
    {
        public List<Hero> GetHeroes()
        {
            return Storage.AllHeroes;
        }
        public HeroRepoSC AddHero(Hero newHero)
        {
            
        }
    }
}
