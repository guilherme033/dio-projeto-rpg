namespace rpg_dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

       public override string Attack(){
            return this.Name + " Magic spell";
       }

       public string Attack(int Bonus){

           if (Bonus > 6){
                return this.Name + " (HIGH LEVEL) Cast a spell with attack bonus " + Bonus;
           }else{
               return this.Name + " (LOW LEVEL) Cast a spell with attack bonus " + Bonus;
           }

       }
    }
}