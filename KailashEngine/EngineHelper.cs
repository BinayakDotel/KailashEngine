﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;

namespace KailashEngine
{
    static class EngineHelper
    {

        //------------------------------------------------------
        // Constants
        //------------------------------------------------------
        public enum size : int
        {
            vec2 = sizeof(float) * 2,
            vec3 = sizeof(float) * 3,
            vec4 = sizeof(float) * 4,
            mat2 = sizeof(float) * 4,
            mat3 = sizeof(float) * 9,
            mat4 = sizeof(float) * 16,
        }

        //------------------------------------------------------
        // Interpolation functions
        //------------------------------------------------------

        public static float lerp(float src0, float src1, float t)
        {
            return src0 + (src1 - src0) * (1.0f / t);
        }
        public static Vector2 lerp(Vector2 src0, Vector2 src1, float t)
        {
            return src0 + (src1 - src0) * (1.0f / t);
        }
        public static Vector3 lerp(Vector3 src0, Vector3 src1, float t)
        {
            return src0 + (src1 - src0) * (1.0f / t);
        }

        public static float slerp(float src0, float src1, float t)
        {
            src0 = Math.Max(src0, 0.000001f);
            return (float)(Math.Pow(src1 / src0, t) * src0);
        }



    }
}