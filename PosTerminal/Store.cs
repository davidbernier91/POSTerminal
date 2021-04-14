using System;
using System.Collections.Generic;

namespace PosTerminal {
    public class Store {

        public static List<Product> StoreList = new List<Product>() {
            new Product("Chicken", "Meat", "Delicous", 7),
            new Product("Beef", "Meat", "Delicous", 10),
            new Product("Pork", "Meat", "Delicous", 6),
            new Product("Bagel", "Bread", "Delicous", 2),
            new Product("Soda", "Drink", "Delicous", 2),
            new Product("Milk", "Dairy", "Delicous", 2),
            new Product("Chocolate", "Candy", "Delicous", 2),
            new Product("Chips", "Snack", "Delicous", 2),
            new Product("Ketchup", "Condiment", "Delicous", 2),
            new Product("Mustard", "Condiment", "Delicous", 2),
            new Product("Salt", "Seasoning", "Delicous", 1),
            new Product("Pepper", "Seasoning", "Delicous", 1),
            };

        public static int GetUpperRange() {
            return StoreList.Count;
            }

        public static void DisplayMenu() {
            int index = 0;
            foreach(var item in StoreList) {
                Console.WriteLine($"{index += 1}: {item.DisplayProduct()}");
                }
            Console.WriteLine(Phrases.NewLine);
            }

        }
    }
