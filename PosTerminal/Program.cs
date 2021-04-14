using System;

namespace PosTerminal {

    class Program {
        static void Main(string[] args) {
                Console.WriteLine(Phrases.Welcome);

                while(true) {
                    Store.DisplayMenu();

                    Console.Write(Phrases.ChooseFood);
                    int productIndex = Validation.ValidateFoodChoice();

                    Console.Write(Phrases.AskQuantity);
                    var product = Product.GetProduct(productIndex);

                    var quantity = ShoppingCart.GetQuantity();
                    ShoppingCart.UserCart.Add(product, quantity);
                    Console.WriteLine($"{quantity} {product.GetName()}s added to your cart{Phrases.NewLine}");

                    Console.WriteLine(Phrases.Continue);
                    bool continueProgram = Validation.AskYesOrNo();

                    if(continueProgram) {
                        Console.Clear();
                        continue;
                        }
                    else {
                        Console.Clear();
                        break;
                        }
                    }

                Console.WriteLine(Phrases.Receipt);
                bool seeReceipt = Validation.AskYesOrNo();

                if(seeReceipt) {
                    ShoppingCart.DisplayReceipt();
                    }
                else {
                    Console.WriteLine("GoodBye");
                    }
                }
            }
        }
    
