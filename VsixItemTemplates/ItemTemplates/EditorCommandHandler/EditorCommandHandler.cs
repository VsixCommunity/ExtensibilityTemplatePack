using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Editor.Commanding;
using Microsoft.VisualStudio.Utilities;

namespace $rootnamespace$
{
    [Export(typeof(ICommandHandler))]
    [Name(nameof($safeitemname$))]
    [ContentType("code")]
    [TextViewRole(PredefinedTextViewRoles.PrimaryDocument)]
    public class $safeitemname$ : ICommandHandler<EditorCommandArgs> // Replace EditorCommandArgs with more specific CommandArgs class
    {
        public string DisplayName => nameof($safeitemname$);

        public bool ExecuteCommand(EditorCommandArgs args, CommandExecutionContext executionContext)
        {
            throw new NotImplementedException();
        }

        public CommandState GetCommandState(EditorCommandArgs args)
        {
            return CommandState.Available;
        }
    }
}