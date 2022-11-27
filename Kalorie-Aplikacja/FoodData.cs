using System;
using System.Collections.Generic;

public class Food
{
    public string name;
    public double weight;
    public double calories;
    public Food(string name, double weight, double calories)
    {
        this.name = name;
        this.weight = weight;
        this.calories = calories;
    }
}

/// <summary>
/// Contains the food lists
/// 
/// <list type="bullet">
///		<listheader>
///			<term>fastFoodFoodData</term>	
///			<description>A list containing fast food data</description>
///		</listheader>
///		
///		<item>
///			<term>healthyFoodFoodData</term>
///			<description>A list containing healthy food data</description>
///		</item>
/// 
/// </list>
/// </summary>
public class FoodData
{

    /// <summary>
    /// Contains fast food data based on Food class: Name, weight, calories
    /// </summary>
    public List<Food> fastFoodFoodData = new List<Food>()
    {
        new Food("Big Mac z McDonald’s", 100, 256),
        new Food("Brazer kanapka z KFC", 100, 190),
        new Food("Burger wegetariański", 100, 181),
        new Food("Cheeseburger", 100, 181),
        new Food("Falafel", 100, 335),
        new Food("Frytki", 100, 254),
        new Food("Grander z KFC", 100, 242),
        new Food("Hamburger", 100, 254),
        new Food("Hot dog", 100, 269),
        new Food("Indyk", 100, 104),
        new Food("Kanapka z klopsikami", 100, 161),
        new Food("Kanapka z kurczakiem", 100, 241),
        new Food("Kanapka z rybą", 100, 273),
        new Food("Kanapka z szynką", 100, 241),
        new Food("Kebab", 100, 225),
        new Food("Kiełbasa", 100, 333),
        new Food("Kotlet wegetariański", 100, 390),
        new Food("Krokiet", 100, 250),
        new Food("Krążki cebulowe", 100, 411),
        new Food("Lazania", 100, 132),
        new Food("Nachos z serem", 100, 306),
        new Food("Nuggetsy z kurczaka", 100, 324),
        new Food("Piersi z kurczaka", 100, 163),
        new Food("Skrzydełka z kurczaka", 100, 324),
        new Food("Tortilla Wrap", 100, 271),
        new Food("Tuńczyk", 100, 86),
        new Food("Whopper z Burger King", 100, 231),
        new Food("Wieśmac z McDonald’s", 100, 256),
        new Food("Zapiekanka", 100, 214),
        new Food("Zinger z KFC", 100, 270),
        new Food("Żeberka grillowane", 100, 212)

    };

    public List<Food> healthyFoodFoodData = new List<Food>
    {
        new Food("Pomidor", 100, 19),
        new Food("Banan", 100, 89),
        new Food("Cebula", 100, 40),
        new Food("Jabłko", 100, 57),
        new Food("Marchew", 100, 41),
        new Food("Ogórek", 100, 14),
        new Food("Chleb żytni", 100 ,227),
        new Food("Sałata", 100, 13),
        new Food("Papryka", 100, 26),
        new Food("Rzodkiewka", 100, 16),
        new Food("Miód", 100, 319),
        new Food("Ziemniaki", 100, 77),
        new Food("Kurczak", 100, 121),
        new Food("Awokado", 100, 160),
        new Food("Kiwi", 100, 61),
        new Food("Jajko", 100, 143),
        new Food("Pomarańcza", 100, 47),
        new Food("Gruszka", 100, 58),
        new Food("Brokuły", 100, 58),
        new Food("Sałata lodowa", 100, 14),
        new Food("Mandarynka", 100, 53),
        new Food("Kukurydza", 100, 61),
        new Food("Truskawki", 100, 32),
        new Food("Kalafior", 100, 27),
        new Food("Masło", 100, 753),
        new Food("Por", 100, 29),
        new Food("Chleb", 100, 247),
        new Food("Musztarda", 100, 111),
        new Food("Cytryna", 100, 29),
        new Food("Mleko", 100, 61),
        new Food("Ketchup", 100, 101),
        new Food("Mango", 100, 60),
        new Food("Grejpfrut", 100, 32),
        new Food("Arbuz", 100, 30),
        new Food("Ananas", 100, 50),
        new Food("Burak", 100, 43),
        new Food("Nektarynka", 100, 50),
        new Food("Jajecznica", 100, 149)
    };

    public FoodData()
    {
        //fastFoodFoodData.Sort();
    }
}
