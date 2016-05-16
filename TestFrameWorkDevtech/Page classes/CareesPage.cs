namespace TestFrameWorkDevtech.Page_classes
{
    public class CareesPage
    {
        public bool IsAtCareersPage()
        {
            return BaseClass.Driver.Title == PropertyValues.CareersPageTitle;
        }
    }
}