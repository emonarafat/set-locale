using System.Collections.Generic;
using System.Data;
using SetLocale.Client.Web.Helpers;
namespace SetLocale.Client.Web.Models
{
    public class TranslationModel : BaseModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        
        public LanguageModel Language { get; set; }

        public bool IsValid()
        {
            return !Key.IsNullOrEmpty()
                   && !Value.IsNullOrEmpty();
        }
    }
}