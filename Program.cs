Buffet newBuffet = new Buffet();
SweetTooth Javier = new SweetTooth();
SpiceHound Emiliano = new SpiceHound();

Console.WriteLine("comida de Javier");
while (Javier.IsFull != true)
{
    Javier.Consume(newBuffet.Serve());
}
Console.WriteLine("comida de Emiliano");
while (Emiliano.IsFull != true)
{
    Emiliano.Consume(newBuffet.Serve());
}