using System.ComponentModel.Composition;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using Task = System.Threading.Tasks.Task;

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