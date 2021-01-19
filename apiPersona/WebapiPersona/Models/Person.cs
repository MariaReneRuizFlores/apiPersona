
namespace WebapiPersona.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public enum SexType
    {
        Femenino=0,
        Masculino=1
    }
    public class Person
    {
        [Key]
        public int Personid { get; set; } //Aquí escribimos prop e hicimos tap tap 
        [Required]
        [StringLength(80,ErrorMessage = "Favor ingrese su nombre entre 5 y 80 caracteres", MinimumLength = 5)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthay { get; set; }
        public SexType Sex { get; set; }


    }
}