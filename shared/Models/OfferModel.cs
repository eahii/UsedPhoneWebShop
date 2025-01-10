using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class OfferModel
    {
        public int OfferID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Puhelimen merkki on pakollinen.")]
        public string PhoneBrand { get; set; }

        [Required(ErrorMessage = "Puhelimen malli on pakollinen.")]
        public string PhoneModel { get; set; }

        [Required(ErrorMessage = "Puhelimen muisti on pakollinen.")]
        public string PhoneMemory { get; set; } // Muistin tallennus

        [Range(0, 10000, ErrorMessage = "Alkuperäinen hinta on virheellinen.")]
        public decimal OriginalPrice { get; set; }

        [Range(0, 20, ErrorMessage = "Puhelimen ikä ei voi olla negatiivinen tai yli 20 vuotta.")]
        public int PhoneAge { get; set; }

        [Range(0, 100, ErrorMessage = "Puhelimen yleinen kunto pitää olla välillä 0-100.")]
        public int OverallCondition { get; set; }

        [Range(0, 100, ErrorMessage = "Akunkesto pitää olla välillä 0-100.")]
        public int BatteryLife { get; set; }

        [Range(0, 100, ErrorMessage = "Näytön kunto pitää olla välillä 0-100.")]
        public int ScreenCondition { get; set; }

        [Range(0, 100, ErrorMessage = "Kameran kunto pitää olla välillä 0-100.")]
        public int CameraCondition { get; set; }

        [Required(ErrorMessage = "Puhelimen toimivuus on pakollinen.")]
        public bool WorksNormally { get; set; }

        [Required(ErrorMessage = "Tarjouksen tila on pakollinen.")]
        public string Status { get; set; } // Esimerkiksi "Pending", "Approved", "Rejected"

        public DateTime SubmissionDate { get; set; }
    }
}
