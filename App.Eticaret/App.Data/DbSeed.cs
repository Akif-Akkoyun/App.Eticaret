using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class DbSeed
    {
        public static async Task SeedData(DbContext db)
        {
            List<RoleEntity> roles = new()
            {
                new RoleEntity{Name="Admin",CreatedAt=DateTime.UtcNow.Date},
                new RoleEntity{Name="Seller",CreatedAt=DateTime.UtcNow.Date},
                new RoleEntity{Name="Buyer",CreatedAt=DateTime.UtcNow.Date},
            };
            await db.Set<RoleEntity>().AddRangeAsync(roles);
            await db.SaveChangesAsync();
            List<UserEntity> users = new()
            {
                new UserEntity{FirstName="admin",LastName="admin",Email="admin@gmail.com",Password="1234",RoleId=1,Enable=true,CreatedAt=DateTime.UtcNow.Date},
                new UserEntity{FirstName="seller",LastName="seller",Email="seller@gmail.com",Password="1234",RoleId=2,Enable=true,CreatedAt=DateTime.UtcNow.Date},
                new UserEntity{FirstName="buyer",LastName="buyer",Email="buyer@gmail.com",Password="1234",RoleId=3,Enable=false,CreatedAt=DateTime.UtcNow.Date},
            };
            await db.Set<UserEntity>().AddRangeAsync(users);
            await db.SaveChangesAsync();            
            List<CategoryEntity> categories = new()
            {
                new CategoryEntity{Name="Electronics",Color="aaa",IconCssClass="asdasd", CreatedAt = DateTime.UtcNow.Date},
                new CategoryEntity{Name="Clothes",Color="aaa",IconCssClass="asdasd", CreatedAt = DateTime.UtcNow.Date},
                new CategoryEntity{Name="Books",Color="aaa",IconCssClass="asdasd", CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<CategoryEntity>().AddRangeAsync(categories);
            await db.SaveChangesAsync();
            List<ProductEntity> products = new()
            {
                new ProductEntity{Name="Laptop",Price=1000,StockAmount=100,CategoryId=1,Description="adas",SellerId=1,Enabled=true,CreatedAt=DateTime.UtcNow.Date},
                new ProductEntity{Name="T-shirt",Price=20,StockAmount=100,CategoryId=2,Description="adas",SellerId=1,Enabled=true,CreatedAt=DateTime.UtcNow.Date},
                new ProductEntity{Name="C# Programming",Price=50,StockAmount=100,CategoryId=3,Description="adas",SellerId=1,Enabled=true, CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<ProductEntity>().AddRangeAsync(products);
            await db.SaveChangesAsync();
            List<ProductCommentEntity> productComments = new()
            {
                new ProductCommentEntity{ProductId=1,UserId=1,Comment="Good",StarCount=5,IsConfirmed=true,CreatedAt=DateTime.UtcNow.Date},
                new ProductCommentEntity{ProductId=1,UserId=2,Comment="Bad",StarCount=1,IsConfirmed=true, CreatedAt = DateTime.UtcNow.Date},
                new ProductCommentEntity{ProductId=2,UserId=1,Comment="Good",StarCount=5,IsConfirmed=true, CreatedAt = DateTime.UtcNow.Date},
                new ProductCommentEntity{ProductId=2,UserId=2,Comment="Bad",StarCount=1,IsConfirmed=true, CreatedAt = DateTime.UtcNow.Date},
                new ProductCommentEntity{ProductId=3,UserId=1,Comment="Good",StarCount=5,IsConfirmed=true, CreatedAt = DateTime.UtcNow.Date},
                new ProductCommentEntity{ProductId=3,UserId=2,Comment="Bad",StarCount=1,IsConfirmed=true,CreatedAt=DateTime.UtcNow.Date},
            };
            await db.Set<ProductCommentEntity>().AddRangeAsync(productComments);
            await db.SaveChangesAsync();
            List<ProductImageEntity> productImages = new()
            {
                new ProductImageEntity{ProductId=1,Url="laptop.jpg",CreatedAt=DateTime.UtcNow.Date},
                new ProductImageEntity{ProductId=2,Url="tshirt.jpg", CreatedAt = DateTime.UtcNow.Date},
                new ProductImageEntity{ProductId=3,Url="book.jpg", CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<ProductImageEntity>().AddRangeAsync(productImages);
            await db.SaveChangesAsync();
            List<CartItemEntity> cartItems = new()
            {
                new CartItemEntity{ProductId=1,UserId=1,Quantity=10,CreatedAt=DateTime.UtcNow.Date},
                new CartItemEntity{ProductId=2,UserId=2,Quantity=30, CreatedAt = DateTime.UtcNow.Date},
                new CartItemEntity{ProductId=3,UserId=3,Quantity=40, CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<CartItemEntity>().AddRangeAsync(cartItems);
            await db.SaveChangesAsync();
            List<OrderEntity> orders = new()
            {
                new OrderEntity{UserId=1,OrderCode=Guid.NewGuid().ToString(),Address="asd", CreatedAt = DateTime.UtcNow.Date},
                new OrderEntity{UserId=1,OrderCode=Guid.NewGuid().ToString(),Address="asd", CreatedAt = DateTime.UtcNow.Date},
                new OrderEntity{UserId=1,OrderCode=Guid.NewGuid().ToString(),Address="asd", CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<OrderEntity>().AddRangeAsync(orders);
            await db.SaveChangesAsync();
            List<OrderItemEntity> orderItems = new()
            {
                new OrderItemEntity{OrderId=1,ProductId=1,Quantity=10, CreatedAt = DateTime.UtcNow.Date},
                new OrderItemEntity{OrderId=2,ProductId=2,Quantity=20, CreatedAt = DateTime.UtcNow.Date},
                new OrderItemEntity{OrderId=3,ProductId=3,Quantity=30, CreatedAt = DateTime.UtcNow.Date},
            };
            await db.Set<OrderItemEntity>().AddRangeAsync(orderItems);
            await db.SaveChangesAsync();
        }
    }
}
