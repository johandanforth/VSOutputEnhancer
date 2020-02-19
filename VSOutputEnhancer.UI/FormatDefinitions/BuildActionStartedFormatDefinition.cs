using System.ComponentModel.Composition;
using Balakin.VSOutputEnhancer.Logic;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Balakin.VSOutputEnhancer.UI.FormatDefinitions
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ClassificationType.BuildActionStarted)]
    [Name(ClassificationType.BuildActionStarted)]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    public sealed class BuildActionStartedFormatDefinition : StyledClassificationFormatDefinition
    {
        [ImportingConstructor]
        public BuildActionStartedFormatDefinition(IStyleManager styleManager) : base(styleManager)
        {
        }
    }
}