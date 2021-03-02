using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Message
    {
        //Brand Messages
        public static string BrandAdded = "Brand eklendi";
        public static string BrandUpdated = "Brand güncellendi";
        public static string BrandDeleted = "Brand silindi";
        public static string BrandsListed = "Brands listelendi";

        //Car Messages
        public static string CarAdded = "Car eklendi";
        public static string CarUpdated = "Car güncellendi";
        public static string CarDeleted = "Car silindi";
        public static string CarsListed = "Cars listelendi";

        //Color Messages
        public static string ColorAdded = "Color eklendi";
        public static string ColorUpdated = "Color güncellendi";
        public static string ColorDeleted = "Color silindi";
        public static string ColorsListed = "Colors listelendi";

        //Error Messages
        public static string BrandNameInvalid = "Brand Name bulunamadı";
        public static string CarNameInvalid = "Car Name bulunamadı";
        public static string ColorNameInvalid = "Color Name bulunamadı";
        public static string MaintenanceTime = "Maintenance Mode";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";


        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";


        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatası!";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Token oluşturuldu.";

    }
}
