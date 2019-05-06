// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  t-pc
// DateTime: 5/6/2019 3:13:34 PM
// UserName: t
// Input file <TCCL.grammar.y - 5/6/2019 3:07:12 PM>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace ASTBuilder
{
internal enum Token {error=2,EOF=3,AND=4,ASTERISK=5,BANG=6,
    BOOLEAN=7,CLASS=8,COLON=9,COMMA=10,ELSE=11,EQUALS=12,
    HAT=13,IDENTIFIER=14,IF=15,INSTANCEOF=16,INT=17,INT_NUMBER=18,
    LBRACE=19,LBRACKET=20,LITERAL=21,LPAREN=22,MINUSOP=23,NEW=24,
    NULL=25,OP_EQ=26,OP_GE=27,OP_GT=28,OP_LAND=29,OP_LE=30,
    OP_LOR=31,OP_LT=32,OP_NE=33,PERCENT=34,PERIOD=35,PIPE=36,
    PLUSOP=37,PRIVATE=38,PUBLIC=39,QUESTION=40,RBRACE=41,RBRACKET=42,
    RETURN=43,RPAREN=44,RSLASH=45,SEMICOLON=46,STATIC=47,STRUCT=48,
    SUPER=49,THIS=50,TILDE=51,VOID=52,WHILE=53,UNARY=54};

// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<AbstractNode,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public AbstractNode yylval;
  public LexLocation yylloc;
  public ScanObj( int t, AbstractNode val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class TCCLParser: ShiftReduceParser<AbstractNode, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[110];
  private static State[] states = new State[178];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "ClassDeclaration", "MethodDeclarations", 
      "MethodDeclaration", "Modifiers", "TypeSpecifier", "MethodSignature", "MethodBody", 
      "Identifier", "ParameterList", "Parameter", "Block", "ClassBody", "FieldDeclarations", 
      "FieldDeclaration", "FieldVariableDeclaration", "ConstructorDeclaration", 
      "StaticInitializer", "StructDeclaration", "FieldVariableDeclarators", "TypeName", 
      "ArraySpecifier", "PrimitiveType", "QualifiedName", "FieldVariableDeclaratorName", 
      "LocalItems", "LocalItem", "LocalVariableDeclaration", "Statement", "LocalVariableNames", 
      "EmptyStatement", "ExpressionStatement", "SelectionStatement", "IterationStatement", 
      "ReturnStatement", "Expression", "ArgumentList", "ArithmeticUnaryOperator", 
      "PrimaryExpression", "NotJustName", "SpecialName", "ComplexPrimary", "ComplexPrimaryNoParenthesis", 
      "Number", "FieldAccess", "MethodCall", "MethodReference", };

  static TCCLParser() {
    states[0] = new State(new int[]{39,118,38,119,47,120},new int[]{-1,1,-3,3,-6,4,-4,174,-5,177});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{8,5,38,116,47,117,7,39,17,40,52,41,14,20},new int[]{-7,172,-22,35,-24,38,-25,158,-10,80,-23,110});
    states[5] = new State(new int[]{14,20},new int[]{-10,6});
    states[6] = new State(new int[]{19,8},new int[]{-14,7});
    states[7] = new State(-13);
    states[8] = new State(new int[]{41,170,39,118,38,119,47,164},new int[]{-15,9,-16,171,-17,12,-6,14,-5,166,-18,167,-19,168,-20,169});
    states[9] = new State(new int[]{41,10,39,118,38,119,47,164},new int[]{-16,11,-17,12,-6,14,-5,166,-18,167,-19,168,-20,169});
    states[10] = new State(-19);
    states[11] = new State(-22);
    states[12] = new State(new int[]{46,13});
    states[13] = new State(-23);
    states[14] = new State(new int[]{38,116,47,117,48,113,7,39,17,40,52,41,14,20},new int[]{-7,15,-8,161,-22,35,-24,38,-25,158,-10,163,-23,110});
    states[15] = new State(new int[]{14,20},new int[]{-21,16,-8,21,-26,149,-10,150});
    states[16] = new State(new int[]{10,17,46,-29});
    states[17] = new State(new int[]{14,20},new int[]{-26,18,-10,19});
    states[18] = new State(-39);
    states[19] = new State(-40);
    states[20] = new State(-108);
    states[21] = new State(new int[]{19,24},new int[]{-9,22,-13,23});
    states[22] = new State(-6);
    states[23] = new State(-12);
    states[24] = new State(new int[]{41,147,7,39,17,40,52,41,14,20,39,118,38,119,47,120,46,123,37,83,23,84,50,90,25,91,22,93,21,97,18,99,15,128,53,136,43,142,19,24},new int[]{-27,25,-28,148,-29,28,-7,29,-22,35,-24,38,-25,42,-10,80,-23,110,-20,111,-6,112,-30,121,-32,122,-33,124,-37,126,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102,-34,127,-35,135,-36,141,-13,146});
    states[25] = new State(new int[]{41,26,7,39,17,40,52,41,14,20,39,118,38,119,47,120,46,123,37,83,23,84,50,90,25,91,22,93,21,97,18,99,15,128,53,136,43,142,19,24},new int[]{-28,27,-29,28,-7,29,-22,35,-24,38,-25,42,-10,80,-23,110,-20,111,-6,112,-30,121,-32,122,-33,124,-37,126,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102,-34,127,-35,135,-36,141,-13,146});
    states[26] = new State(-43);
    states[27] = new State(-46);
    states[28] = new State(-47);
    states[29] = new State(new int[]{14,20},new int[]{-31,30,-10,34});
    states[30] = new State(new int[]{46,31,10,32});
    states[31] = new State(-49);
    states[32] = new State(new int[]{14,20},new int[]{-10,33});
    states[33] = new State(-52);
    states[34] = new State(-51);
    states[35] = new State(new int[]{20,36,14,-30});
    states[36] = new State(new int[]{42,37});
    states[37] = new State(-34);
    states[38] = new State(-32);
    states[39] = new State(-35);
    states[40] = new State(-36);
    states[41] = new State(-37);
    states[42] = new State(new int[]{35,43,12,45,20,-33,14,-33,31,-88,29,-88,36,-88,13,-88,4,-88,26,-88,33,-88,28,-88,32,-88,30,-88,27,-88,37,-88,23,-88,5,-88,45,-88,34,-88,46,-88,22,-102});
    states[43] = new State(new int[]{14,20},new int[]{-10,44});
    states[44] = new State(-105);
    states[45] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,46,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[46] = new State(new int[]{31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-67,44,-67,10,-67});
    states[47] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,48,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[48] = new State(new int[]{31,-68,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-68,44,-68,10,-68});
    states[49] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,50,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[50] = new State(new int[]{31,-69,29,-69,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-69,44,-69,10,-69});
    states[51] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,52,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[52] = new State(new int[]{31,-70,29,-70,36,-70,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-70,44,-70,10,-70});
    states[53] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,54,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[54] = new State(new int[]{31,-71,29,-71,36,-71,13,-71,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-71,44,-71,10,-71});
    states[55] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,56,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[56] = new State(new int[]{31,-72,29,-72,36,-72,13,-72,4,-72,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-72,44,-72,10,-72});
    states[57] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,58,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[58] = new State(new int[]{31,-73,29,-73,36,-73,13,-73,4,-73,26,-73,33,-73,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-73,44,-73,10,-73});
    states[59] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,60,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[60] = new State(new int[]{31,-74,29,-74,36,-74,13,-74,4,-74,26,-74,33,-74,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-74,44,-74,10,-74});
    states[61] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,62,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[62] = new State(new int[]{31,-75,29,-75,36,-75,13,-75,4,-75,26,-75,33,-75,28,-75,32,-75,30,-75,27,-75,37,69,23,71,5,73,45,75,34,77,46,-75,44,-75,10,-75});
    states[63] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,64,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[64] = new State(new int[]{31,-76,29,-76,36,-76,13,-76,4,-76,26,-76,33,-76,28,-76,32,-76,30,-76,27,-76,37,69,23,71,5,73,45,75,34,77,46,-76,44,-76,10,-76});
    states[65] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,66,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[66] = new State(new int[]{31,-77,29,-77,36,-77,13,-77,4,-77,26,-77,33,-77,28,-77,32,-77,30,-77,27,-77,37,69,23,71,5,73,45,75,34,77,46,-77,44,-77,10,-77});
    states[67] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,68,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[68] = new State(new int[]{31,-78,29,-78,36,-78,13,-78,4,-78,26,-78,33,-78,28,-78,32,-78,30,-78,27,-78,37,69,23,71,5,73,45,75,34,77,46,-78,44,-78,10,-78});
    states[69] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,70,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[70] = new State(new int[]{31,-79,29,-79,36,-79,13,-79,4,-79,26,-79,33,-79,28,-79,32,-79,30,-79,27,-79,37,-79,23,-79,5,73,45,75,34,77,46,-79,44,-79,10,-79});
    states[71] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,72,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[72] = new State(new int[]{31,-80,29,-80,36,-80,13,-80,4,-80,26,-80,33,-80,28,-80,32,-80,30,-80,27,-80,37,-80,23,-80,5,73,45,75,34,77,46,-80,44,-80,10,-80});
    states[73] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,74,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[74] = new State(-81);
    states[75] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,76,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[76] = new State(-82);
    states[77] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,78,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[78] = new State(-83);
    states[79] = new State(new int[]{12,45,35,43,31,-88,29,-88,36,-88,13,-88,4,-88,26,-88,33,-88,28,-88,32,-88,30,-88,27,-88,37,-88,23,-88,5,-88,45,-88,34,-88,46,-88,44,-88,10,-88,22,-102});
    states[80] = new State(-104);
    states[81] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,82,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[82] = new State(-84);
    states[83] = new State(-86);
    states[84] = new State(-87);
    states[85] = new State(-85);
    states[86] = new State(new int[]{35,87,31,-89,29,-89,36,-89,13,-89,4,-89,26,-89,33,-89,28,-89,32,-89,30,-89,27,-89,37,-89,23,-89,5,-89,45,-89,34,-89,46,-89,44,-89,10,-89});
    states[87] = new State(new int[]{14,20},new int[]{-10,88});
    states[88] = new State(-98);
    states[89] = new State(new int[]{35,-90,31,-90,29,-90,36,-90,13,-90,4,-90,26,-90,33,-90,28,-90,32,-90,30,-90,27,-90,37,-90,23,-90,5,-90,45,-90,34,-90,46,-90,44,-90,10,-90,22,-103});
    states[90] = new State(-106);
    states[91] = new State(-107);
    states[92] = new State(-91);
    states[93] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,94,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[94] = new State(new int[]{44,95,31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77});
    states[95] = new State(-92);
    states[96] = new State(new int[]{35,-93,31,-93,29,-93,36,-93,13,-93,4,-93,26,-93,33,-93,28,-93,32,-93,30,-93,27,-93,37,-93,23,-93,5,-93,45,-93,34,-93,46,-93,44,-93,10,-93,22,-101});
    states[97] = new State(-94);
    states[98] = new State(-95);
    states[99] = new State(-109);
    states[100] = new State(-96);
    states[101] = new State(-97);
    states[102] = new State(new int[]{22,103});
    states[103] = new State(new int[]{44,108,14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-38,104,-37,109,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[104] = new State(new int[]{44,105,10,106});
    states[105] = new State(-99);
    states[106] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,107,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[107] = new State(new int[]{31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,44,-66,10,-66});
    states[108] = new State(-100);
    states[109] = new State(new int[]{31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,44,-65,10,-65});
    states[110] = new State(-31);
    states[111] = new State(-50);
    states[112] = new State(new int[]{48,113,38,116,47,117});
    states[113] = new State(new int[]{14,20},new int[]{-10,114});
    states[114] = new State(new int[]{19,8},new int[]{-14,115});
    states[115] = new State(-28);
    states[116] = new State(-17);
    states[117] = new State(-18);
    states[118] = new State(-14);
    states[119] = new State(-15);
    states[120] = new State(-16);
    states[121] = new State(-48);
    states[122] = new State(-53);
    states[123] = new State(-59);
    states[124] = new State(new int[]{46,125});
    states[125] = new State(-54);
    states[126] = new State(new int[]{31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77,46,-60});
    states[127] = new State(-55);
    states[128] = new State(new int[]{22,129});
    states[129] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,130,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[130] = new State(new int[]{44,131,31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77});
    states[131] = new State(new int[]{46,123,14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99,15,128,53,136,43,142,19,24},new int[]{-30,132,-32,122,-33,124,-37,126,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102,-34,127,-35,135,-36,141,-13,146});
    states[132] = new State(new int[]{11,133});
    states[133] = new State(new int[]{46,123,14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99,15,128,53,136,43,142,19,24},new int[]{-30,134,-32,122,-33,124,-37,126,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102,-34,127,-35,135,-36,141,-13,146});
    states[134] = new State(-61);
    states[135] = new State(-56);
    states[136] = new State(new int[]{22,137});
    states[137] = new State(new int[]{14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,138,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[138] = new State(new int[]{44,139,31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77});
    states[139] = new State(new int[]{46,123,14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99,15,128,53,136,43,142,19,24},new int[]{-30,140,-32,122,-33,124,-37,126,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102,-34,127,-35,135,-36,141,-13,146});
    states[140] = new State(-62);
    states[141] = new State(-57);
    states[142] = new State(new int[]{46,145,14,20,37,83,23,84,50,90,25,91,22,93,21,97,18,99},new int[]{-37,143,-25,79,-10,80,-39,81,-40,85,-41,86,-42,89,-43,92,-44,96,-45,98,-46,100,-47,101,-48,102});
    states[143] = new State(new int[]{46,144,31,47,29,49,36,51,13,53,4,55,26,57,33,59,28,61,32,63,30,65,27,67,37,69,23,71,5,73,45,75,34,77});
    states[144] = new State(-63);
    states[145] = new State(-64);
    states[146] = new State(-58);
    states[147] = new State(-44);
    states[148] = new State(-45);
    states[149] = new State(-38);
    states[150] = new State(new int[]{22,151,10,-40,46,-40});
    states[151] = new State(new int[]{44,159,7,39,17,40,52,41,14,20},new int[]{-11,152,-12,160,-7,156,-22,35,-24,38,-25,158,-10,80,-23,110});
    states[152] = new State(new int[]{44,153,10,154});
    states[153] = new State(-7);
    states[154] = new State(new int[]{7,39,17,40,52,41,14,20},new int[]{-12,155,-7,156,-22,35,-24,38,-25,158,-10,80,-23,110});
    states[155] = new State(-10);
    states[156] = new State(new int[]{14,20},new int[]{-10,157});
    states[157] = new State(-11);
    states[158] = new State(new int[]{35,43,20,-33,14,-33});
    states[159] = new State(-8);
    states[160] = new State(-9);
    states[161] = new State(new int[]{19,24},new int[]{-13,162});
    states[162] = new State(-41);
    states[163] = new State(new int[]{22,151,35,-104,20,-104,14,-104});
    states[164] = new State(new int[]{19,24,38,-16,47,-16,48,-16,7,-16,17,-16,52,-16,14,-16},new int[]{-13,165});
    states[165] = new State(-42);
    states[166] = new State(-24);
    states[167] = new State(-25);
    states[168] = new State(-26);
    states[169] = new State(-27);
    states[170] = new State(-20);
    states[171] = new State(-21);
    states[172] = new State(new int[]{14,20},new int[]{-8,21,-10,173});
    states[173] = new State(new int[]{22,151});
    states[174] = new State(new int[]{39,118,38,119,47,120,3,-3},new int[]{-5,175,-6,176});
    states[175] = new State(-5);
    states[176] = new State(new int[]{38,116,47,117,7,39,17,40,52,41,14,20},new int[]{-7,172,-22,35,-24,38,-25,158,-10,80,-23,110});
    states[177] = new State(-4);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-1, new int[]{-4});
    rules[4] = new Rule(-4, new int[]{-5});
    rules[5] = new Rule(-4, new int[]{-4,-5});
    rules[6] = new Rule(-5, new int[]{-6,-7,-8,-9});
    rules[7] = new Rule(-8, new int[]{-10,22,-11,44});
    rules[8] = new Rule(-8, new int[]{-10,22,44});
    rules[9] = new Rule(-11, new int[]{-12});
    rules[10] = new Rule(-11, new int[]{-11,10,-12});
    rules[11] = new Rule(-12, new int[]{-7,-10});
    rules[12] = new Rule(-9, new int[]{-13});
    rules[13] = new Rule(-3, new int[]{-6,8,-10,-14});
    rules[14] = new Rule(-6, new int[]{39});
    rules[15] = new Rule(-6, new int[]{38});
    rules[16] = new Rule(-6, new int[]{47});
    rules[17] = new Rule(-6, new int[]{-6,38});
    rules[18] = new Rule(-6, new int[]{-6,47});
    rules[19] = new Rule(-14, new int[]{19,-15,41});
    rules[20] = new Rule(-14, new int[]{19,41});
    rules[21] = new Rule(-15, new int[]{-16});
    rules[22] = new Rule(-15, new int[]{-15,-16});
    rules[23] = new Rule(-16, new int[]{-17,46});
    rules[24] = new Rule(-16, new int[]{-5});
    rules[25] = new Rule(-16, new int[]{-18});
    rules[26] = new Rule(-16, new int[]{-19});
    rules[27] = new Rule(-16, new int[]{-20});
    rules[28] = new Rule(-20, new int[]{-6,48,-10,-14});
    rules[29] = new Rule(-17, new int[]{-6,-7,-21});
    rules[30] = new Rule(-7, new int[]{-22});
    rules[31] = new Rule(-7, new int[]{-23});
    rules[32] = new Rule(-22, new int[]{-24});
    rules[33] = new Rule(-22, new int[]{-25});
    rules[34] = new Rule(-23, new int[]{-22,20,42});
    rules[35] = new Rule(-24, new int[]{7});
    rules[36] = new Rule(-24, new int[]{17});
    rules[37] = new Rule(-24, new int[]{52});
    rules[38] = new Rule(-21, new int[]{-26});
    rules[39] = new Rule(-21, new int[]{-21,10,-26});
    rules[40] = new Rule(-26, new int[]{-10});
    rules[41] = new Rule(-18, new int[]{-6,-8,-13});
    rules[42] = new Rule(-19, new int[]{47,-13});
    rules[43] = new Rule(-13, new int[]{19,-27,41});
    rules[44] = new Rule(-13, new int[]{19,41});
    rules[45] = new Rule(-27, new int[]{-28});
    rules[46] = new Rule(-27, new int[]{-27,-28});
    rules[47] = new Rule(-28, new int[]{-29});
    rules[48] = new Rule(-28, new int[]{-30});
    rules[49] = new Rule(-29, new int[]{-7,-31,46});
    rules[50] = new Rule(-29, new int[]{-20});
    rules[51] = new Rule(-31, new int[]{-10});
    rules[52] = new Rule(-31, new int[]{-31,10,-10});
    rules[53] = new Rule(-30, new int[]{-32});
    rules[54] = new Rule(-30, new int[]{-33,46});
    rules[55] = new Rule(-30, new int[]{-34});
    rules[56] = new Rule(-30, new int[]{-35});
    rules[57] = new Rule(-30, new int[]{-36});
    rules[58] = new Rule(-30, new int[]{-13});
    rules[59] = new Rule(-32, new int[]{46});
    rules[60] = new Rule(-33, new int[]{-37});
    rules[61] = new Rule(-34, new int[]{15,22,-37,44,-30,11,-30});
    rules[62] = new Rule(-35, new int[]{53,22,-37,44,-30});
    rules[63] = new Rule(-36, new int[]{43,-37,46});
    rules[64] = new Rule(-36, new int[]{43,46});
    rules[65] = new Rule(-38, new int[]{-37});
    rules[66] = new Rule(-38, new int[]{-38,10,-37});
    rules[67] = new Rule(-37, new int[]{-25,12,-37});
    rules[68] = new Rule(-37, new int[]{-37,31,-37});
    rules[69] = new Rule(-37, new int[]{-37,29,-37});
    rules[70] = new Rule(-37, new int[]{-37,36,-37});
    rules[71] = new Rule(-37, new int[]{-37,13,-37});
    rules[72] = new Rule(-37, new int[]{-37,4,-37});
    rules[73] = new Rule(-37, new int[]{-37,26,-37});
    rules[74] = new Rule(-37, new int[]{-37,33,-37});
    rules[75] = new Rule(-37, new int[]{-37,28,-37});
    rules[76] = new Rule(-37, new int[]{-37,32,-37});
    rules[77] = new Rule(-37, new int[]{-37,30,-37});
    rules[78] = new Rule(-37, new int[]{-37,27,-37});
    rules[79] = new Rule(-37, new int[]{-37,37,-37});
    rules[80] = new Rule(-37, new int[]{-37,23,-37});
    rules[81] = new Rule(-37, new int[]{-37,5,-37});
    rules[82] = new Rule(-37, new int[]{-37,45,-37});
    rules[83] = new Rule(-37, new int[]{-37,34,-37});
    rules[84] = new Rule(-37, new int[]{-39,-37});
    rules[85] = new Rule(-37, new int[]{-40});
    rules[86] = new Rule(-39, new int[]{37});
    rules[87] = new Rule(-39, new int[]{23});
    rules[88] = new Rule(-40, new int[]{-25});
    rules[89] = new Rule(-40, new int[]{-41});
    rules[90] = new Rule(-41, new int[]{-42});
    rules[91] = new Rule(-41, new int[]{-43});
    rules[92] = new Rule(-43, new int[]{22,-37,44});
    rules[93] = new Rule(-43, new int[]{-44});
    rules[94] = new Rule(-44, new int[]{21});
    rules[95] = new Rule(-44, new int[]{-45});
    rules[96] = new Rule(-44, new int[]{-46});
    rules[97] = new Rule(-44, new int[]{-47});
    rules[98] = new Rule(-46, new int[]{-41,35,-10});
    rules[99] = new Rule(-47, new int[]{-48,22,-38,44});
    rules[100] = new Rule(-47, new int[]{-48,22,44});
    rules[101] = new Rule(-48, new int[]{-44});
    rules[102] = new Rule(-48, new int[]{-25});
    rules[103] = new Rule(-48, new int[]{-42});
    rules[104] = new Rule(-25, new int[]{-10});
    rules[105] = new Rule(-25, new int[]{-25,35,-10});
    rules[106] = new Rule(-42, new int[]{50});
    rules[107] = new Rule(-42, new int[]{25});
    rules[108] = new Rule(-10, new int[]{14});
    rules[109] = new Rule(-45, new int[]{18});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // CompilationUnit -> ClassDeclaration
{CurrentSemanticValue = new Identifier("Not Implemented: ClassDeclaration");}
        break;
      case 3: // CompilationUnit -> MethodDeclarations
{CurrentSemanticValue = new CompilationUnit(ValueStack[ValueStack.Depth-1]);}
        break;
      case 4: // MethodDeclarations -> MethodDeclaration
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];  }
        break;
      case 5: // MethodDeclarations -> MethodDeclarations, MethodDeclaration
{ ValueStack[ValueStack.Depth-2].makeSibling(ValueStack[ValueStack.Depth-1]); CurrentSemanticValue = ValueStack[ValueStack.Depth-2];}
        break;
      case 6: // MethodDeclaration -> Modifiers, TypeSpecifier, MethodSignature, MethodBody
{CurrentSemanticValue = new MethodDeclaration(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 7: // MethodSignature -> Identifier, LPAREN, ParameterList, RPAREN
{ CurrentSemanticValue = new MethodSignature(ValueStack[ValueStack.Depth-4], ValueStack[ValueStack.Depth-2]); }
        break;
      case 8: // MethodSignature -> Identifier, LPAREN, RPAREN
{ CurrentSemanticValue = new MethodSignature(ValueStack[ValueStack.Depth-3]); }
        break;
      case 9: // ParameterList -> Parameter
{ CurrentSemanticValue = new ParameterList(ValueStack[ValueStack.Depth-1]); }
        break;
      case 10: // ParameterList -> ParameterList, COMMA, Parameter
{ ValueStack[ValueStack.Depth-3].adoptChildren(ValueStack[ValueStack.Depth-1]); CurrentSemanticValue = ValueStack[ValueStack.Depth-3];}
        break;
      case 11: // Parameter -> TypeSpecifier, Identifier
{ CurrentSemanticValue = new Parameter(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 12: // MethodBody -> Block
{ CurrentSemanticValue = new MethodBody(ValueStack[ValueStack.Depth-1]); }
        break;
      case 14: // Modifiers -> PUBLIC
{ CurrentSemanticValue = new Modifiers(ModifierType.PUBLIC);}
        break;
      case 15: // Modifiers -> PRIVATE
{ CurrentSemanticValue = new Modifiers(ModifierType.PRIVATE);}
        break;
      case 16: // Modifiers -> STATIC
{ CurrentSemanticValue = new Modifiers(ModifierType.STATIC);}
        break;
      case 17: // Modifiers -> Modifiers, PRIVATE
{ CurrentSemanticValue = new Identifier("Not Implemented: Modifier List");}
        break;
      case 18: // Modifiers -> Modifiers, STATIC
{ CurrentSemanticValue = new Identifier("Not Implemented: Modifier List");}
        break;
      case 28: // StructDeclaration -> Modifiers, STRUCT, Identifier, ClassBody
{ CurrentSemanticValue = new Identifier("Not Implemented: StructDeclaration");}
        break;
      case 29: // FieldVariableDeclaration -> Modifiers, TypeSpecifier, FieldVariableDeclarators
{}
        break;
      case 30: // TypeSpecifier -> TypeName
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 32: // TypeName -> PrimitiveType
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 34: // ArraySpecifier -> TypeName, LBRACKET, RBRACKET
{}
        break;
      case 35: // PrimitiveType -> BOOLEAN
{ CurrentSemanticValue = new PrimitiveType(EnumPrimitiveType.BOOLEAN); }
        break;
      case 36: // PrimitiveType -> INT
{ CurrentSemanticValue = new PrimitiveType(EnumPrimitiveType.INT); }
        break;
      case 37: // PrimitiveType -> VOID
{ CurrentSemanticValue = new PrimitiveType(EnumPrimitiveType.VOID); }
        break;
      case 38: // FieldVariableDeclarators -> FieldVariableDeclaratorName
{}
        break;
      case 39: // FieldVariableDeclarators -> FieldVariableDeclarators, COMMA, 
               //                             FieldVariableDeclaratorName
{}
        break;
      case 40: // FieldVariableDeclaratorName -> Identifier
{}
        break;
      case 41: // ConstructorDeclaration -> Modifiers, MethodSignature, Block
{}
        break;
      case 42: // StaticInitializer -> STATIC, Block
{}
        break;
      case 43: // Block -> LBRACE, LocalItems, RBRACE
{ CurrentSemanticValue = new Block(ValueStack[ValueStack.Depth-2]); }
        break;
      case 44: // Block -> LBRACE, RBRACE
{ CurrentSemanticValue =  new Identifier("Not Implemented: Block"); }
        break;
      case 45: // LocalItems -> LocalItem
{ CurrentSemanticValue = new LocalItems(ValueStack[ValueStack.Depth-1]); }
        break;
      case 46: // LocalItems -> LocalItems, LocalItem
{ CurrentSemanticValue = new LocalItems(ValueStack[ValueStack.Depth-2], ValueStack[ValueStack.Depth-1]); }
        break;
      case 47: // LocalItem -> LocalVariableDeclaration
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 48: // LocalItem -> Statement
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1] ;}
        break;
      case 49: // LocalVariableDeclaration -> TypeSpecifier, LocalVariableNames, SEMICOLON
{ CurrentSemanticValue = new LocalVariableDeclaration (ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-2]); }
        break;
      case 52: // LocalVariableNames -> LocalVariableNames, COMMA, Identifier
{ CurrentSemanticValue = new LocalVariableNames(ValueStack[ValueStack.Depth-3], ValueStack[ValueStack.Depth-1]); }
        break;
      case 54: // Statement -> ExpressionStatement, SEMICOLON
{ CurrentSemanticValue = new Statement(ValueStack[ValueStack.Depth-2]);}
        break;
      case 60: // ExpressionStatement -> Expression
{CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 67: // Expression -> QualifiedName, EQUALS, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.EQUALS, ValueStack[ValueStack.Depth-1]); }
        break;
      case 68: // Expression -> Expression, OP_LOR, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_LOR, ValueStack[ValueStack.Depth-1]); }
        break;
      case 69: // Expression -> Expression, OP_LAND, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_LAND, ValueStack[ValueStack.Depth-1]); }
        break;
      case 70: // Expression -> Expression, PIPE, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.PIPE, ValueStack[ValueStack.Depth-1]); }
        break;
      case 71: // Expression -> Expression, HAT, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.HAT, ValueStack[ValueStack.Depth-1]); }
        break;
      case 72: // Expression -> Expression, AND, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.AND, ValueStack[ValueStack.Depth-1]); }
        break;
      case 73: // Expression -> Expression, OP_EQ, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_EQ, ValueStack[ValueStack.Depth-1]); }
        break;
      case 74: // Expression -> Expression, OP_NE, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_NE, ValueStack[ValueStack.Depth-1]); }
        break;
      case 75: // Expression -> Expression, OP_GT, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_GT, ValueStack[ValueStack.Depth-1]); }
        break;
      case 76: // Expression -> Expression, OP_LT, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_LT, ValueStack[ValueStack.Depth-1]); }
        break;
      case 77: // Expression -> Expression, OP_LE, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_LE, ValueStack[ValueStack.Depth-1]); }
        break;
      case 78: // Expression -> Expression, OP_GE, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.OP_GE, ValueStack[ValueStack.Depth-1]); }
        break;
      case 79: // Expression -> Expression, PLUSOP, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.PLUSOP, ValueStack[ValueStack.Depth-1]); }
        break;
      case 80: // Expression -> Expression, MINUSOP, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.MINUSOP, ValueStack[ValueStack.Depth-1]); }
        break;
      case 81: // Expression -> Expression, ASTERISK, Expression
{ CurrentSemanticValue = new Expression(ValueStack[ValueStack.Depth-3], ExprKind.ASTERISK, ValueStack[ValueStack.Depth-1]); }
        break;
      case 85: // Expression -> PrimaryExpression
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 88: // PrimaryExpression -> QualifiedName
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 89: // PrimaryExpression -> NotJustName
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 90: // NotJustName -> SpecialName
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 91: // NotJustName -> ComplexPrimary
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 92: // ComplexPrimary -> LPAREN, Expression, RPAREN
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-2];}
        break;
      case 93: // ComplexPrimary -> ComplexPrimaryNoParenthesis
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 94: // ComplexPrimaryNoParenthesis -> LITERAL
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 95: // ComplexPrimaryNoParenthesis -> Number
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 96: // ComplexPrimaryNoParenthesis -> FieldAccess
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 97: // ComplexPrimaryNoParenthesis -> MethodCall
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1];}
        break;
      case 98: // FieldAccess -> NotJustName, PERIOD, Identifier
{ CurrentSemanticValue = new Identifier("Not Implemented: FieldAccess");}
        break;
      case 99: // MethodCall -> MethodReference, LPAREN, ArgumentList, RPAREN
{ CurrentSemanticValue =  new Identifier("Not Implemented: MethodCall"); }
        break;
      case 100: // MethodCall -> MethodReference, LPAREN, RPAREN
{ CurrentSemanticValue = new Identifier("Not Implemented: MethodCall");}
        break;
      case 104: // QualifiedName -> Identifier
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 108: // Identifier -> IDENTIFIER
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
      case 109: // Number -> INT_NUMBER
{ CurrentSemanticValue = ValueStack[ValueStack.Depth-1]; }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
