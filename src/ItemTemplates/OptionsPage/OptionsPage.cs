using System.ComponentModel;
using Microsoft.VisualStudio.Helpers.Options;

namespace $rootnamespace$
{
    internal partial class OptionsProvider
    {
        // Register the options with these attributes on your package class:
        // [ProvideOptionPage(typeof(OptionsProvider.$safeitemname$Options), "My options", "$safeitemname$", 0, 0, true)]
        // [ProvideProfile(typeof(OptionsProvider.$safeitemname$Options), "My options", "$safeitemname$", 0, 0, true)]
        public class $safeitemname$Options : BasePage<$safeitemname$> { }
    }

    public class $safeitemname$ : BaseModel<$safeitemname$>
    {
        [Category("My category")]
        [DisplayName("My Option")]
        [Description("An informative description.")]
        [DefaultValue(true)]
        public bool MyOption { get; set; } = true;
    }
}
