using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public static class ValidationCheck
    {
        public class ValidEmtyNullLeng : Csla.Rules.BusinessRule
        {
            
            public int Prefix { get; private set; }
            public string Message { get; private set; }

            public ValidEmtyNullLeng(Csla.Core.IPropertyInfo primaryProperty, int length, string message)
                : base(primaryProperty)
            {
                InputProperties = new List<Csla.Core.IPropertyInfo> { PrimaryProperty };
                Prefix = length;
                Message = message;
                //RuleUri.AddQueryParameter("prefix", Convert.ToString(prefix));
            }

            protected override void Execute(Csla.Rules.RuleContext context)
            {
                var text = (string)context.InputPropertyValues[PrimaryProperty];
                if (string.IsNullOrEmpty(text))
                    context.AddErrorResult(string.Format("Không thể để trống",1));
                else
                    if (text.Length < Prefix)
                        context.AddErrorResult(string.Format(Message, Prefix));
            }
        }

        public class ValiNumber : Csla.Rules.BusinessRule
        {
            //public int Prefix { get; private set; }
            public double Min { get; private set; }
            public double Max { get; private set; }
            public string Message { get; private set; }

            public ValiNumber(Csla.Core.IPropertyInfo primaryProperty, string message, double min)
                : base(primaryProperty)
            {
                InputProperties = new List<Csla.Core.IPropertyInfo> { PrimaryProperty };
                Max = 0;
                Min = min;
                //Prefix = length;
                Message = message;
                //RuleUri.AddQueryParameter("prefix", Convert.ToString(prefix));
            }

            protected override void Execute(Csla.Rules.RuleContext context)
            {
                var text = (string)context.InputPropertyValues[PrimaryProperty];
                if (!IsNumber(text))
                    context.AddErrorResult(string.Format(Message));
            }

            #region Là kiểu số nhưng có thể có thêm những dấu chấm
            //public bool IsNumber(string pText)
            //{
            //    Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            //    return regex.IsMatch(pText);
            //}
            #endregion

            #region Ký tự phải là số mới được chấp nhận
            public bool IsNumber(string pValue)
            {
                if (pValue == null)
                    return true;
                else
                {
                    foreach (Char c in pValue)
                    {
                        if (!Char.IsDigit(c))
                            return false;
                    }
                }
                return true;
            }
            #endregion
        }


    }
}
