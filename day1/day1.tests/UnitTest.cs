namespace day1.tests
{
    public class UnitTest
    {
        [Fact]
        public void ItShouldCountCaloriesForAElf()
        {
            var elfCalories = CalorieCounter.CountCalories(new string[] { "1", "2", "3" });

            Assert.Equal(6, elfCalories[0]);
        }

        [Fact]
        public void ItShouldCountCaloriesForMultipleElves()
        {
            var elfCalories = CalorieCounter.CountCalories(new string[] { "1", "2", "", "4", "5" });

            Assert.Equal(3, elfCalories[0]);
            Assert.Equal(9, elfCalories[1]);
        }

        [Fact]
        public void ItShouldReturnTheElfWithMostCalories()
        {
            var elfCalories = CalorieCounter.CountCalories(new string[] { "1", "2", "", "4", "5" });
            var mostCalories = CalorieCounter.FindElfWithMostCalories(elfCalories);

            Assert.Equal(9, mostCalories);
        }

        [Fact]
        public void ItShouldReturnTheTopThreeElvesTotalCalories()
        {
            var elfCalories = CalorieCounter.CountCalories(new string[] { "1", "2", "", "4", "5", "", "7", "8" });
            var topThreeElves = CalorieCounter.FindTopThreeElves(elfCalories);

            Assert.Equal(27, topThreeElves);
        }
    }
}