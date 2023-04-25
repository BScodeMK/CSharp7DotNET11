using Packt.Shared;
using System.Text;
using static Packt.Shared.BankAccount;

Packt.Shared.Person bob = new();

bob.Name = "Test";
bob.dateOfBitrth = new DateTime(1965, 12, 22);
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
arg0: bob.Name,
arg1: bob.dateOfBitrth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: (int)WondersOfTheAncientWorld.TempleOfArtemisAtEphesus,
    arg2: (int)bob.FavoriteAncientWonder);


BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new BankAccount();

jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
decimal test = BankAccount.InterestRate;
WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * InterestRate);