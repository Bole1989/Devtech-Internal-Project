using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
    public class QualityAssurancePage
    {
        public bool IsAtQualityAssurancePage()
        {
            return BaseClass.Title == PropertyValues.QualityAssurancePageTitle;
        }
    }
}
