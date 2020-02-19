using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takibi
{
    class ExternalVariables_TR
    {
        // database name
        public string useDatabaseQuery = "use zuccaciye";
        public string userID { set; get; }

        // pop-up window notifications
        public string sqlConnSuccessMessage = "Veritabanına başarılı bağlandı!";
        public string sqlConnErrorMessage = "Maalesef Bağlantı Yapılamadı...!";
        public string messageBoxErrorMessage = "Hata Oluştu";
        public string productRegistrationSuccessMessage = "Başarılı Kayd Edilmiştir!";
        public string productAddedSuccessMessage = "Başarıyla Eklendi";
        public string messageBoxSuccessMessage = "Doğru!";
        public string itemNotLeftInStockMessage = "Bu üründen stokta başka kalmadı!";
        public string sqlDataReaderIsEmptyMessage = "SqlDataReader is empty!";
        public string productNotFoundMessage = "Böyle ürün bulunamadı!";
        public string deleteMoreThanExistingErrorMessage = "Var olandan fazlasını silemez!";
        public string productDeletedSuccessMessage = "Başarı ile Silinmiştir!";
        public string welcomeMessage = "Hoş Geldiniz ";
        public string usernameOrPasswordErrorMessage = "Isim veya şifre hatalı!";

        // addProduct variables texts/names
        public string productNumberAddProductLabelIT = "Ürün Numarasını Giriniz :";
        public string productQuantityAddProductLabelIT = "Eklemek İstediğiniz Miktar :";
        public string acceptAddProductButtonIT = "Onay";
        public string cancelAddProductButtonIT = "İptal";
        public string productNameAddProductLabelIT = "Ürün Adı :";
        public string addProductWindowNameIT = "Ürün Ekleme Sayfası";

        // deleteProduct variables texts/names 
        public string productNumberDeleteProductLabelIT = "Ürün Adı :";
        public string productQuantityDeleteProductLabelIT = "Ürün Miktarı :";
        public string deleteQuantityDeleteProductLabelIT = "Silmek İstediğiniz Miktar :";
        public string acceptDeleteProductButtonIT = "Onay";
        public string cancelDeleteProductButtonIT = "İptal";
        public string productChooseDeleteProductButtonIT = "Seç";
        public string enterProductNameDeleteProductLabelIT = "Ürün Numarası Giriniz :";
        public string deleteProductWindowNameIT = "Ürün Silme Sayfası";

        // login variables texts/names
        public string enterLoginButtonIT = "Giriş Yap";
        public string exitLoginButtonIT = "Çıkış Yap";
        public string loginWindowNameIT = "Login Sayfası";
        public System.Drawing.Color usernameLoginTextBoxColorIT = System.Drawing.ColorTranslator.FromHtml("#e0e0e0");

        // Employee variables texts/names
        //-- in functions
        public string numberCopyColumnSaleLabelIT = "Numara";
        public string quantityCopyColumnSaleLabelIT = "Miktar";
        public string descriptionCopyColumnSaleLabelIT = "Açıklama";
        public string priceCopyColumnSaleLabelIT = "Fiyat";
        public string linePriceCopyColumnSaleLabelIT = "Aynı Ürünlerin Toplamı";
        //-- in .designer class
        public string numberColumnSaleLabelIT = "Numara";
        public string quantityColumnSaleLabelIT = "Miktar";
        public string descriptionColumnSaleLabelIT = "Açıklama";
        public string priceColumnSaleLabelIT = "Fiyat";
        public string linePriceColumnSaleLabelIT = "Aynı Ürünlerin Toplamı";
        public string removeColumnSaleLabelIT = "İptal";
        public string addProductSaleButtonIT = "Sepeteye Ekle";
        public string displayProductNameSaleGroupBoxIT = "Ürün Numarası";
        public string displayEnterQuantitySaleGroupBoxIT = "Eklenecek Miktar:";
        public string productLeftSaleLabelIT = "...";
        public string sellSaleButtonIT = "Sat";
        public string manualProductEnterSaleGroupBoxIT = "Klavye İle Ürün Girişi";
        public string sellInformationSaleGroupBoxIT = "Satış Bilgileri";
        public string paymetMethodSaleComboBoxIT = "Nakit";
        public string paymentMethodSaleComboBoxIT = "Ödeme Yöntemi";
        public string totalPriceSaleTextBoxIT = "0.00";
        public string totalPriceDisplaySaleGroupBoxIT = "Toplam Fiyat";
        public string barcodeReadFieldSaleGroupBoxIT = "Barkod";
        public string upCornerSaleMenuStripIT = "upCornerSaleMenuStrip";
        public string sectionsToolStripMenuItemIT = "Bölümler";
        public string registrationSectionsToolStripMenuItemIT = "Ürün Kaydı";
        public string addProductSectiosProductToolStripMenuItemIT = "Ürün Ekleme";
        public string deleteProductSectionsToolStripMenuItemIT = "Ürün Çıkartma";
        public string showProductsSectionsToolStripMenuItemIT = "Ürünleri Göster";
        public string saleWindowTabPageIT = "Tatış Sayfası";
        public string mainPageWindowNameIT = "Dükkan";
        // --styles


        // productRegistration variables texts/names
        public string productMeasureProductRegistrationComboBoxIT = "Parçalar Halinde";
        public string productMeasureProductRegistrationLabelIT = "Ürün Ölcüsü";
        public string productNumberProductRegistrationLabelIT = "Ürün Numarası :";
        public string productNameProductRegistrationLabelIT = "Ürün Adı :";
        public string productDescriptionProductRegistrationLabelIT = "Ürün Ölçüm :";
        public string productPictureProductRegistrationLabelIT = "Ürünün Resmi";
        public string productSalePriceProductRegistrationLabelIT = "Satış Fiyatı :";
        public string choosePictureProductRegistrationButtonIT = "Resim Seç";
        public string acceptProductRegistrationButtonIT = "Onay";
        public string productArrivalPriceProductRegistrationLabelIT = "Alış Fiyatı :";
        public string cancelProductRegistrationButtonIT = "Iptal";
        public string companyNameSaleLabelIT = "Firmanın Adı :";
        public string productCostSaleLabelIT = "Maliyeti :";
        public string productFirstArrivalDateIT = "Ürünün İlk Alım Günü: ";
        public string productQuantityLabelIT = "Ürün Miktarı :";
        public string emptyOrWhiteSpaceErrorErrorProviderIT = "Alan Boş Olmamalı";
        public string productExistsErrorErrorProviderIT = "Aynı Numaralı Üründen Stokta Mevcut";
        public string productRegistrationWindowNameIT = "Ürün Kaydı Sayfası";

        // showProduct variables texts/names
        public string productChooseShowProductsButtonIT = "Seç";
        public string cancelShowProductButtonIT = "Kapat";
        public string showProductWindowNameIT = "Ürünleri Gösterme Sayfası";

        // font sizes
        public System.Drawing.Font sansSerif20FFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static System.Drawing.Font sansSerif14FFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public System.Drawing.Font sansSerif10FFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        // program icon notification
        public NotifyIcon MyIcon = new NotifyIcon();
        public string iconLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icons\\programIcon.ico";
        public string removeImageLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icons\\removeImage.png";
        public string iconNameNotificationIT = "Dükkan proğramı";
        public int showBallonTipWithMillisecondsIT = 3000;

        // action history 
        public string registrationWasAppliedLabelIT = "Ürün Kaydı Yapıldı";
        public string deletionWasAppliedLabelIT = "Silme Yapıldı";
        public string additionWasAppliedLabelIT = "Ekleme Yapıldı";
    }
}
