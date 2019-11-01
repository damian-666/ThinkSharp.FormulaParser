﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ThinkSharp.FormulaParsing.Ast.Nodes;

namespace ThinkSharp.FormulaParsing.TermRewriting.Rules
{
    public class RemoveNegativeSignInInSum : Rule
    {
        protected override bool MatchInternal(Node node, Node Parent)
        {
            return node is BinaryOperatorNode binOp 
                && binOp.BinaryOperator.Symbol == "+"
                && binOp.LeftNode is SignedNode signedNode
                && signedNode.Sign == Sign.Minus;
        }

        protected override Node RewriteInternal(Node node, Node Parent)
        {
            if (node is BinaryOperatorNode binOp
                && binOp.BinaryOperator.Symbol == "+"
                && binOp.LeftNode is SignedNode signedNode
                && signedNode.Sign == Sign.Minus)
            {
                return new BinaryOperatorNode(
                    BinaryOperator.BySymbol("-"),
                    binOp.RightNode,
                    signedNode.Node);
            }

            Debug.Fail("Should not happen");
            return node;
        }
    }
}