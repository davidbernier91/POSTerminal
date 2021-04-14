using System;
using System.Collections.Generic;

namespace PosTerminal {
    public class ShoppingCart {
        public static Dictionary<Product, int> UserCart = new Dictionary<Product, int>() { };

        public static int GetQuantity() {
            int userInput = Validation.ValidateNumber();
            return userInput;
            }

        public static void DisplayReceipt() {
            int receiptTotal = 0;
            foreach(var item in ShoppingCart.UserCart) {
                int itemTotalPrice = item.Value * item.Key.GetPrice();
                Console.WriteLine($"{item.Value} {item.Key.GetName()}s;  ${itemTotalPrice}");
                receiptTotal += itemTotalPrice;
                }
            Console.WriteLine($"{Phrases.NewLine}Total Bill: ${receiptTotal}");
            }


        }
    }
