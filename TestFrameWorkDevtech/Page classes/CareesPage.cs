namespace TestFrameWorkDevtech.Page_classes
{
    public class CareesPage
    {
        public bool IsAtCareersPage()
        {
            return BaseClass.Title == PropertyValues.CareersPageTitle;
        }
    }
}