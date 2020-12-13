using HeadСhef.DAL.Abstract;
using HeadСhef.DAL.Entities.KindOfFood;
using HeadСhef.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HeadСhef.DAL.Entities
{
    public class Store
    {
        public static BlackPepper GetBlackPepper(double weight)
        {
            return new BlackPepper(weight);
        }

        public static CiabattaBread GetCiabattaBread(double weight)
        {
            return new CiabattaBread(weight);
        }

        public static EggYolk GetEggYolk(double weight)
        {
            return new EggYolk(weight);
        }
        
        public static Garlic GetGarlic(double weight)
        {
            return new Garlic(weight);
        }
        
        public static Kefir GetKefir(double weight)
        {
            return new Kefir(weight);
        }
        
        public static LactucaSativa GetLactucaSativa(double weight)
        {
            return new LactucaSativa(weight);
        }
        
        public static MustardPowder GetMustardPowder(double weight)
        {
            return new MustardPowder(weight);
        }
        
        public static OliveOil GetOliveOil(double weight)
        {
            return new OliveOil(weight);
        }
        
        public static Oregano GetOregano(double weight)
        {
            return new Oregano(weight);
        }
        
        public static Parmesan GetParmesan(double weight)
        {
            return new Parmesan(weight);
        }
        
        public static SeaSalt GetSeaSalt(double weight)
        {
            return new SeaSalt(weight);
        }

    }
}
