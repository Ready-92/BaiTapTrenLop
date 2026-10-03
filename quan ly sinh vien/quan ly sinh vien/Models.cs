using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace quan_ly_sinh_vien
{
    public class LopHoc
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        public override string ToString() => TenLop;
    }

    public class SinhVien
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; } // true = Nam, false = Nu

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string DienThoai { get; set; }

        [Range(0, 10)]
        public double Diem { get; set; }

        [Required]
        public string LopHocId { get; set; }

        public string TrangThai { get; set; }
    }

    public static class ModelValidator
    {
        public static bool TryValidate(object obj, out List<ValidationResult> results)
        {
            var ctx = new ValidationContext(obj, serviceProvider: null, items: null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, ctx, results, validateAllProperties: true);
        }
    }
}
