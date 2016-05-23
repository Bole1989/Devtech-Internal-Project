using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
   public class VPointSupportPage
    {
        public bool IsAtVPointSupportPage()
        {
            return BaseClass.Title == PropertyValues.VPointSupportPageTitle;
        }
    }
}
