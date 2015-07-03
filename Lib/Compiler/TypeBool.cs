﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpExpressions.Compiler
{
    static class TypeBool
    {
        public static Types.TypeDefinition definition = new Types.TypeDefinition()
        {
            convert = (ref Value v) =>
            {
                switch (v.type)
                {
                    case Value.Type.Boolean:
                        break;
                    case Value.Type.String:
                        v.boolValue = Boolean.Parse(v.stringValue);
                        break;
                    case Value.Type.Double:
                        v.boolValue = v.doubleValue == 0.0 ? false : true;
                        break;
                }
            },

            pow = (Value[] v, ref Value res) =>
            {
                res.boolValue = v[0].boolValue ^ v[1].boolValue;
            },
        };
    }
}
