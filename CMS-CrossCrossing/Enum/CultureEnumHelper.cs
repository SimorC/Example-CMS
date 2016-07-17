using System;

namespace CMS_CrossCrossing.Enum
{
    public class CultureEnumHelper
    {
        public static CultureEnum GetByString(string culture)
        {
            if (culture.StartsWith("pt", StringComparison.InvariantCultureIgnoreCase)) return CultureEnum.Pt;
            return CultureEnum.En;
        }
    }

    public enum CultureEnum
    {
        En,
        Pt
    }
}