using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{

    enum BrandName
    {
        Nokia,
        Apple,
        Microsoft,
        Xiomi
    }

    enum ModelName
    {
        _3310,
        X10,
        markamodel,
        cartcurt

    }

    enum OperatingSystems
    {
        iOS,
        Android,
        Independent,
        WindowsPhoneOS,
        LinuxFlavor
    }

    internal class BaseTelefon
    {

        // Base phone is pre-smartphone phones and their functionality
        public string PhoneNumber { get; set; }
        public BrandName Brand { get; set; }
        public ModelName Name { get; set; }
        public string EMAI { get; set; }
        public OperatingSystems OS { get; set; }
        
        // Özellikleri: SMS Gönderme, Arama Yapma, Müzik Dinleme, Oyun Oynama

        public void SMSGonder()
        {

        }
        public void AramaYap()
        {

        }
        public void MuzikDinle()
        {

        }
        public void OyunOyna()
        {

        }

    }
}
