using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public static class ValidCheck
    {
        /// <summary>
        /// kiểm tra địa chỉ email
        /// </summary>
        /// <param name="email">địa chỉ email</param>
        /// <param name="errMessage">thông báo lỗi</param>
        /// <returns>Địa chỉ email đúng định dạng trả lại true</returns>
        public static bool ValidEmail(string email, out string errMessage)
        {
            if (email.Length == 0) // kiểm tra địa chỉ email trống ko
            {
                errMessage = "Địa chỉ e-mail không được để trống.";
                return false;
            }
            if (email.IndexOf("@") > -1) // kiêm tra xem sau ký tự @ và . có đúng định dạng địa chỉ mail ko
            {
                if (email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@"))
                {
                    errMessage = string.Empty;
                    return true;
                }
            }
            errMessage = "Địa chỉ email phải đúng định dạng. Ví dụ: abc@example.com";
            return false;
        }

        /// <summary>
        /// kiểm tra thông tin để trống
        /// </summary>
        /// <param name="text">thông tin</param>
        /// <param name="errMessage">thông báo lỗi</param>
        /// <returns>Nếu như thông tin trống trả lại true</returns>
        public static bool ValidEmpty(string text, out string errMessage)
        {
            if (text.Length == 0 || string.IsNullOrEmpty(text))
            {
                errMessage = "Thông tin trống";
                return true;
            }
            errMessage = string.Empty;
            return false;
        }

        /// <summary>
        /// Kiểm tra số
        /// </summary>
        /// <param name="sNumber">chuỗi ký tự</param>
        /// <param name="errMessage">thông báo</param>
        /// <returns>Nếu là số thì giá trị trả lại true</returns>
        public static bool ValidNumber(string sNumber, out string errMessage)
        {
            if (sNumber.Length == 0 || string.IsNullOrEmpty(sNumber))
            {
                errMessage = "Thông tin trống";
                return false;
            }
            else
            {
                foreach (Char c in sNumber)
                {
                    if (!Char.IsDigit(c))
                    {
                        errMessage = "Không đúng định dạng số";
                        return false;
                    }
                }
            }
            errMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// kiểm tra đầu vào phải là số không và gắn giá trị số
        /// </summary>
        /// <param name="pvalue">thông tin đầu vào</param>
        /// <returns>Nếu đầu vào là giá trị rỗng hoặc ko phải là số, trả về 0. Nếu là số trả về số</returns>
        public static int SetNumber(string pvalue)
        {
            int result = 0;
            if(int.TryParse(pvalue, out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}