using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace $rootnamespace$
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal sealed class $safeitemname$ : IWpfTextViewCreationListener
    {
        /// <summary>
        /// Called when a text view having matching roles is created over a text data model having a matching content type.
        /// </summary>
        /// <param name="textView">The <see cref="IWpfTextView"/> that has been created.</param>
        public void TextViewCreated(IWpfTextView textView)
        {

        }
    }
}