using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DemoAspMvc.data;


namespace DemoAspMvc.Models
{
    public class User
    {
       

        [Key] //dataAnnotation
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อนักเรียน")]
        [DisplayName("ชื่อ")]
        public string Name { get; set; }

        [DisplayName("เมล")]
        public string Email  { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนอายุ")]
        [DisplayName("อายุ")]
        [Range(0,200,ErrorMessage ="ใส่อายุ 0 - 200")]
        public int Age  { get; set; }
    }

    
    
}