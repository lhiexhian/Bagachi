
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
	}
}