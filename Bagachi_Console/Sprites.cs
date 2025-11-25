
namespace Bagachi_Console
{
	public class Sprites
	{
		public static string ShowBagachi(string petID)
		{
			string[] bagachiType = new string[5];
			string lvl = petID.Length >= 4 ? petID.Substring(2, 2) : "00";


			bagachiType[0] = "╔══════════════════════╗\n" +
							 $"║ FIGHTER      Lvl. {lvl} ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║ Skills:              ║\n" +
							 "║ > Bite      > Run    ║\n" +
							 "║ > Parry              ║\n" +
							 "║                      ║\n" +
							 "╚══════════════════════╝\n";

			bagachiType[1] = "╔══════════════════════╗\n" +
							 $"║ WIZARD       Lvl. {lvl} ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║ Skills:              ║\n" +
							 "║ > Fire      > Run    ║\n" +
							 "║ > Chain              ║\n" +
							 "║                      ║\n" +
							 "╚══════════════════════╝\n";

			bagachiType[2] = "╔══════════════════════╗\n" +
							 $"║ THIEF        Lvl. {lvl} ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║ Skills:              ║\n" +
							 "║ > Poison      > Run  ║\n" +
							 "║ > Invisible          ║\n" +
							 "║                      ║\n" +
							 "╚══════════════════════╝\n";

			bagachiType[3] = "╔══════════════════════╗\n" +
							 $"║ GUARDIAN     Lvl. {lvl} ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║ Skills:              ║\n" +
							 "║ > Taunt      > Run   ║\n" +
							 "║ > Block              ║\n" +
							 "║                      ║\n" +
							 "╚══════════════════════╝\n";

			bagachiType[4] = "╔══════════════════════╗\n" +
							 $"║ HEALER       Lvl. {lvl} ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║                      ║\n" +
							 "║ Skills:              ║\n" +
							 "║ > Heal      > Run    ║\n" +
							 "║ > Regen              ║\n" +
							 "║                      ║\n" +
							 "╚══════════════════════╝\n";

			if (string.IsNullOrEmpty(petID))
				return bagachiType[0];

			int index = petID[0] - '0';
			if (index < 0 || index >= bagachiType.Length)
				index = 0;

			string bagachi = bagachiType[index];

			return bagachi;
		}
        public static string ShowBagachi(Bagachi pet)
        {
            pet.Stats();

			string name = pet.Type.ToString().ToUpper();
            string lvl = pet.Level.ToString("D2"); 
            string str = pet.Strength.ToString("D2");
            string def = pet.Defense.ToString("D2");
            string intel = pet.Intelligence.ToString("D2");
            string sta = pet.Stamina.ToString("D2");
            string hp = pet.Health.ToString("D3");
            string energy = pet.Energy.ToString("D3");

            string bagachiBox = "╔══════════════════════╗\n" +
                                $"║ {name,-12} Lvl. {lvl} ║\n" +
                                "║                      ║\n" +
                                $"║ STR : {str,-5}          ║\n" +
                                $"║ DEF : {def,-5}          ║\n" +
                                $"║ INT : {intel,-5}          ║\n" +
                                $"║ STA : {sta,-5}          ║\n" +
                                $"║                      ║\n" +
                                $"║ HP  : {hp,-5}          ║\n" +
                                $"║ EN  : {energy,-5}          ║\n" +
                                "║                      ║\n" +
                                "║ Skills:              ║\n" +
                                "╚══════════════════════╝\n";

            return bagachiBox;
        }
    }

    public enum PetType
    {
        Fighter,
        Wizard,
        Assassin,
        Guardian,
        Healer
    }

    public struct StatBonus
    {
        public int STR;
        public int DEF;
        public int INT;
        public int STA;

        public StatBonus(int str, int def, int intl, int sta)
        {
            STR = str;
            DEF = def;
            INT = intl;
            STA = sta;
        }
    }

    public static class TypeBonus
    {
        public static Dictionary<PetType, StatBonus> Bonuses = new Dictionary<PetType, StatBonus>()
        {
            { PetType.Fighter,  new StatBonus(2, 1, 0, 0) },
            { PetType.Wizard,   new StatBonus(0, 1, 2, 0) },
            { PetType.Assassin, new StatBonus(3, 0, 0, 0) },
            { PetType.Guardian, new StatBonus(0, 2, 0, 1) },
            { PetType.Healer,   new StatBonus(0, 0, 2, 1) },
        };
    }

	public class Bagachi
	{
		private string petID;

		public string ID
		{
			get => petID;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					petID = value;
					DecryptID();
					Stats();
				}
			}
		}

        public PetType Type { get; private set; }
        public char UniqueID { get; private set; }
        public int Level { get; private set; }
        public int Strength { get; private set; }
        public int Defense { get; private set; }
        public int Intelligence { get; private set; }
        public int Stamina { get; private set; }
        public int Health => Stamina * 10;
        public int Energy => Intelligence * 10;

        public int Experience { get; set; }
        public int RequiredExperience => (int)(10 * Math.Pow(1.61, Level - 1));
        public int Fullness { get; private set; }
        public int Age { get; private set; } 
        public string Mood { get; private set; }

        public Bagachi(string id)
        {
            this.petID = id;
            DecryptID();
            Stats();
            Fullness = 100;
            Age = 0;
            UpdateMood();
        }

        private void DecryptID()
        {
            int typeNum = int.Parse(petID.Substring(0, 1));
            UniqueID = petID[1];
            Level = int.Parse(petID.Substring(2, 2));

            Type = typeNum switch
            {
                0 => PetType.Fighter,
                1 => PetType.Wizard,
                2 => PetType.Assassin,
                3 => PetType.Guardian,
                4 => PetType.Healer,
                _ => PetType.Fighter,
            };
        }

        public void Stats()
        {
            // Base stats that scale with level
            int baseStr = Level * 2;
            int baseDef = Level * 2;
            int baseInt = Level * 1;
            int baseSta = (int)(Level * 1.5);

            // Bonus stats per type
            StatBonus b = TypeBonus.Bonuses[Type];

            Strength = baseStr + b.STR;
            Defense = baseDef + b.DEF;
            Intelligence = baseInt + b.INT;
            Stamina = baseSta + b.STA;
        }

        public void Feed(int amount)
        {
            Fullness += amount;
            if (Fullness > 100) Fullness = 100;
            UpdateMood();
        }

        public void Fight(int amount)
        {
            Mood = "Happy";
            Fullness -= amount / 2;
            if (Fullness < 0) Fullness = 0;
            UpdateMood();
        }

        public void AgeUp()
        {
            Age++;
            Fullness -= 5; // pets get hungrier with age/time
            if (Fullness < 0) Fullness = 0;
            UpdateMood();
        }

        public void UpdateMood()
        {
            if (Fullness >= 70 && Health >= 50)
                Mood = "Happy";
            else if (Fullness >= 40)
                Mood = "Neutral";
            else
                Mood = "Sad";
        }
    }


 //   class Bagachi()
	//{
	//	string petID;
	//	string petType;
	//	int petLevel;
	//	int petExperience;
	//	int petHealth;
	//	int petEnergy;
	//	int hunger;
	//	int happiness;
	//	int strength;
	//	int defense;

	//	public string ID
	//	{
	//		get => petID;
 //           set
	//		{
	//			if (!string.IsNullOrEmpty(value))
	//			{
	//				petID = value;
	//				decryptID();
 //               }
 //           }
 //       }

	//	public string Type => petID;

	//	public int Level => petID;

 //       public int Experience
	//	{
	//		get; set;
 //       }

	//	public int Health
	//	{
	//		get; set;
 //       }

	//	public int Energy
	//	{
	//		get; set;
 //       }

	//	public int Hunger
	//	{
	//		get; set;
 //       }

	//	public int Happiness
	//	{
	//		get; set;
 //       }

	//	public int Strength
	//	{
	//		get; set;
 //       }

	//	public int Defense
	//	{
	//		get; set;
 //       }

 //       public Bagachi(string id)
	//	{
	//		this.petID = id;
	//		decryptID();
 //       }
	//	private void decryptID()
	//	{
 //           petType = petID.Substring(0, 1).ToUpper();
 //           petLevel = int.Parse(petID.Substring(2));
 //       }
 //   }
}