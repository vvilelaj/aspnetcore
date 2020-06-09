using Microsoft.AspNetCore.Razor.Language.Syntax;

namespace Microsoft.AspNetCore.Razor.Language.Intermediate
{
    internal class IntermediateTokenWithNode : IntermediateToken
    {
        public SyntaxNode Node { get; set; }

        public override string Content
        {
            get
            {
                if (base.Content == null)
                {
                    Content = Node?.GetContent() ?? string.Empty;
                    Node = null;
                }

                return base.Content;
            }
        }
    }
}
