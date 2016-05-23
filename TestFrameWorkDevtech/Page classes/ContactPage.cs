namespace TestFrameWorkDevtech.Page_classes
{
    public class ContactPage
    {
        public bool IsAtContactPage()
        {
            return BaseClass.Title == PropertyValues.ContactPageTitle;
        }
    }
}