namespace TestFrameWorkDevtech.Page_classes
{
    public class ContactPage
    {
        public bool IsAtContactPageOnFireFox()
        {
            return BaseClass.Title == PropertyValues.ContactPageTitle;
        }
    }
}