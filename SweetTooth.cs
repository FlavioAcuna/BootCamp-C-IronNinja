class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull
    {
        get
        {
            if (calorieIntake >= 1500)
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
            Console.WriteLine("El ninja ya esta satisfecho para seguir comiendo.");
        }
        else
        {
            ConsumptionHistory.Add(item);
            calorieIntake += item.Calories;
            if (item.IsSweet == true)
            {
                calorieIntake += 10;
            }
            Console.WriteLine(item.GetInfo());
        }
    }
}

