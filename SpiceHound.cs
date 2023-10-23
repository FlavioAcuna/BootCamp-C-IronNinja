class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
    public override bool IsFull
    {
        get
        {
            if (calorieIntake >= 1200)
            {
                return true;
            }
            return false;
        }

    }
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if (IsFull == true)
        {
            Console.WriteLine("El ninja no puede continuar comiendo");
        }
        else
        {
            ConsumptionHistory.Add(item);
            calorieIntake += item.Calories;
            if (item.IsSpicy == true)
            {
                calorieIntake -= 5;
            }
            Console.WriteLine(item.GetInfo());
        }
    }
}

