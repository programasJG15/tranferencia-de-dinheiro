internal class Program
{
    static void Main(string[] args)
    {
        Guy joe = new Guy() { Cash = 50, Name = "Joe" };
        Guy bob = new Guy() { Cash = 100, Name = "Bob" };

        /// não é um metodo nativo da linguagem C#, mas sim um metodo que criamos na classe Guy, para exibir as informações de cada objeto.
        while (true)
        {
            joe.WriteMyInfo();
            bob.WriteMyInfo();

            Console.WriteLine("Coloque a quantia que deseja transferir: ");
            String? howMuch = Console.ReadLine();
            if (howMuch == "") return;

            /// convertendo a string para int utilizando o metodo "int.TryParse"
            if (int.TryParse(howMuch, out int quantia))
            {
                Console.Write("Quem ira transferir o dinheiro: ");
                string? whichGuy = Console.ReadLine();
                if (whichGuy == "Joe")
                {
                    int cashGiven = joe.GiveCash(quantia);
                    bob.ReceiveCash(cashGiven);

                }

                else if (whichGuy == "Bob")
                {
                    int cashGiven = bob.GiveCash(quantia);
                    joe.ReceiveCash(cashGiven);
                }
                else
                {
                    Console.WriteLine("Por favor, escolha entre Joe e Bob");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor válido ou uma linha em branco pra sair");
            }
        }
    }
}