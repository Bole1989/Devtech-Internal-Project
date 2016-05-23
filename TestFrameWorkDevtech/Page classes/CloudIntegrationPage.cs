namespace TestFrameWorkDevtech.Page_classes
{
    public class CloudIntegrationPage
    {
        public bool IsAtCloudIntegrationPage()
        {
            return BaseClass.Title == PropertyValues.CloudIntegrationPageTitle;
        }
    }
}