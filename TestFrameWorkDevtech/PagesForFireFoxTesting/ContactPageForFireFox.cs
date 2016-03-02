namespace TestFrameWorkDevtech.PagesForFireFoxTesting
{
    public class ContactPageForFireFox
    {
        public bool IsAtContactPageOnFireFox()
        {
            return BaseClass.TitleOnFireFox == PropertyValues.ContactPageTitle;
        }
    }
}