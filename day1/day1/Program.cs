var lines = File.ReadAllLines(@"C:\Users\Chris\Desktop\Dev\adventofcode2022\day1\day1\day1\elves.txt");

var elves = CalorieCounter.CountCalories(lines);
var mostCalories = CalorieCounter.FindElfWithMostCalories(elves);
var topThreeCalories = CalorieCounter.FindTopThreeElves(elves);

public static class CalorieCounter
{
    public static int[] CountCalories(string[] food)
    {
        var totalCalories = 0;
        var numberOfElves = food.Count(x => x == "") + 1;
        var elfCalories = new int[numberOfElves];
        var elfCaloriesIndex = 0;

        foreach (var snack in food)
        {
            if (snack != "")
            {
                totalCalories += int.Parse(snack);
            }
            if (snack == "")
            {
                elfCalories[elfCaloriesIndex] = totalCalories;
                elfCaloriesIndex++;
                totalCalories = 0;
            }
            if (snack == food.Last())
            {
                elfCalories[elfCaloriesIndex] = totalCalories;
            }
        }

        return elfCalories;
    }

    public static int FindElfWithMostCalories(int[] elfCalories)
    {
        return elfCalories.Max();
    }

    public static int FindTopThreeElves(int[] elfCalories){
        var topThreeElves = elfCalories.OrderByDescending(x => x).Take(3);
        return topThreeElves.Sum();
    }
}