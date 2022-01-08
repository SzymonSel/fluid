﻿using Fluid.Values;

namespace Fluid.Ast.BinaryExpressions
{
    internal sealed class AndBinaryExpression : BinaryExpression
    {
        public AndBinaryExpression(Expression left, Expression right) : base(left, right)
        {
        }

        protected override FluidValue Evaluate(FluidValue leftValue, FluidValue rightValue)
        {
            return BooleanValue.Create(leftValue.ToBooleanValue() && rightValue.ToBooleanValue());
        }
    }
}