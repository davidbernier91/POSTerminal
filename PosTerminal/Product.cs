namespace PosTerminal {
    public class Product {

        private string Name { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }

        public Product() {

            }
        public Product(string name, string category, string description, int price) {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            }

        public string DisplayProduct() {
            return $"{Name}\t {Category}\t {Description}\t ${Price}";
            }

        public static Product GetProduct(int userInput) {
            return Store.StoreList[userInput - 1];
            }

        public string GetName() {
            return Name;
            }
        public int GetPrice() {
            return Price;
            }


        }
    }
