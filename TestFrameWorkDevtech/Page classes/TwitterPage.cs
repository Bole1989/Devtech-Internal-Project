using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
    public class TwitterPage
    {
        public bool IsAtTwitterPage()
        {
            return BaseClass.Title == PropertyValues.TwitterPageTitle;
        }
    }
}
