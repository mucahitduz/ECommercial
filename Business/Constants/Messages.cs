using Core.Entities.Concrete;
using Entities.Concrete;
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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategory = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten mevcut.";
        public static string CategoryLimitExceeded = "Kategorideki ürün limiti aşıldığı için yeni ürün eklenemedi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt işlemi başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu";
    }
}
