class Drink : IConsumable
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public bool IsSpicy { get; set; }
    public bool IsSweet { get; set; }

    // Implement a GetInfo Method
    public string GetInfo()
    {
        return $"{Name} (Comida).  Calorias: {Calories}.  es picante?: {IsSpicy}, Dulce?: {IsSweet}";
    }
    // Add a constructor method
    public Drink(string name, int calories, bool Isspicy, bool issweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = Isspicy;
        IsSweet = issweet;
    }
}

