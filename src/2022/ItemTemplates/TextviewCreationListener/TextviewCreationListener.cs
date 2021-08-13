using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace $rootnamespace$
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType(ContentTypes.Text)]
    [TextViewRole(PredefinedTextViewRoles.PrimaryDocument)]
    internal class $safeitemname$ : WpfTextViewCreationListener
    {
        protected override Task CreatedAsync(IWpfTextView textView, ITextDocument document)
        {
            // Do your async work here
            return Task.CompletedTask;
        }
    }
}