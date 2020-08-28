using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Editor.Commanding;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Editor.Commanding;

namespace $rootnamespace$
{
    [Export(typeof(CommandBindingDefinition))]
    [CommandBinding(CommandGuid, CommandID, typeof($safeitemname$))]
    public class $safeitemname$ : EditorCommandArgs
    {
        public const string CommandGuid = "<guid>";
        public const int CommandID = 0x100;

        public $safeitemname$(ITextView textView, ITextBuffer textBuffer)
            : base(textView, textBuffer)
        { }
    }
}
