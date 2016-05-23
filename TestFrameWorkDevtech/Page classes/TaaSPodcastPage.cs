using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
    public class TaaSPodcastPage
    {
        public bool IsAtTaaSPodcastPage()
        {
            return BaseClass.Title == PropertyValues.TaaSPodcastPageTitle;
        }
    }
}
