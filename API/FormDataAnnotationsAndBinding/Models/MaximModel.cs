using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormDataAnnotationsAndBinding.Models
{
    public class MaximModel
    {
        public int Id { get; set; }
        [Display(Name = "이름")]
        [Required(ErrorMessage ="이름을 입력하시오.")]
        [StringLength(25, MinimumLength =1, ErrorMessage ="1~25자 이하")]
        public string Name { get; set; }
        [Display(Name = "내용")]
        [Required(ErrorMessage = "내용을 입력하시오.")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "1~25자 이하")]
        public string Content { get; set; }
    }
}
