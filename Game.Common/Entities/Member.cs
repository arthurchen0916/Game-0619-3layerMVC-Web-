using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Game.Common;

namespace Game.Common.Entities
{
    public partial class Member :BaseEntity
    {
        [DisplayName("使用者帳號")]
        [Required(ErrorMessage = "帳號為必填欄位")]
        public string Account { get; set; }

        [DisplayName("使用者密碼")]
        [Required(ErrorMessage = "密碼為必填項")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }

    }
}
