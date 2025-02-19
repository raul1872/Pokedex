namespace Pokedex.Util
{
    public static class PokeUtil
    {
        public const string Pokeball = "pokeball-normal.png";
        public const string MasterBall = "masterball.png";
        public const string UltraBall = "ultraball.png";
        public const string GreatBall = "greatball.png";
        public static string GetRandomBall()
        {
            var pokeballArray = new string[] { Pokeball, GreatBall, UltraBall, MasterBall };
            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];
            return randomBall;
        }
        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }
        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
