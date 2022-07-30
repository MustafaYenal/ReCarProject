using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInValid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDetailList = "Araba Detay Listesi";
       

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandNameInValid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string SameNameExist = "Aynı araba markası isminde zaten araba mevcut.";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorNameInValid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorNotAdded = "Yeni renk eklenemedi";


        public static string CustomerAdded = "Customer added";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerListed = "Customers listed";

        public static string RentalAdded = "Rental added";
        public static string RentalDeleted = "Rental deleted";
        public static string RentalUpdated = "Rental updated";
        public static string RentalListed = "Rentals listed";
        public static string RentalReturnedDateError = "Car cannot be rented(Araç teslim edilmemiştir)";

        public static string UserAdded = "User added";
        public static string UsersListed = "Users listed";
        public static string UserUpdated = "User updated";
        public static string UserDeleted = "User deleted";


        public static string ImageAdded = "Resim Başarılı bir şekilde eklendi";
        public static string ImageDeleted="Resim başarılı bir şekilde silindi.";
        public static string ImageUpdated = "Resim başarılı bir şekilde güncellendi";

        public static string AuthorizationDenied = "Yetkiniz Yok !!!";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
