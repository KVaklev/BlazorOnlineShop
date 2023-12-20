using BlazorOnlineShop.Shared;

namespace BlazorOnlineShop.Service
{
    public class ProductService
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            await Task.Delay(100);


            return new List<Product>
            {
              new Product() { ProductId = 1, ProductName = "Fishing Rod", UnitInStock = 25, UnitPrice = 75.99m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/1.Fishing Rod.jpg"},
              new Product() { ProductId = 2, ProductName = "Fishing Reel", UnitInStock = 30, UnitPrice = 49.50m, DeliveryOn = new DateTime(2023, 11, 01), ImageUrl="images/2.Fishing Reel.jpg"},
              new Product() { ProductId = 3, ProductName = "Fishing Line", UnitInStock = 50, UnitPrice = 12.75m, DeliveryOn = new DateTime(2023, 10, 15), ImageUrl="images/3.Fishing Line.jpeg"},
              new Product() { ProductId = 4, ProductName = "Fishing Lures Set", UnitInStock = 0, UnitPrice = 29.99m, DeliveryOn = new DateTime(2024, 03, 20), ImageUrl="images/4.Fishing Lures Set.jpg" },
              new Product() { ProductId = 5, ProductName = "Fishing Tackle Box", UnitInStock = 20, UnitPrice = 39.95m, DeliveryOn = new DateTime(2023, 12, 05), ImageUrl="images/5.Fishing Tackle Box.jpeg" },
              new Product() { ProductId = 6, ProductName = "Fishing Hooks Pack", UnitInStock = 60, UnitPrice = 8.50m, DeliveryOn = new DateTime(2023, 12, 09), ImageUrl="images/6.Fishing Hooks Pack.jpg" },
              new Product() { ProductId = 7, ProductName = "Fishing Bobbers (Pack of 10)", UnitInStock = 0, UnitPrice = 6.25m, DeliveryOn = new DateTime(2023, 02, 03), ImageUrl="images/7.Fishing Bobbers.jpg" },
              new Product() { ProductId = 8, ProductName = "Fishing Swivels (Pack of 50)", UnitInStock = 70, UnitPrice = 11.99m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/8.Fishing Swivels.jpg" },
              new Product() { ProductId = 9, ProductName = "Fishing Float", UnitInStock = 35, UnitPrice = 7.75m, DeliveryOn = new DateTime(2023, 12, 11), ImageUrl="images/9.Fishing Float.jpeg" },
              new Product() { ProductId = 10, ProductName = "Fishing Bait Bucket", UnitInStock = 0, UnitPrice = 19.50m, DeliveryOn = new DateTime(2024, 01, 20), ImageUrl="images/10.Fishing Bait Bucke.jpg" },
              new Product() { ProductId = 11, ProductName = "Fishing Pliers with Sheath", UnitInStock = 27, UnitPrice = 24.95m, DeliveryOn = new DateTime(2023, 12, 09), ImageUrl="images/11.Fishing Pliers with Sheath.jpg" },
              new Product() { ProductId = 12, ProductName = "Fishing Rod Holdall", UnitInStock = 10, UnitPrice = 59.99m, DeliveryOn = new DateTime(2024, 01, 20), ImageUrl="images/12.Fishing Rod Holdall.jpg" },
              new Product() { ProductId = 13, ProductName = "Fishing Headlamp", UnitInStock = 0, UnitPrice = 14.99m, DeliveryOn = new DateTime(2024, 02, 11), ImageUrl="images/13.Fishing Headlamp_.jpg" },
              new Product() { ProductId = 14, ProductName = "Fishing Scale (Digital)", UnitInStock = 40, UnitPrice = 25.50m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/14.Fishing Scale (Digital).jpg" },
              new Product() { ProductId = 15, ProductName = "Fishing Rod Holder", UnitInStock = 15, UnitPrice = 18.75m, DeliveryOn = new DateTime(2024, 01, 20), ImageUrl="images/15.Fishing Rod Holder.jpg" },
              new Product() { ProductId = 16, ProductName = "Fishing Hat with Neck Flap", UnitInStock = 30, UnitPrice = 12.25m, DeliveryOn = new DateTime(2023, 12, 07), ImageUrl="images/16.Fishing Hat with Neck Flap.jpeg" },
              new Product() { ProductId = 17, ProductName = "Fishing Line Cutter", UnitInStock = 50, UnitPrice = 6.99m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/17.Fishing Line Cutter.jpg" },
              new Product() { ProductId = 18, ProductName = "Fishing Rod Rack", UnitInStock = 0, UnitPrice = 34.95m, DeliveryOn = new DateTime(2024, 04, 05), ImageUrl="images/18.Fishing Rod Rack.jpg" },
              new Product() { ProductId = 19, ProductName = "Fishing Bivvy Tent", UnitInStock = 5, UnitPrice = 199.99m, DeliveryOn = new DateTime(2024, 01, 20), ImageUrl="images/19.Fishing Bivvy Tent.jpg" },
              new Product() { ProductId = 20, ProductName = "Fishing Multi-Tool", UnitInStock = 0, UnitPrice = 28.50m, DeliveryOn = new DateTime(2024, 01, 07), ImageUrl="images/20.Fishing Multi-Tool.jpg" },
              new Product() { ProductId = 21, ProductName = "Fishing Drone with Camera", UnitInStock = 3, UnitPrice = 399.00m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/21.Fishing Drone with Camera.jpg" },
              new Product() { ProductId = 22, ProductName = "Fishing Rod Building Kit", UnitInStock = 8, UnitPrice = 149.95m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/22.Fishing Rod Building Kit.jpg" },
              new Product() { ProductId = 23, ProductName = "Fishing Rod Case", UnitInStock = 0, UnitPrice = 45.00m, DeliveryOn = new DateTime(2024, 01, 10), ImageUrl="images/23.Fishing Rod Case.jpeg" },
              new Product() { ProductId = 24, ProductName = "Fishing Chair with Cooler", UnitInStock = 15, UnitPrice = 79.99m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/24.Fishing Chair with Cooler.jpg" },
              new Product() { ProductId = 25, ProductName = "Fishing Paddle", UnitInStock = 0, UnitPrice = 55.25m, DeliveryOn = new DateTime(2024, 01, 17), ImageUrl="images/25.Fishing Paddle.jpeg" },
              new Product() { ProductId = 26, ProductName = "Fishing Rod Repair Kit", UnitInStock = 10, UnitPrice = 29.50m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/26.Fishing Rod Repair Kit.jpeg" },
              new Product() { ProductId = 27, ProductName = "Fishing Trolley Cart", UnitInStock = 0, UnitPrice = 89.95m, DeliveryOn = new DateTime(2023, 12, 28), ImageUrl="images/27.Fishing Trolley Cart.jpg" },
              new Product() { ProductId = 28, ProductName = "Fishing Umbrella", UnitInStock = 30, UnitPrice = 19.99m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/28.Fishing Umbrella.jpg" },
              new Product() { ProductId = 29, ProductName = "Fishing Waist Pack", UnitInStock = 0, UnitPrice = 32.75m, DeliveryOn = new DateTime(2023, 12, 12), ImageUrl="images/29.Fishing Waist Pack.jpeg" },
              new Product() { ProductId = 30, ProductName = "Fishing Rod Holder for Boats", UnitInStock = 8, UnitPrice = 69.50m, DeliveryOn = new DateTime(2023, 12, 20), ImageUrl="images/30.Fishing Rod Holder for Boats.jpg" },
              new Product() { ProductId = 31, ProductName = "Fishing Bait Launcher", UnitInStock = 0, UnitPrice = 149.00m, DeliveryOn = new DateTime(2024, 03, 05), ImageUrl="images/31.Fishing Bait Launcher.jpg" },
              new Product() { ProductId = 32, ProductName = "Fishing GPS Tracker", UnitInStock = 7, UnitPrice = 199.99m, DeliveryOn = new DateTime(2023, 12, 25), ImageUrl="images/32.Fishing GPS Tracker.jpeg" },
              new Product() { ProductId = 33, ProductName = "Fishing Waterproof Bag", UnitInStock = 20, UnitPrice = 29.99m, DeliveryOn = new DateTime(2024, 12, 28), ImageUrl="images/33.Fishing Waterproof Bag.jpeg" },
              new Product() { ProductId = 34, ProductName = "Fishing Baitcasting Reel", UnitInStock = 15, UnitPrice = 119.50m, DeliveryOn = new DateTime(2023, 12, 19), ImageUrl="images/34.Fishing Baitcasting Reel.jpg" },
              new Product() { ProductId = 35, ProductName = "Fishing Rod Holder Belt", UnitInStock = 25, UnitPrice = 18.75m, DeliveryOn = new DateTime(2023, 12, 15), ImageUrl="images/35.Fishing Rod Holder Belt.jpg" }
            };
        }
    }
}
