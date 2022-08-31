using Core.Entities.Concrete;
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

        public static string ProductDeleted = "Ürün silindi";

        public static string ProductUpdated = "Ürün güncellendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MaintenanceTime = "Sistem bakımda - Her gün saat 22 de bakım yapılır";

        public static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Kategoride maksimum 10 ürün olabilir!";

        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez!";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığından sisteme eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok!";

        public static string UserRegistered = "Kullanıcı başarıyla kayıt oldu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre hatası!";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı!";
        public static string UserAlreadyExists = "Kullanıcı zaten sistemde kayıtlı!";
        public static string AccessTokenCreated = "Access Token oluşturuldu!";
    }
}
