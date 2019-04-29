using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTBuilder;

namespace ASTBuilder
{

    public class CompilationUnit : AbstractNode
    {
        // just for the compilation unit because it's the top node
        //public override AbstractNode LeftMostSibling => this;
        public override AbstractNode Sib => null;

        public CompilationUnit(AbstractNode classDecl)
        {
            adoptChildren(classDecl);
        }

    }

    public enum ModifierType { PUBLIC, STATIC, PRIVATE }

    public class Modifiers : AbstractNode
    {
        public List<ModifierType> ModifierTokens { get; set; } = new List<ModifierType>();

        public void AddModType(ModifierType type)
        {
            ModifierTokens.Add(type);
        }

        public Modifiers(ModifierType type) : base()
        {
            AddModType(type);
        }

    }
    public class Identifier : AbstractNode
    {
        public virtual string Name { get; protected set; }

        public Identifier(string s)
        {
            Name = s;
        }
    }
    public class INT_CONST : AbstractNode
    {
        public virtual string IntVal { get; protected set; }

        public INT_CONST(string s)
        {
            IntVal = s;
        }
    }

    public class STR_CONST : AbstractNode
    {
        public virtual string StrVal { get; protected set; }

        public STR_CONST(string s)
        {
            StrVal = s;
        }
    }


    public class MethodDeclaration : AbstractNode
    {
        public MethodDeclaration(
            AbstractNode modifiers,
            AbstractNode typeSpecifier,
            AbstractNode methodSignature,
            AbstractNode methodBody)
        {
            adoptChildren(modifiers);
            adoptChildren(typeSpecifier);
            adoptChildren(methodSignature);
            adoptChildren(methodBody);
        }

    }

    public enum EnumPrimitiveType { BOOLEAN, INT, VOID }
    public class PrimitiveType : AbstractNode
    {
        public EnumPrimitiveType Type { get; set; }
        public PrimitiveType(EnumPrimitiveType type)
        {
            Type = type;
        }

    }
    
     public class MethodBody : AbstractNode
    {
        public MethodBody(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class Parameter : AbstractNode
    {
        public Parameter(AbstractNode typeSpec, AbstractNode declName) : base()
        {
            adoptChildren(typeSpec);
            adoptChildren(declName);
        }
    }

    public class ParameterList : AbstractNode
    {
        public ParameterList(AbstractNode parameter) : base()
        {
            adoptChildren(parameter);
        }
    }

    public class MethodSignature : AbstractNode
    {
        public MethodSignature(AbstractNode name)
        {
            adoptChildren(name);
        }

        public MethodSignature(AbstractNode name, AbstractNode paramList)
        {
            adoptChildren(name);
            adoptChildren(paramList);
        }
    }
    
    public enum ExprKind
    {
        EQUALS, OP_LOR, OP_LAND, PIPE, HAT, AND, OP_EQ,
        OP_NE, OP_GT, OP_LT, OP_LE, OP_GE, PLUSOP, MINUSOP,
        ASTERISK, RSLASH, PERCENT, UNARY, PRIMARY
    }
    public class Expression : AbstractNode
    {
        public ExprKind exprKind { get; set; }
        public Expression(AbstractNode expr, ExprKind kind)
        {
            adoptChildren(expr);
            exprKind = kind;
        }
        public Expression(AbstractNode lhs, ExprKind kind, AbstractNode rhs)
        {
            adoptChildren(lhs);
            adoptChildren(rhs);
            exprKind = kind;
        }

    }
    public class PrimaryExpression : AbstractNode 
    {
        public PrimaryExpression(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }
    public enum SpecialNameType { THIS, NULL }

    public class SpecialName : AbstractNode
    {
        public SpecialNameType SpecialType { get; set; }
        public SpecialName(SpecialNameType specialType)
        {
            SpecialType = specialType;
        }

    }

    public class NotJustName : AbstractNode
    {
        public NotJustName(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class ComplexPrimaryNoParenthesis : AbstractNode
    {
        public ComplexPrimaryNoParenthesis(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class MethodReference : AbstractNode
    {
        public MethodReference(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class ComplexPrimary : AbstractNode
    {
        public ComplexPrimary(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }
    
}

