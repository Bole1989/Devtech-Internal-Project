using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
    public class WhitePaperPage
    {
        public bool IsAtWhitePaperPage()
        {
            System.Threading.Thread.Sleep(1000);
            //return BaseClass.Title == PropertyValues.WhitePaperPageTitle;
            return BaseClass.CurrentUrl==PropertyValues.WhitePaperPageUrl;
        }
    }
}
