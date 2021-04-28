using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    class Program
    {
        static void Main(string[] args)
        {
            
            WarriorBuilder warriorBuilder = new WarriorBuilder();
            ArcherBuilder archerBuilder = new ArcherBuilder();
            BerserkerBuilder berserkerBuilder = new BerserkerBuilder();
            HomelessBuilder homelessBuilder = new HomelessBuilder();

            CharacterCreator characterCreator = new CharacterCreator();

            Player player1 = characterCreator.Create(warriorBuilder);
            player1.Name = "Warrior";
            player1.Info();

            Player player2 = characterCreator.Create(archerBuilder);
            player2.Name = "Archer";
            player2.Info();

            Player player3 = characterCreator.Create(berserkerBuilder);
            player3.Name = "Berserker";
            player3.Info();

            Player player4 = characterCreator.Create(homelessBuilder);
            player4.Name = "Homeless";
            player4.Info();

        }
    }
}
