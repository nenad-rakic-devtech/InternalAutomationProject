namespace TestFrameWorkDevtech.PagesForFireFoxTesting
{
    public class CareesPageForFireFox
    {
        public bool IsAtCareersPageOnFireFox()
        {
            return BaseClass.TitleOnFireFox == PropertyValues.CareersPageTitle;
        }
    }
}