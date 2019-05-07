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
        public int count = 0;
        public List<ModifierType> ModifierTokens { get; set; } = new List<ModifierType>();

        public void AddModType(ModifierType type)
        {
            ModifierTokens.Add(type);
        }

        public Modifiers(ModifierType type) : base()
        {
            AddModType(type);
            count++;
        }

        //public Modifiers(AbstractNode modifier, ModifierType type) : base()
        //{
        //    adoptChildren(modifier);
        //    AddModType(type);
        //    count++;
        //}

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

    //public class IFStatement : AbstractNode
    //{
    //    public IFStatement(AbstractNode LPR, AbstractNode statement, AbstractNode ELSE)
    //    {
    //        adoptChildren(LPR);
    //        adoptChildren(statement);
    //        adoptChildren(ELSE);
    //    }
    //}

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

    public class Block : AbstractNode
    {
        public Block(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class LocalItems : AbstractNode
    {

        public LocalItems(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
        public LocalItems(AbstractNode localItems, AbstractNode localItem)
        {
            localItems.adoptChildren(localItem);
            //adoptChildren(localItems);
            adoptChildren(localItem);

        }
    }

    public class LocalItem : AbstractNode
    {
        public LocalItem(AbstractNode abstractNode)
        {
            adoptChildren(abstractNode);
        }
    }

    public class LocalVariableDeclaration : AbstractNode
    {
        public LocalVariableDeclaration(AbstractNode typeSpecifier, AbstractNode localVariableNames)
        {
            adoptChildren(typeSpecifier);
            adoptChildren(localVariableNames);
            //adoptChildren(sEMICOLON);
        }
    }

    public class LocalVariableNames : AbstractNode
    {
        public LocalVariableNames(AbstractNode localVariableNames, AbstractNode identifier)
        {
            adoptChildren(localVariableNames);
            adoptChildren(identifier);
        }
    }

    public class Statement: AbstractNode
    {
        public Statement(AbstractNode abstractNode){
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

    public class MethodCall :AbstractNode
    {
        public MethodCall (AbstractNode methodReference)
        {
            adoptChildren(methodReference);
        }

        public MethodCall (AbstractNode methodReference, AbstractNode argumentsList)
        {
            adoptChildren(methodReference);
            adoptChildren(argumentsList);
        }
    }

    public class ClassDeclaration : AbstractNode
    {
        public ClassDeclaration(AbstractNode classDeclaration)
        {
            adoptChildren(classDeclaration);
        }

        //public ClassDeclaration (AbstractNode classDeclaration, AbstractNode identifier, AbstractNode classBody)
        //{
        //    adoptChildren(classDeclaration);
        //    adoptChildren(identifier);
        //    adoptChildren(classBody);
        //}
    }

    public class FieldVariableDeclaration : AbstractNode
    {
        public FieldVariableDeclaration (AbstractNode modifiers, AbstractNode typeSpecifier, AbstractNode fieldVariableDeclarators)
        {
            adoptChildren(modifiers);
            adoptChildren(typeSpecifier);
            adoptChildren(fieldVariableDeclarators);
        }
    }

    //public class Statement : AbstractNode
    //{
    //    public Statement(AbstractNode abstractNode)
    //    {
    //        adoptChildren(abstractNode);
    //    }
    //}
}

