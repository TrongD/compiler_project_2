using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTBuilder
{
    class PrintVisitor : IReflectiveVisitor
    {
        // This method is the key to implenting the Reflective Visitor pattern
        // in C#, using the 'dynamic' type specification to accept any node type.
        // The subsequent call to VisitNode does dynamic lookup to find the
        // appropriate Version.

        public void Visit(dynamic node)
        {
            this.VisitNode(node);
        }

        // Call this method to begin the tree printing process
        // This is a new version that uses VisitChildren rather than
        // building in the traversal logic
        public void PrintTree(AbstractNode node, string prefix = "")
        {
            if (node == null) { 
                return;
            }
            bool isLastChild = (node.Sib == null);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(prefix);
            Console.Write(isLastChild ? "└─ " : "├─ ");
            Console.ResetColor();
            node.Accept(this);
            VisitChildren(node, prefix + (isLastChild ? "   " : "│ "));
       }
        public void VisitChildren(AbstractNode node, String prefix)
        {
            AbstractNode child = node.Child;         
            while (child != null) {
               PrintTree(child, prefix);
               child = child.Sib;
            };
        }

        public void VisitNode(AbstractNode node)
        {
            Console.WriteLine("<" + node.ClassName() + ">");
        }

        //public void VisitNode(Modifiers node)
        //{
        //    Console.Write("<" + node.ClassName() + ">: ");
        //    // Add code here to print Modifier info
        //}

        public void VisitNode(Identifier node)
        {
            Console.Write("<" + node.ClassName() + ">: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(node.Name);
            Console.ResetColor();
        }

        public void VisitNode(INT_CONST node)
        {
            Console.Write("<" + node.ClassName() + ">: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(node.IntVal);
            Console.ResetColor();
        }

        public void VisitNode(STR_CONST node)
        {
            Console.Write("<" + node.ClassName() + ">: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(node.StrVal);
            Console.ResetColor();
        }

    }

}

