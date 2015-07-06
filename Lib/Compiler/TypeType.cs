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

namespace SharpExpressions.Compiler
{
    static class TypeType
    {
        public static Types.TypeDefinition definition = new Types.TypeDefinition()
        {
            convert = (ref Value v) =>
            {
            },

            ternary = (Value[] v, ref Value res) =>
            {
                res.objectValue = v[2].boolValue ? v[0].objectValue : v[1].objectValue;
            },
        };
    }
}
