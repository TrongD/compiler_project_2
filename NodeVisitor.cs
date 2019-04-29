namespace ASTBuilder
{
	/// <summary>
	/// Basic visitor pattern -- a node must accept a visitor </summary>

    public interface NodeVisitor
    {
        void Visit(AbstractNode node);

        void Visit(Modifiers node);
        void Visit(Identifier node);
        void Visit(PrimitiveType node);
        void Visit(Expression node);
        void Visit(SpecialName node);
    }
}