using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string KullaniciAdded = "Kullanici Eklendi";
        public static string KullaniciInvalid = "Kullanici Adı Geçersiz";
        public static string KullaniciListed = "Kullanici Listelendi";
        public static string KullaniciDeleted = "Kullanici silindi";
        public static string kullaniciUpdated = "Kullanici güncellendi";
        public static string Added = "Ekleme başarılı";
        public static string Updated = "Güncelleme başarılı";
        public static string Deleted = "Silme başarılı";
        public static string Listed = "Listeleme başarılı";

        public static string USER_NOT_FOUND = "Hesabınız bulunamadı";
        public static string USER_WRONG_PASSWORD = "Şifre yanlış. Tekrar deneyin veya \"Şifrenizi mi unuttunuz?\"u tıklayarak şifreyi sıfırlayın.";

        public static string Delete { get; internal set; }
    }
}
