internal class Guy
{
    public int Cash { get; set; }
    public string Name { get; set; } = " ";

    public void WriteMyInfo()
    {
        Console.WriteLine($"{Name} tem {Cash} reais.");
    }

    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"{Name} diz: {amount} não é uma quantia válida.");
            return 0;
        }

        if (amount > Cash)
        {
            Console.WriteLine($"{Name} diz: Não tenho dinheiro suficiente.");
            return 0;
        }

        Cash -= amount;
        return amount;
    }

    public void ReceiveCash(int amount)
    {
        if (amount > 0)
            Cash += amount;
    }
}