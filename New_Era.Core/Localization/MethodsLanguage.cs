

namespace New_Era.Core.Localization
{
    public static class MethodsLanguage
    {
        public static string IsArbic()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            if (cultureInfo.TwoLetterISOLanguageName.ToLower().Equals("ar")) return "ar";

            return "en";
        }
    }
}
