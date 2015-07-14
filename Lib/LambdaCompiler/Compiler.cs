﻿//--------------------------------------------------------------------------------------
// Copyright 2015 - Alberto Alonso
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using SharpExpressions.Parser;
using Antlr.Runtime;

namespace SharpExpressions.LambdaCompiler
{
    class Compiler : ICompiler
    {
        public CompiledExpression compile(string expression, Registry registry)
        {
            ANTLRStringStream stream = new ANTLRStringStream(expression);
            SharpExpressionsLexer lexer = new SharpExpressionsLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            SharpExpressionsParser parser = new SharpExpressionsParser(tokens);
            Instruction[] instructions = CodeGenerator.generate(parser.eval(), registry);
            return (reg) => Executor.execute(instructions, reg);
        }
    }
}