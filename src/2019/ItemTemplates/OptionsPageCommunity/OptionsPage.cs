﻿using System.ComponentModel;
using System.Runtime.InteropServices;
using Community.VisualStudio.Toolkit;

namespace $rootnamespace$
{
    internal partial class OptionsProvider
    {
    // Register the options with this attribute on your package class:
    // [ProvideOptionPage(typeof(OptionsProvider.$safeitemname$Options), "$rootnamespace$", "$safeitemname$", 0, 0, true, SupportsProfiles = true)]
    [ComVisible(true)]
        public class $safeitemname$Options : BaseOptionPage<$safeitemname$> { }
    }

    public class $safeitemname$ : BaseOptionModel<$safeitemname$>
    {
        [Category("My category")]
        [DisplayName("My Option")]
        [Description("An informative description.")]
        [DefaultValue(true)]
        public bool MyOption { get; set; } = true;
    }
}
