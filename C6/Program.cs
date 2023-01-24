using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using C6;


namespace C5
{

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User
                {
                    Name="Elchin",
                    Surname="Guliyev",
                    Creditcard="Credit card 1"
                },
                  new User
                {
                    Name="Islam",
                    Surname="Salamzade",
                    Creditcard="Credit card 2"
                },
                    new User
                {
                    Name="Rustam",
                    Surname="Mammadov",
                    Creditcard="Credit card 3"
                },

            };

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i]+"\n");
            }


            List<Card> cards = new List<Card>
            {
                new Card
                {
                    Pan="4169738834321265",
                    Pin="1204",
                    Cvc="345",
                    Expiredate="10/26",
                    Balance=700,
                },
                  new Card
                {
                     Pan="416973884365",
                    Pin="5609",
                    Cvc="123",
                    Expiredate="08/29",
                    Balance=400,
                },
                    new Card
                {
                      Pan="416973889852",
                    Pin="3462",
                    Cvc="897",
                    Expiredate="04/30",
                    Balance=1000,
                },

            };
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i]+"\n");
            }



            while (true)
            {


                Console.Write("Enter PIN : ");
                string? pin;
                pin= Console.ReadLine();
                for (int i = 0; i < cards.Count; i++)
                {
                    if (cards[i].Pin==pin)
                    {
                        Console.WriteLine($"{users[i].Name}  {users[i].Surname} Welcome!!!");
                        Console.WriteLine("Select\n1.Balance \n2.Cash \n3)Card to card :");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice==1)
                        {
                            Console.WriteLine(cards[i].Balance +"AZN");
                        }
                        else if (choice==2)
                        {
                            Console.WriteLine(@"1.10 AZN
2.20 AZN
3.50 AZN
4.100 AZN
5.Other !");
                            Console.WriteLine("Select : ");
                            int selection = Convert.ToInt32(Console.ReadLine());
                            if (selection==1)
                            {
                       
                                int newBalance = cards[i].Balance-10;
                                if (newBalance<0)
                                {
                                   throw new InvalidDataException("Not enough balance!!");
                                }
                                cards[i].Balance = newBalance;
                               
                          
                            }
                            else if (selection==2)
                            {
                                int newBalance = cards[i].Balance-20;
                                if (newBalance<0)
                                {
                                    throw new InvalidDataException("Not enough balance!!");
                                }
                                cards[i].Balance=newBalance;
                            }
                           else if (selection==3)
                            {
                                int newBalance = cards[i].Balance-50;
                                if (newBalance<0)
                                {
                                    throw new InvalidDataException("Not enough balance!!");
                                }
                                cards[i].Balance=newBalance;
                            }
                            else if (selection==4)
                            {
                                int newBalance = cards[i].Balance-100;
                                if (newBalance<0)
                                {
                                    throw new InvalidDataException("Not enough balance!!");
                                }
                                cards[i].Balance=newBalance;
                            }
                            else if (selection==5)
                            {
                                Console.WriteLine("Enter money you want to cash out : ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                int newBalance = cards[i].Balance-money;
                                if (cards[i].Balance<0)
                                {
                                    throw new InvalidDataException("Not enough balance!!");
                                }
                                cards[i].Balance=newBalance;
                              
                            }
                        }
                        else if (choice==3)
                        {
                            Console.WriteLine("Enter the PAN of card which you want to send money !");
                            string? pan;
                            pan=Console.ReadLine();
                            for (int j = 0; j < cards.Count; j++)
                            {
                                for (int k = 0; k < cards.Count; k++)
                                {
                                    
                                    if (pan==cards[j].Pan)
                                            {
                                               Console.WriteLine("Enter money which you want to send : ");
                                               int sendedmoney = Convert.ToInt32(Console.ReadLine());
                                               int currentCardBalance = cards[j].Balance-sendedmoney;
                                               cards[j].Balance=currentCardBalance;
                                               int tt= cards[k].Balance+sendedmoney;
                                               cards[k].Balance=tt;
                                            }
                                }
                              
                              
                            }
                        }
                    }
                }

            }
        }
    }
}
