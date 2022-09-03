#if BURST_INTERNAL || UNITY_BURST_EXPERIMENTAL_NEON_INTRINSICS
using System;
using System.Diagnostics;

namespace Unity.Burst.Intrinsics
{
    public unsafe static partial class Arm
    {
        /// <summary>
        /// Neon intrinsics
        /// </summary>
        public unsafe partial class Neon
        {
            /// <summary>
            /// Evaluates to true at compile time if Neon intrinsics are supported.
            /// </summary>
            public static bool IsNeonSupported { get { return false; } }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_u8(v64 a0, v64 a1)
            {
                return vadd_s8(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_u8(v128 a0, v128 a1)
            {
                return vaddq_s8(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_u16(v64 a0, v64 a1)
            {
                return vadd_s16(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_u16(v128 a0, v128 a1)
            {
                return vaddq_s16(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_u32(v64 a0, v64 a1)
            {
                return vadd_s32(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_u32(v128 a0, v128 a1)
            {
                return vaddq_s32(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_u64(v64 a0, v64 a1)
            {
                return vadd_s64(a0, a1);
            }

            /// <summary>Add (vector). This instruction adds corresponding elements in the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_u64(v128 a0, v128 a1)
            {
                return vaddq_s64(a0, a1);
            }

            /// <summary>Floating-point Add (vector). This instruction adds corresponding vector elements in the two source SIMD&amp;FP registers, writes the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vadd_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Add (vector). This instruction adds corresponding vector elements in the two source SIMD&amp;FP registers, writes the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.  The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SADDL instruction extracts each source vector from the lower half of each source register, while the SADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long (vector). This instruction adds each vector element in the lower or upper half of the first source SIMD&amp;FP register to the corresponding vector element of the second source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UADDL instruction extracts each source vector from the lower half of each source register, while the UADDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.8H,Vn.8H,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_s8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.4S,Vn.4S,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_s16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Wide. This instruction adds vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the SIMD&amp;FP destination register.The SADDW instruction extracts the second source vector from the lower half of the second source register, while the SADDW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDW Vd.2D,Vn.2D,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_s32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.8H,Vn.8H,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_u8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.4S,Vn.4S,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_u16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Wide. This instruction adds the vector elements of the first source SIMD&amp;FP register to the corresponding vector elements in the lower or upper half of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register. All the values in this instruction are unsigned integer values.The UADDW instruction extracts vector elements from the lower half of the second source register, while the UADDW2 instruction extracts vector elements from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDW Vd.2D,Vn.2D,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vaddw_u32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SRHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vhadd_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see URHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vhaddq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Halving Add. This instruction adds corresponding signed integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRHADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrhadd_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Halving Add. This instruction adds corresponding unsigned integer values from the two source SIMD&amp;FP registers, shifts each result right one bit, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see UHADD.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URHADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrhaddq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqadd_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Add. This instruction adds the values of corresponding elements of the two source SIMD&amp;FP registers, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQADD Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqaddq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_u16(v128 a0, v128 a1)
            {
                return vaddhn_s16(a0, a1);
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_u32(v128 a0, v128 a1)
            {
                return vaddhn_s32(a0, a1);
            }

            /// <summary>Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are truncated. For rounded results, see RADDHN.The ADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the ADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vaddhn_u64(v128 a0, v128 a1)
            {
                return vaddhn_s64(a0, a1);
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_u16(v128 a0, v128 a1)
            {
                return vraddhn_s16(a0, a1);
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_u32(v128 a0, v128 a1)
            {
                return vraddhn_s32(a0, a1);
            }

            /// <summary>Rounding Add returning High Narrow. This instruction adds each vector element in the first source SIMD&amp;FP register to the corresponding vector element in the second source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see ADDHN.The RADDHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RADDHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RADDHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vraddhn_u64(v128 a0, v128 a1)
            {
                return vraddhn_s64(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_u8(v64 a0, v64 a1)
            {
                return vmul_s8(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_u8(v128 a0, v128 a1)
            {
                return vmulq_s8(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_u16(v64 a0, v64 a1)
            {
                return vmul_s16(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_u16(v128 a0, v128 a1)
            {
                return vmulq_s16(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_u32(v64 a0, v64 a1)
            {
                return vmul_s32(a0, a1);
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_u32(v128 a0, v128 a1)
            {
                return vmulq_s32(a0, a1);
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_s8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_s8(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_s16(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_s16(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_s32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_s32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_u8(v64 a0, v64 a1, v64 a2)
            {
                return vmla_s8(a0, a1, a2);
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_u8(v128 a0, v128 a1, v128 a2)
            {
                return vmlaq_s8(a0, a1, a2);
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_u16(v64 a0, v64 a1, v64 a2)
            {
                return vmla_s16(a0, a1, a2);
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_u16(v128 a0, v128 a1, v128 a2)
            {
                return vmlaq_s16(a0, a1, a2);
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_u32(v64 a0, v64 a1, v64 a2)
            {
                return vmla_s32(a0, a1, a2);
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_u32(v128 a0, v128 a1, v128 a2)
            {
                return vmlaq_s32(a0, a1, a2);
            }

            /// <summary>Floating-point multiply-add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * c[i]) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_f32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point multiply-add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * c[i]) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_f32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_s8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_s16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_s32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_u8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_u16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_u32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_s8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_s8(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_s16(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_s16(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_s32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_s32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_u8(v64 a0, v64 a1, v64 a2)
            {
                return vmls_s8(a0, a1, a2);
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_u8(v128 a0, v128 a1, v128 a2)
            {
                return vmlsq_s8(a0, a1, a2);
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_u16(v64 a0, v64 a1, v64 a2)
            {
                return vmls_s16(a0, a1, a2);
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_u16(v128 a0, v128 a1, v128 a2)
            {
                return vmlsq_s16(a0, a1, a2);
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_u32(v64 a0, v64 a1, v64 a2)
            {
                return vmls_s32(a0, a1, a2);
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_u32(v128 a0, v128 a1, v128 a2)
            {
                return vmlsq_s32(a0, a1, a2);
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * c[i]) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_f32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * c[i]) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_f32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_s8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_s16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_s32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_u8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_u16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_u32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Add to accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results in the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLA Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vfma_f32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Add to accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results in the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLA Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vfmaq_f32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Subtract from accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLS Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vfms_f32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Subtract from accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLS Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vfmsq_f32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_s16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_s32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_s16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_s32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_u8(v64 a0, v64 a1)
            {
                return vsub_s8(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_u8(v128 a0, v128 a1)
            {
                return vsubq_s8(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_u16(v64 a0, v64 a1)
            {
                return vsub_s16(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_u16(v128 a0, v128 a1)
            {
                return vsubq_s16(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_u32(v64 a0, v64 a1)
            {
                return vsub_s32(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_u32(v128 a0, v128 a1)
            {
                return vsubq_s32(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_u64(v64 a0, v64 a1)
            {
                return vsub_s64(a0, a1);
            }

            /// <summary>Subtract (vector). This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUB Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_u64(v128 a0, v128 a1)
            {
                return vsubq_s64(a0, a1);
            }

            /// <summary>Floating-point Subtract (vector). This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register, from the corresponding elements in the vector in the first source SIMD&amp;FP register, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FSUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vsub_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Subtract (vector). This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register, from the corresponding elements in the vector in the first source SIMD&amp;FP register, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FSUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are twice as long as the source vector elements.The SSUBL instruction extracts each source vector from the lower half of each source register, while the SSUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are twice as long as the source vector elements.The SSUBL instruction extracts each source vector from the lower half of each source register, while the SSUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are twice as long as the source vector elements.The SSUBL instruction extracts each source vector from the lower half of each source register, while the SSUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The destination vector elements are twice as long as the source vector elements.The USUBL instruction extracts each source vector from the lower half of each source register, while the USUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The destination vector elements are twice as long as the source vector elements.The USUBL instruction extracts each source vector from the lower half of each source register, while the USUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Long. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The destination vector elements are twice as long as the source vector elements.The USUBL instruction extracts each source vector from the lower half of each source register, while the USUBL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Wide. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The SSUBW instruction extracts the second source vector from the lower half of the second source register, while the SSUBW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBW Vd.8H,Vn.8H,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_s8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Wide. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The SSUBW instruction extracts the second source vector from the lower half of the second source register, while the SSUBW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBW Vd.4S,Vn.4S,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_s16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Subtract Wide. This instruction subtracts each vector element in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The SSUBW instruction extracts the second source vector from the lower half of the second source register, while the SSUBW2 instruction extracts the second source vector from the upper half of the second source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSUBW Vd.2D,Vn.2D,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_s32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Wide. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element in the lower or upper half of the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register.The USUBW instruction extracts vector elements from the lower half of the first source register, while the USUBW2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBW Vd.8H,Vn.8H,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_u8(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Wide. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element in the lower or upper half of the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register.The USUBW instruction extracts vector elements from the lower half of the first source register, while the USUBW2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBW Vd.4S,Vn.4S,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_u16(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Subtract Wide. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element in the lower or upper half of the first source SIMD&amp;FP register, places the result in a vector, and writes the vector to the SIMD&amp;FP destination register. All the values in this instruction are signed integer values.The vector elements of the destination register and the first source register are twice as long as the vector elements of the second source register.The USUBW instruction extracts vector elements from the lower half of the first source register, while the USUBW2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USUBW Vd.2D,Vn.2D,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vsubw_u32(v128 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Halving Subtract. This instruction subtracts the elements in the vector in the second source SIMD&amp;FP register from the corresponding elements in the vector in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into elements of a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHSUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vhsub_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Halving Subtract. This instruction subtracts the vector elements in the second source SIMD&amp;FP register from the corresponding vector elements in the first source SIMD&amp;FP register, shifts each result right one bit, places each result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UHSUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vhsubq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSUB Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqsub_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Subtract. This instruction subtracts the element values of the second source SIMD&amp;FP register from the corresponding element values of the first source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSUB Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqsubq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_u16(v128 a0, v128 a1)
            {
                return vsubhn_s16(a0, a1);
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_u32(v128 a0, v128 a1)
            {
                return vsubhn_s32(a0, a1);
            }

            /// <summary>Subtract returning High Narrow. This instruction subtracts each vector element in the second source SIMD&amp;FP register from the corresponding vector element in the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.The results are truncated. For rounded results, see RSUBHN.The SUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SUBHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vsubhn_u64(v128 a0, v128 a1)
            {
                return vsubhn_s64(a0, a1);
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.8B,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_u16(v128 a0, v128 a1)
            {
                return vrsubhn_s16(a0, a1);
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.4H,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_u32(v128 a0, v128 a1)
            {
                return vrsubhn_s32(a0, a1);
            }

            /// <summary>Rounding Subtract returning High Narrow. This instruction subtracts each vector element of the second source SIMD&amp;FP register from the corresponding vector element of the first source SIMD&amp;FP register, places the most significant half of the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SUBHN.The RSUBHN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSUBHN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSUBHN Vd.2S,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsubhn_u64(v128 a0, v128 a1)
            {
                return vrsubhn_s64(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_u8(v64 a0, v64 a1)
            {
                return vceq_s8(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_u8(v128 a0, v128 a1)
            {
                return vceqq_s8(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_u16(v64 a0, v64 a1)
            {
                return vceq_s16(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_u16(v128 a0, v128 a1)
            {
                return vceqq_s16(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_u32(v64 a0, v64 a1)
            {
                return vceq_s32(a0, a1);
            }

            /// <summary>Compare bitwise Equal (vector). This instruction compares each vector element from the first source SIMD&amp;FP register with the corresponding vector element from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMEQ Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_u32(v128 a0, v128 a1)
            {
                return vceqq_s32(a0, a1);
            }

            /// <summary>Floating-point Compare Equal (vector). This instruction compares each floating-point value from the first source SIMD&amp;FP register, with the corresponding floating-point value from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMEQ Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vceq_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Equal (vector). This instruction compares each floating-point value from the first source SIMD&amp;FP register, with the corresponding floating-point value from the second source SIMD&amp;FP register, and if the comparison is equal sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMEQ Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vceqq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than or Equal (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than or equal to the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGE Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcge_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than or Equal (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than or equal to the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGE Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgeq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than or Equal (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than or equal to the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGE Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher or Same (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than or equal to the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHS Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than or Equal (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than or equal to the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGE Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcle_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than or Equal (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than or equal to the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGE Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcleq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGT Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcgt_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGT Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcgtq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare signed Greater than (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first signed integer value is greater than the second signed integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMGT Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.8B,Vm.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.16B,Vm.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.4H,Vm.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.8H,Vm.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare unsigned Higher (vector). This instruction compares each vector element in the first source SIMD&amp;FP register with the corresponding vector element in the second source SIMD&amp;FP register and if the first unsigned integer value is greater than the second unsigned integer value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMHI Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGT Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vclt_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Compare Greater than (vector). This instruction reads each floating-point value in the first source SIMD&amp;FP register and if the value is greater than the corresponding floating-point value in the second source SIMD&amp;FP register sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCMGT Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcltq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than or Equal (vector). This instruction compares the absolute value of each floating-point value in the first source SIMD&amp;FP register with the absolute value of the corresponding floating-point value in the second source SIMD&amp;FP register and if the first value is greater than or equal to the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGE Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcage_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than or Equal (vector). This instruction compares the absolute value of each floating-point value in the first source SIMD&amp;FP register with the absolute value of the corresponding floating-point value in the second source SIMD&amp;FP register and if the first value is greater than or equal to the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGE Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcageq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than or Equal (vector). This instruction compares the absolute value of each floating-point value in the first source SIMD&amp;FP register with the absolute value of the corresponding floating-point value in the second source SIMD&amp;FP register and if the first value is greater than or equal to the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGE Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcale_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than or Equal (vector). This instruction compares the absolute value of each floating-point value in the first source SIMD&amp;FP register with the absolute value of the corresponding floating-point value in the second source SIMD&amp;FP register and if the first value is greater than or equal to the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGE Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcaleq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than (vector). This instruction compares the absolute value of each vector element in the first source SIMD&amp;FP register with the absolute value of the corresponding vector element in the second source SIMD&amp;FP register and if the first value is greater than the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGT Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcagt_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than (vector). This instruction compares the absolute value of each vector element in the first source SIMD&amp;FP register with the absolute value of the corresponding vector element in the second source SIMD&amp;FP register and if the first value is greater than the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGT Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcagtq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than (vector). This instruction compares the absolute value of each vector element in the first source SIMD&amp;FP register with the absolute value of the corresponding vector element in the second source SIMD&amp;FP register and if the first value is greater than the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGT Vd.2S,Vm.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcalt_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Compare Greater than (vector). This instruction compares the absolute value of each vector element in the first source SIMD&amp;FP register with the absolute value of the corresponding vector element in the second source SIMD&amp;FP register and if the first value is greater than the second value sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FACGT Vd.4S,Vm.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcaltq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_u8(v64 a0, v64 a1)
            {
                return vtst_s8(a0, a1);
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_u8(v128 a0, v128 a1)
            {
                return vtstq_s8(a0, a1);
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_u16(v64 a0, v64 a1)
            {
                return vtst_s16(a0, a1);
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_u16(v128 a0, v128 a1)
            {
                return vtstq_s16(a0, a1);
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vtst_u32(v64 a0, v64 a1)
            {
                return vtst_s32(a0, a1);
            }

            /// <summary>Compare bitwise Test bits nonzero (vector). This instruction reads each vector element in the first source SIMD&amp;FP register, performs an AND with the corresponding vector element in the second source SIMD&amp;FP register, and if the result is not zero, sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to one, otherwise sets every bit of the corresponding vector element in the destination SIMD&amp;FP register to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CMTST Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vtstq_u32(v128 a0, v128 a1)
            {
                return vtstq_s32(a0, a1);
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference (vector). This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, places the the absolute values of the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Difference (vector). This instruction subtracts the floating-point values in the elements of the second source SIMD&amp;FP register, from the corresponding floating-point values in the elements of the first source SIMD&amp;FP register, places the absolute value of each result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FABD Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vabd_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute Difference (vector). This instruction subtracts the floating-point values in the elements of the second source SIMD&amp;FP register, from the corresponding floating-point values in the elements of the first source SIMD&amp;FP register, places the absolute value of each result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FABD Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference Long. This instruction subtracts the vector elements of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the results into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABDL instruction writes the vector to the lower half of the destination register and clears the upper half, while the SABDL2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference Long. This instruction subtracts the vector elements of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the results into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABDL instruction writes the vector to the lower half of the destination register and clears the upper half, while the SABDL2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute Difference Long. This instruction subtracts the vector elements of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the results into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABDL instruction writes the vector to the lower half of the destination register and clears the upper half, while the SABDL2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABDL instruction extracts each source vector from the lower half of each source register, while the UABDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABDL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABDL instruction extracts each source vector from the lower half of each source register, while the UABDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABDL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute Difference Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, places the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABDL instruction extracts each source vector from the lower half of each source register, while the UABDL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABDL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabdl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_s8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_s8(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_s16(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_s16(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_s32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABA Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_s32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_u8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_u8(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_u16(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_u16(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vaba_u32(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate. This instruction subtracts the elements of the vector of the second source SIMD&amp;FP register from the corresponding elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the elements of the vector of the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABA Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabaq_u32(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABAL instruction extracts each source vector from the lower half of each source register, while the SABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABAL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_s8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABAL instruction extracts each source vector from the lower half of each source register, while the SABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABAL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_s16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The SABAL instruction extracts each source vector from the lower half of each source register, while the SABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SABAL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_s32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABAL instruction extracts each source vector from the lower half of each source register, while the UABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABAL Vd.8H,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_u8(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABAL instruction extracts each source vector from the lower half of each source register, while the UABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABAL Vd.4S,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_u16(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Absolute difference and Accumulate Long. This instruction subtracts the vector elements in the lower or upper half of the second source SIMD&amp;FP register from the corresponding vector elements of the first source SIMD&amp;FP register, and accumulates the absolute values of the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are unsigned integer values.The UABAL instruction extracts each source vector from the lower half of each source register, while the UABAL2 instruction extracts each source vector from the upper half of each source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UABAL Vd.2D,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabal_u32(v128 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAX Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the larger of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAX Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Maximum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the larger of each of the two floating-point values into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMAX Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmax_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Maximum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the larger of each of the two floating-point values into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMAX Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vmaxq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMIN Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum (vector). This instruction compares corresponding vector elements in the two source SIMD&amp;FP registers, places the smaller of each of the two unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMIN Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two floating-point values into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMIN Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmin_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point minimum (vector). This instruction compares corresponding elements in the vectors in the two source SIMD&amp;FP registers, places the smaller of each of the two floating-point values into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMIN Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vminq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts each value by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see SRSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts each element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a truncating right shift. For a rounding shift, see URSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Left (register). This instruction takes each signed integer value in the vector of the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift. For a truncating shift, see SSHL.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshl_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Rounding Shift Left (register). This instruction takes each element in the vector of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. If the shift value is negative, it is a rounding right shift.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshlq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_s64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Shift Left (register). This instruction takes each vector element in the first source SIMD&amp;FP register, shifts it by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see SQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_s64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.8H,Vn.8H,Vm.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshl_u64(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounding Shift Left (register). This instruction takes each vector element of the first source SIMD&amp;FP register, shifts the vector element by a value from the least significant byte of the corresponding vector element of the second source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.If the shift value is positive, the operation is a left shift. Otherwise, it is a right shift. The results are rounded. For truncated results, see UQSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHL Vd.2D,Vn.2D,Vm.2D</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrshlq_u64(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_s8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_s64(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHR Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_u8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshr_n_u64(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHR Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshrq_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_s8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_s64(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_u8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshl_n_u64(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left (immediate). This instruction reads each value from a vector, left shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHL Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshlq_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_s8(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_s8(a0, new v64((SByte)(-a1)));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_s8(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_s8(a0, new v128((SByte)(-a1)));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_s16(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_s16(a0, new v64((Int16)(-a1)));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_s16(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_s16(a0, new v128((Int16)(-a1)));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_s32(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_s32(a0, new v64(-a1));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_s32(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_s32(a0, new v128(-a1));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_s64(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_s64(a0, new v64((Int64)(-a1)));
            }

            /// <summary>Signed Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSHR Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_s64(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_s64(a0, new v128((Int64)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_u8(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_u8(a0, new v64((Byte)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_u8(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_u8(a0, new v128((Byte)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_u16(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_u16(a0, new v64((UInt16)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_u16(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_u16(a0, new v128((UInt16)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_u32(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_u32(a0, new v64(-a1));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_u32(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_u32(a0, new v128(-a1));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshr_n_u64(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshl_u64(a0, new v64((UInt64)(-a1)));
            }

            /// <summary>Unsigned Rounding Shift Right (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USHR.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSHR Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrshrq_n_u64(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this is a shl hence the negation
                return vrshlq_u64(a0, new v128((UInt64)(-a1)));
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_s8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_s8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_s16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_s64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are truncated. For rounded results, see SRSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSRA Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_s64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_u8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_u8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_u16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_u32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsra_n_u64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see URSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USRA Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsraq_n_u64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_s8(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vadd_s8(a0, vrshr_n_s8(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_s8(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vaddq_s8(a0, vrshrq_n_s8(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_s16(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vadd_s16(a0, vrshr_n_s16(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_s16(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vaddq_s16(a0, vrshrq_n_s16(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vadd_s32(a0, vrshr_n_s32(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vaddq_s32(a0, vrshrq_n_s32(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_s64(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vadd_s64(a0, vrshr_n_s64(a1, a2));
            }

            /// <summary>Signed Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The results are rounded. For truncated results, see SSRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRSRA Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_s64(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to srshl + add, so doing the same
                return vaddq_s64(a0, vrshrq_n_s64(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_u8(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vadd_u8(a0, vrshr_n_u8(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_u8(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vaddq_u8(a0, vrshrq_n_u8(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_u16(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vadd_u16(a0, vrshr_n_u16(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_u16(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vaddq_u16(a0, vrshrq_n_u16(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_u32(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vadd_u32(a0, vrshr_n_u32(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_u32(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vaddq_u32(a0, vrshrq_n_u32(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsra_n_u64(v64 a0, v64 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vadd_u64(a0, vrshr_n_u64(a1, a2));
            }

            /// <summary>Unsigned Rounding Shift Right and Accumulate (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see USRA.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSRA Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsraq_n_u64(v128 a0, v128 a1, Int32 a2)
            {
                // clang generates a call to urshl + add, so doing the same
                return vaddq_u64(a0, vrshrq_n_u64(a1, a2));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_s8(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_s8(a0, new v64((SByte)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_s8(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_s8(a0, new v128((SByte)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_s16(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_s16(a0, new v64((Int16)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_s16(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_s16(a0, new v128((Int16)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_s32(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_s32(a0, new v64((Int32)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_s32(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_s32(a0, new v128((Int32)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_s64(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_s64(a0, new v64((Int64)a1));
            }

            /// <summary>Signed saturating Shift Left (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, shifts each result by an immediate value, places the final result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHL Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_s64(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_s64(a0, new v128((Int64)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_u8(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_u8(a0, new v64((Byte)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_u8(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_u8(a0, new v128((Byte)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_u16(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_u16(a0, new v64((UInt16)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_u16(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_u16(a0, new v128((UInt16)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_u32(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_u32(a0, new v64((UInt32)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_u32(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_u32(a0, new v128((UInt32)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshl_n_u64(v64 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshl_u64(a0, new v64((UInt64)a1));
            }

            /// <summary>Unsigned saturating Shift Left (immediate). This instruction takes each vector element in the source SIMD&amp;FP register, shifts it by an immediate value, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHL Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshlq_n_u64(v128 a0, Int32 a1)
            {
                // The LLVM intrinsic behind this API actually requires a vector and not an immediate,
                // so redirecting to a regular vqshl yields equivalent results
                return vqshlq_u64(a0, new v128((UInt64)a1));
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshlu_n_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshluq_n_s8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshlu_n_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshluq_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshlu_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshluq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshlu_n_s64(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Left Unsigned (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, shifts each value by an immediate value, saturates the shifted result to an unsigned integer value, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see UQRSHL.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHLU Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vqshluq_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are truncated. For rounded results, see RSHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vshrn_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see SQRSHRUN.The SQSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRUN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrun_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see SQRSHRUN.The SQSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRUN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrun_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are truncated. For rounded results, see SQRSHRUN.The SQSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRUN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrun_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are rounded. For truncated results, see SQSHRUN.The SQRSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRUN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrun_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are rounded. For truncated results, see SQSHRUN.The SQRSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRUN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrun_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Unsigned Narrow (immediate). This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, right shifts each value by an immediate value, saturates the result to an unsigned integer value that is half the original width, places the final result into a vector, and writes the vector to the destination SIMD&amp;FP register. The results are rounded. For truncated results, see SQSHRUN.The SQRSHRUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRUN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrun_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts and truncates each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. For rounded results, see SQRSHRN.The SQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts and truncates each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. For rounded results, see SQRSHRN.The SQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts and truncates each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. For rounded results, see SQRSHRN.The SQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see UQRSHRN.The UQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see UQRSHRN.The UQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are truncated. For rounded results, see UQRSHRN.The UQSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqshrn_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Rounding Shift Right Narrow (immediate). This instruction reads each unsigned integer value from the vector in the source SIMD&amp;FP register, right shifts each result by an immediate value, writes the final result to a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SHRN.The RSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the RSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>RSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vrshrn_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SQSHRN.The SQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SQSHRN.The SQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, saturates each shifted result to a value that is half the original width, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are signed integer values. The destination vector elements are half as long as the source vector elements. The results are rounded. For truncated results, see SQSHRN.The SQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see UQSHRN.The UQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHRN Vd.8B,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see UQSHRN.The UQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHRN Vd.4H,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating Rounded Shift Right Narrow (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each result by an immediate value, puts the final result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values. The results are rounded. For truncated results, see UQSHRN.The UQRSHRN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQRSHRN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQRSHRN Vd.2S,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrshrn_n_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.8H,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.4S,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.2D,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.8H,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.4S,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.2D,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vshll_n_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_s8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_s8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_s16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_s64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_s64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_u8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_u8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_u16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_u32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsri_n_u64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Right and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, right shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the right of each vector element of the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SRI Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsriq_n_u64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_s8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_s8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_s16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_s64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_s64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.8B,Vn.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_u8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.16B,Vn.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_u8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.4H,Vn.4H,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.8H,Vn.8H,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_u16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_u32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Dd,Dn,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vsli_n_u64(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Shift Left and Insert (immediate). This instruction reads each vector element in the source SIMD&amp;FP register, left shifts each vector element by an immediate value, and inserts the result into the corresponding vector element in the destination SIMD&amp;FP register such that the new zero bits created by the shift are not inserted but retain their existing value. Bits shifted out of the left of each vector element in the source register are lost.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SLI Vd.2D,Vn.2D,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vsliq_n_u64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Signed fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point signed integer using the Round towards Zero rounding mode, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZS Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_s32_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Signed fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point signed integer using the Round towards Zero rounding mode, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZS Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_s32_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Unsigned fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point unsigned integer using the Round towards Zero rounding mode, and writes the result to the general-purpose destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZU Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_u32_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Unsigned fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point unsigned integer using the Round towards Zero rounding mode, and writes the result to the general-purpose destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZU Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_u32_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Signed fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point signed integer using the Round towards Zero rounding mode, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZS Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_n_s32_f32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Signed fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point signed integer using the Round towards Zero rounding mode, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZS Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_n_s32_f32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Unsigned fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point unsigned integer using the Round towards Zero rounding mode, and writes the result to the general-purpose destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZU Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_n_u32_f32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Convert to Unsigned fixed-point, rounding toward Zero (vector). This instruction converts a scalar or each element in a vector from floating-point to fixed-point unsigned integer using the Round towards Zero rounding mode, and writes the result to the general-purpose destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FCVTZU Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_n_u32_f32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SCVTF Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_f32_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SCVTF Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_f32_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UCVTF Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_f32_u32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UCVTF Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_f32_u32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SCVTF Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_n_f32_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SCVTF Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_n_f32_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UCVTF Vd.2S,Vn.2S,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vcvt_n_f32_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned fixed-point Convert to Floating-point (vector). This instruction converts each element in a vector from fixed-point to floating-point using the rounding mode that is specified by the FPCR, and writes the result to the SIMD&amp;FP destination register.A floating-point exception can be generated by this instruction. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the Security state and Exception level in which the instruction is executed, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UCVTF Vd.4S,Vn.4S,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vcvtq_n_f32_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.8B,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.4H,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.2S,Vn.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_s64(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.8B,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_u16(v128 a0)
            {
                return vmovn_s16(a0);
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.4H,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_u32(v128 a0)
            {
                return vmovn_s32(a0);
            }

            /// <summary>Extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, narrows each value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.The XTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the XTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>XTN Vd.2S,Vn.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vmovn_u64(v128 a0)
            {
                return vmovn_s64(a0);
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.8H,Vn.8B,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.4S,Vn.4H,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Shift Left Long (immediate). This instruction reads each vector element from the source SIMD&amp;FP register, left shifts each vector element by the specified shift amount, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements. All the values in this instruction are signed integer values.The SSHLL instruction extracts vector elements from the lower half of the source register, while the SSHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SSHLL Vd.2D,Vn.2S,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.8H,Vn.8B,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_u8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.4S,Vn.4H,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_u16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Shift Left Long (immediate). This instruction reads each vector element in the lower or upper half of the source SIMD&amp;FP register, shifts the unsigned integer value left by the specified number of bits, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.The USHLL instruction extracts vector elements from the lower half of the source register, while the USHLL2 instruction extracts vector elements from the upper half of the source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>USHLL Vd.2D,Vn.2S,#0</c></summary>
            [DebuggerStepThrough]
            public static v128 vmovl_u32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates the value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTN Vd.8B,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates the value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTN Vd.4H,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates the value to half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTN Vd.2S,Vn.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_s64(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates each value to half the original width, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The UQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQXTN Vd.8B,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_u16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates each value to half the original width, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The UQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQXTN Vd.4H,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_u32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned saturating extract Narrow. This instruction reads each vector element from the source SIMD&amp;FP register, saturates each value to half the original width, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The UQXTN instruction writes the vector to the lower half of the destination register and clears the upper half, while the UQXTN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UQXTN Vd.2S,Vn.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovn_u64(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Unsigned Narrow. This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, saturates the value to an unsigned integer value that is half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTUN Vd.8B,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovun_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Unsigned Narrow. This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, saturates the value to an unsigned integer value that is half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTUN Vd.4H,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovun_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating extract Unsigned Narrow. This instruction reads each signed integer value in the vector of the source SIMD&amp;FP register, saturates the value to an unsigned integer value that is half the original width, places the result into a vector, and writes the vector to the lower or upper half of the destination SIMD&amp;FP register. The destination vector elements are half as long as the source vector elements.If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQXTUN instruction writes the vector to the lower half of the destination register and clears the upper half, while the SQXTUN2 instruction writes the vector to the upper half of the destination register without affecting the other bits of the register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQXTUN Vd.2S,Vn.2D</c></summary>
            [DebuggerStepThrough]
            public static v64 vqmovun_s64(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_lane_s16(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_lane_s16(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_lane_s32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_lane_s32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_lane_u16(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_lane_u16(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_lane_u32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_lane_u32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * v[lane]) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_lane_f32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * v[lane]) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_lane_f32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_lane_s16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_lane_s32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_lane_u16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_lane_u32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_lane_s16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_lane_s32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_lane_s16(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_lane_s16(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_lane_s32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_lane_s32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_lane_u16(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_lane_u16(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_lane_u32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_lane_u32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * v[lane]) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_lane_f32(v64 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * v[lane]) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_lane_f32(v128 a0, v128 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_lane_s16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_lane_s32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_lane_u16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_lane_u32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_lane_s16(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_lane_s32(v128 a0, v64 a1, v64 a2, Int32 a3)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_n_s16(v64 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_n_s16(v128 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_n_u16(v64 a0, UInt16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_n_u16(v128 a0, UInt16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_n_u32(v64 a0, UInt32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_n_u32(v128 a0, UInt32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_n_f32(v64 a0, Single a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_n_f32(v128 a0, Single a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_lane_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_lane_s16(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_lane_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_lane_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_lane_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_lane_u16(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_lane_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MUL Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_lane_u32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmul_lane_f32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Multiply (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMUL Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmulq_lane_f32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_n_s16(v64 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_n_u16(v64 a0, UInt16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_n_u32(v64 a0, UInt32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_lane_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMULL instruction extracts vector elements from the lower half of the first source register, while the SMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMULL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_lane_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_lane_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, places the results in a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMULL instruction extracts vector elements from the lower half of the first source register, while the UMULL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMULL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmull_lane_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_n_s16(v64 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.4S,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_lane_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the final results in a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMULL instruction extracts the first source vector from the lower half of the first source register, while the SQDMULL2 instruction extracts the first source vector from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULL Vd.2D,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmull_lane_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_n_s16(v64 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_n_s16(v128 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_lane_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_lane_s16(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqdmulh_lane_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are truncated. For rounded results, see SQRDMULH.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMULH Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmulhq_lane_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_n_s16(v64 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_n_s16(v128 a0, Int16 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_n_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_n_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4H,Vn.4H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_lane_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.8H,Vn.8H,Vm.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_lane_s16(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.2S,Vn.2S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vqrdmulh_lane_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Rounding Doubling Multiply returning High half (by element). This instruction multiplies each vector element in the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, places the most significant half of the final results into a vector, and writes the vector to the destination SIMD&amp;FP register.The results are rounded. For truncated results, see SQDMULH.If any of the results overflows, they are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQRDMULH Vd.4S,Vn.4S,Vm.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqrdmulhq_lane_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_n_s16(v64 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_n_s16(v128 a0, v128 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            // ??? shall we auto convert here UInt to Int? also applies to the following MLS

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_n_u16(v64 a0, v64 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_n_u16(v128 a0, v128 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_n_u32(v64 a0, v64 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLA Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_n_u32(v128 a0, v128 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * c) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmla_n_f32(v64 a0, v64 a1, Single a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Add to accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] + (b[i] * c) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlaq_n_f32(v128 a0, v128 a1, Single a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_n_s16(v128 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element in the second source SIMD&amp;FP register, and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.The SMLAL instruction extracts vector elements from the lower half of the first source register, while the SMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLAL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_n_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_n_u16(v128 a0, v64 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Add Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLAL instruction extracts vector elements from the lower half of the first source register, while the UMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLAL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlal_n_u32(v128 a0, v64 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_n_s16(v128 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Add Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and accumulates the final results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLAL instruction extracts vector elements from the lower half of the first source register, while the SQDMLAL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLAL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlal_n_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_n_s16(v64 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_n_s16(v128 a0, v128 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_n_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_n_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4H,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_n_u16(v64 a0, v64 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.8H,Vn.8H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_n_u16(v128 a0, v128 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_n_u32(v64 a0, v64 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-Subtract from accumulator (vector, by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and subtracts the results from the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MLS Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_n_u32(v128 a0, v128 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * c) for i = 0 to 1</c></summary>
            [DebuggerStepThrough]
            public static v64 vmls_n_f32(v64 a0, v64 a1, Single a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Multiply-subtract from accumulator
            /// <br/>Equivalent instruction: <c>RESULT[I] = a[i] - (b[i] * c) for i = 0 to 3</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsq_n_f32(v128 a0, v128 a1, Single a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_n_s16(v128 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The SMLSL instruction extracts vector elements from the lower half of the first source register, while the SMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMLSL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_n_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_n_u16(v128 a0, v64 a1, UInt16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Multiply-Subtract Long (vector, by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register and subtracts the results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied.The UMLSL instruction extracts vector elements from the lower half of the first source register, while the UMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMLSL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vmlsl_n_u32(v128 a0, v64 a1, UInt32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.4S,Vn.4H,Vm.H[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_n_s16(v128 a0, v64 a1, Int16 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Doubling Multiply-Subtract Long (by element). This instruction multiplies each vector element in the lower or upper half of the first source SIMD&amp;FP register by the specified vector element of the second source SIMD&amp;FP register, doubles the results, and subtracts the final results from the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the elements that are multiplied. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.The SQDMLSL instruction extracts vector elements from the lower half of the first source register, while the SQDMLSL2 instruction extracts vector elements from the upper half of the first source register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQDMLSL Vd.2D,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vqdmlsl_n_s32(v128 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vabs_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vabsq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vabs_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vabsq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vabs_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ABS Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabsq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, writes the result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FABS Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vabs_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Absolute value (vector). This instruction calculates the absolute value of each vector element in the source SIMD&amp;FP register, writes the result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FABS Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vabsq_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqabs_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqabsq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqabs_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqabsq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqabs_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Absolute value. This instruction reads each vector element from the source SIMD&amp;FP register, puts the absolute value of the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQABS Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqabsq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vneg_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vnegq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vneg_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vnegq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vneg_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Negate (vector). This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, puts the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>NEG Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vnegq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Negate (vector). This instruction negates the value of each vector element in the source SIMD&amp;FP register, writes the result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FNEG Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vneg_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Negate (vector). This instruction negates the value of each vector element in the source SIMD&amp;FP register, writes the result to a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FNEG Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vnegq_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vqneg_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vqnegq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vqneg_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vqnegq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vqneg_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed saturating Negate. This instruction reads each vector element from the source SIMD&amp;FP register, negates each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are signed integer values.If overflow occurs with any of the results, those results are saturated. If saturation occurs, the cumulative saturation bit FPSR.QC is set.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SQNEG Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vqnegq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcls_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vclsq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vcls_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vclsq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vcls_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Sign bits (vector). This instruction counts the number of consecutive bits following the most significant bit that are the same as the most significant bit in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The count does not include the most significant bit itself.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLS Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vclsq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_u8(v64 a0)
            {
                return vclz_s8(a0);
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_u8(v128 a0)
            {
                return vclzq_s8(a0);
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_u16(v64 a0)
            {
                return vclz_s16(a0);
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_u16(v128 a0)
            {
                return vclzq_s16(a0);
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vclz_u32(v64 a0)
            {
                return vclz_s32(a0);
            }

            /// <summary>Count Leading Zero bits (vector). This instruction counts the number of consecutive zeros, starting from the most significant bit, in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CLZ Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vclzq_u32(v128 a0)
            {
                return vclzq_s32(a0);
            }

            /// <summary>Population Count per byte. This instruction counts the number of bits that have a value of one in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CNT Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcnt_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Population Count per byte. This instruction counts the number of bits that have a value of one in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CNT Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcntq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Population Count per byte. This instruction counts the number of bits that have a value of one in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CNT Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vcnt_u8(v64 a0)
            {
                return vcnt_s8(a0);
            }

            /// <summary>Population Count per byte. This instruction counts the number of bits that have a value of one in each vector element in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>CNT Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vcntq_u8(v128 a0)
            {
                return vcntq_s8(a0);
            }

            /// <summary>Unsigned Reciprocal Estimate. This instruction reads each vector element from the source SIMD&amp;FP register, calculates an approximate inverse for the unsigned integer value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URECPE Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrecpe_u32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Reciprocal Estimate. This instruction reads each vector element from the source SIMD&amp;FP register, calculates an approximate inverse for the unsigned integer value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URECPE Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrecpeq_u32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Estimate. This instruction finds an approximate reciprocal estimate for each vector element in the source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRECPE Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrecpe_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Estimate. This instruction finds an approximate reciprocal estimate for each vector element in the source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRECPE Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrecpeq_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Step. This instruction multiplies the corresponding floating-point values in the vectors of the two source SIMD&amp;FP registers, subtracts each of the products from 2.0, places the resulting floating-point values in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRECPS Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrecps_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Step. This instruction multiplies the corresponding floating-point values in the vectors of the two source SIMD&amp;FP registers, subtracts each of the products from 2.0, places the resulting floating-point values in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRECPS Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrecpsq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Reciprocal Square Root Estimate. This instruction reads each vector element from the source SIMD&amp;FP register, calculates an approximate inverse square root for each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSQRTE Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsqrte_u32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Reciprocal Square Root Estimate. This instruction reads each vector element from the source SIMD&amp;FP register, calculates an approximate inverse square root for each value, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. All the values in this instruction are unsigned integer values.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>URSQRTE Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsqrteq_u32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Square Root Estimate. This instruction calculates an approximate square root for each vector element in the source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRSQRTE Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsqrte_f32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Square Root Estimate. This instruction calculates an approximate square root for each vector element in the source SIMD&amp;FP register, places the result in a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRSQRTE Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsqrteq_f32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Square Root Step. This instruction multiplies corresponding floating-point values in the vectors of the two source SIMD&amp;FP registers, subtracts each of the products from 3.0, divides these results by 2.0, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRSQRTS Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrsqrts_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Reciprocal Square Root Step. This instruction multiplies corresponding floating-point values in the vectors of the two source SIMD&amp;FP registers, subtracts each of the products from 3.0, divides these results by 2.0, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR, or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FRSQRTS Vd.4S,Vn.4S,Vm.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrsqrtsq_f32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_s16(v64 a0)
            {
                return vmvn_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_s16(v128 a0)
            {
                return vmvnq_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_s32(v64 a0)
            {
                return vmvn_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_s32(v128 a0)
            {
                return vmvnq_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_u8(v64 a0)
            {
                return vmvn_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_u8(v128 a0)
            {
                return vmvnq_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_u16(v64 a0)
            {
                return vmvn_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_u16(v128 a0)
            {
                return vmvnq_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vmvn_u32(v64 a0)
            {
                return vmvn_s8(a0);
            }

            /// <summary>Bitwise NOT (vector). This instruction reads each vector element from the source SIMD&amp;FP register, places the inverse of each value into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>MVN Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vmvnq_u32(v128 a0)
            {
                return vmvnq_s8(a0);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_s16(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_s16(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_s32(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_s32(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Dd,Dn,Dm</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_s64(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_s64(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_u8(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_u8(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_u16(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_u16(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_u32(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_u32(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vand_u64(v64 a0, v64 a1)
            {
                return vand_s8(a0, a1);
            }

            /// <summary>Bitwise AND (vector). This instruction performs a bitwise AND between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>AND Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vandq_u64(v128 a0, v128 a1)
            {
                return vandq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_s16(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_s16(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_s32(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_s32(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_s64(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_s64(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_u8(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_u8(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_u16(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_u16(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_u32(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_u32(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorr_u64(v64 a0, v64 a1)
            {
                return vorr_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise OR between each result and an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vorrq_u64(v128 a0, v128 a1)
            {
                return vorrq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_s16(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_s16(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_s32(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_s32(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_s64(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_s64(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_u8(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_u8(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_u16(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_u16(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_u32(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_u32(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 veor_u64(v64 a0, v64 a1)
            {
                return veor_s8(a0, a1);
            }

            /// <summary>Bitwise Exclusive OR (vector). This instruction performs a bitwise Exclusive OR operation between the two source SIMD&amp;FP registers, and places the result in the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EOR Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 veorq_u64(v128 a0, v128 a1)
            {
                return veorq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_s16(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_s16(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_s32(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_s32(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_s64(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_s64(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_u8(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_u8(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_u16(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_u16(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_u32(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_u32(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbic_u64(v64 a0, v64 a1)
            {
                return vbic_s8(a0, a1);
            }

            /// <summary>Bitwise bit Clear (vector, immediate). This instruction reads each vector element from the destination SIMD&amp;FP register, performs a bitwise AND between each result and the complement of an immediate constant, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BIC Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbicq_u64(v128 a0, v128 a1)
            {
                return vbicq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_s16(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_s16(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_s32(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_s32(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_s64(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_s64(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_u8(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_u8(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_u16(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_u16(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_u32(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_u32(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vorn_u64(v64 a0, v64 a1)
            {
                return vorn_s8(a0, a1);
            }

            /// <summary>Bitwise inclusive OR NOT (vector). This instruction performs a bitwise OR NOT between the two source SIMD&amp;FP registers, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ORN Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vornq_u64(v128 a0, v128 a1)
            {
                return vornq_s8(a0, a1);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_s8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_s8(v128 a0, v128 a1, v128 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_s16(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_s16(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_s32(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_s32(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_s64(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_s64(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_u8(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_u8(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_u16(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_u16(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_u32(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_u32(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_u64(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_u64(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vbsl_f32(v64 a0, v64 a1, v64 a2)
            {
                return vbsl_s8(a0, a1, a2);
            }

            /// <summary>Bitwise Select. This instruction sets each bit in the destination SIMD&amp;FP register to the corresponding bit from the first source SIMD&amp;FP register when the original destination bit was 1, otherwise from the second source SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>BSL Vd.16B,Vn.16B,Vm.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vbslq_f32(v128 a0, v128 a1, v128 a2)
            {
                return vbslq_s8(a0, a1, a2);
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.8B,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.16B,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.4H,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.8H,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.2S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.4S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Dd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_s64(v64 a0, Int32 a1)
            {
                return a0;
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.2D,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_s64(v64 a0, Int32 a1)
            {
                return new v128(a0, a0);
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.8B,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.16B,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.4H,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.8H,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.2S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.4S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Dd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_u64(v64 a0, Int32 a1)
            {
                return a0;
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.2D,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_u64(v64 a0, Int32 a1)
            {
                return new v128(a0, a0);
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.2S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v64 vdup_lane_f32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Vd.4S,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static v128 vdupq_lane_f32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_u8(v64 a0, v64 a1)
            {
                return vpadd_s8(a0, a1);
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_u16(v64 a0, v64 a1)
            {
                return vpadd_s16(a0, a1);
            }

            /// <summary>Add Pair of elements (scalar). This instruction adds two vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>ADDP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_u32(v64 a0, v64 a1)
            {
                return vpadd_s32(a0, a1);
            }

            /// <summary>Floating-point Add Pair of elements (scalar). This instruction adds two floating-point vector elements in the source SIMD&amp;FP register and writes the scalar result into the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FADDP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadd_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.4H,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.8H,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.2S,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.4S,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.1D,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADDLP Vd.2D,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.4H,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_u8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.8H,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_u8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.2S,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_u16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.4S,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_u16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.1D,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpaddl_u32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register, places the result into a vector, and writes the vector to the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADDLP Vd.2D,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vpaddlq_u32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.4H,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.8H,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_s8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.2S,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.4S,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_s16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.1D,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent signed integer values from the vector in the source SIMD&amp;FP register and accumulates the results into the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SADALP Vd.2D,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_s32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.4H,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.8H,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_u8(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.2S,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.4S,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_u16(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.1D,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpadal_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Add and Accumulate Long Pairwise. This instruction adds pairs of adjacent unsigned integer values from the vector in the source SIMD&amp;FP register and accumulates the results with the vector elements of the destination SIMD&amp;FP register. The destination vector elements are twice as long as the source vector elements.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UADALP Vd.2D,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vpadalq_u32(v128 a0, v128 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAXP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAXP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMAXP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAXP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAXP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Maximum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the largest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMAXP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Maximum of Pair of elements (scalar). This instruction compares two vector elements in the source SIMD&amp;FP register and writes the largest of the floating-point values as a scalar to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMAXP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmax_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMINP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMINP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_s16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of signed integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMINP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_s32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMINP Vd.8B,Vn.8B,Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_u8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMINP Vd.4H,Vn.4H,Vm.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_u16(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Minimum Pairwise. This instruction creates a vector by concatenating the vector elements of the first source SIMD&amp;FP register after the vector elements of the second source SIMD&amp;FP register, reads each pair of adjacent vector elements in the two source SIMD&amp;FP registers, writes the smallest of each pair of unsigned integer values into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMINP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_u32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point Minimum of Pair of elements (scalar). This instruction compares two vector elements in the source SIMD&amp;FP register and writes the smallest of the floating-point values as a scalar to the destination SIMD&amp;FP register.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMINP Vd.2S,Vn.2S,Vm.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vpmin_f32(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_s8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_s8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;1)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_s16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;1)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_s16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_s32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_s32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;3)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_s64(v64 a0, v64 a1, Int32 a2)
            {
                return a0;
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;3)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_s64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#n</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_u8(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#n</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_u8(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;1)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_u16(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;1)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_u16(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_u32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_u32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;3)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_u64(v64 a0, v64 a1, Int32 a2)
            {
                return a0;
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;3)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_u64(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.8B,Vn.8B,Vm.8B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v64 vext_f32(v64 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Extract vector from pair of vectors. This instruction extracts the lowest vector elements from the second source SIMD&amp;FP register and the highest vector elements from the first source SIMD&amp;FP register, concatenates the results into a vector, and writes the vector to the destination SIMD&amp;FP register vector. The index value specifies the lowest vector element to extract from the first source register, and consecutive elements are extracted from the first, then second, source registers until the destination vector is filled.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>EXT Vd.16B,Vn.16B,Vm.16B,#(n&lt;&lt;2)</c></summary>
            [DebuggerStepThrough]
            public static v128 vextq_f32(v128 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_s32(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_s32(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_u8(v64 a0)
            {
                return vrev64_s8(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_u8(v128 a0)
            {
                return vrev64q_s8(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_u16(v64 a0)
            {
                return vrev64_s16(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_u16(v128 a0)
            {
                return vrev64q_s16(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_u32(v64 a0)
            {
                return vrev64_s32(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_u32(v128 a0)
            {
                return vrev64q_s32(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.2S,Vn.2S</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev64_f32(v64 a0)
            {
                return vrev64_s32(a0);
            }

            /// <summary>Reverse elements in 64-bit doublewords (vector). This instruction reverses the order of 8-bit, 16-bit, or 32-bit elements in each doubleword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV64 Vd.4S,Vn.4S</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev64q_f32(v128 a0)
            {
                return vrev64q_s32(a0);
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev32_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev32q_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev32_s16(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev32q_s16(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev32_u8(v64 a0)
            {
                return vrev32_s8(a0);
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev32q_u8(v128 a0)
            {
                return vrev32q_s8(a0);
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.4H,Vn.4H</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev32_u16(v64 a0)
            {
                return vrev32_s16(a0);
            }

            /// <summary>Reverse elements in 32-bit words (vector). This instruction reverses the order of 8-bit or 16-bit elements in each word of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV32 Vd.8H,Vn.8H</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev32q_u16(v128 a0)
            {
                return vrev32q_s16(a0);
            }

            /// <summary>Reverse elements in 16-bit halfwords (vector). This instruction reverses the order of 8-bit elements in each halfword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV16 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev16_s8(v64 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 16-bit halfwords (vector). This instruction reverses the order of 8-bit elements in each halfword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV16 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev16q_s8(v128 a0)
            {
                throw new NotImplementedException();
            }

            /// <summary>Reverse elements in 16-bit halfwords (vector). This instruction reverses the order of 8-bit elements in each halfword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV16 Vd.8B,Vn.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vrev16_u8(v64 a0)
            {
                return vrev16_s8(a0);
            }

            /// <summary>Reverse elements in 16-bit halfwords (vector). This instruction reverses the order of 8-bit elements in each halfword of the vector in the source SIMD&amp;FP register, places the results into a vector, and writes the vector to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>REV16 Vd.16B,Vn.16B</c></summary>
            [DebuggerStepThrough]
            public static v128 vrev16q_u8(v128 a0)
            {
                return vrev16q_s8(a0);
            }

            /// <summary>Table vector Lookup. This instruction reads each value from the vector elements in the index source SIMD&amp;FP register, uses each result as an index to perform a lookup in a table of bytes that is described by one to four source table SIMD&amp;FP registers, places the lookup result in a vector, and writes the vector to the destination SIMD&amp;FP register. If an index is out of range for the table, the result for that lookup is 0. If more than one source register is used to describe the table, the first source register describes the lowest bytes of the table.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>TBL Vd.8B,{Vn.16B},Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtbl1_s8(v64 a0, v64 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Table vector Lookup. This instruction reads each value from the vector elements in the index source SIMD&amp;FP register, uses each result as an index to perform a lookup in a table of bytes that is described by one to four source table SIMD&amp;FP registers, places the lookup result in a vector, and writes the vector to the destination SIMD&amp;FP register. If an index is out of range for the table, the result for that lookup is 0. If more than one source register is used to describe the table, the first source register describes the lowest bytes of the table.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>TBL Vd.8B,{Vn.16B},Vm.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtbl1_u8(v64 a0, v64 a1)
            {
                return vtbl1_s8(a0, a1);
            }

            /// <summary>Bitwise Insert if False. This instruction inserts each bit from the first source SIMD&amp;FP register into the destination SIMD&amp;FP register if the corresponding bit of the second source SIMD&amp;FP register is 0, otherwise leaves the bit in the destination register unchanged.
            /// <br/>Equivalent instructions:
            /// <br/><c>MOVI Vtmp.8B,#8</c>
            /// <br/><c>CMHS Vtmp.8B,Vm.8B,Vtmp.8B</c>
            /// <br/><c>TBL Vtmp1.8B,{Vn.16B},Vm.8B</c>
            /// <br/><c>BIF Vd.8B,Vtmp1.8B,Vtmp.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtbx1_s8(v64 a0, v64 a1, v64 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Bitwise Insert if False. This instruction inserts each bit from the first source SIMD&amp;FP register into the destination SIMD&amp;FP register if the corresponding bit of the second source SIMD&amp;FP register is 0, otherwise leaves the bit in the destination register unchanged.
            /// <br/>Equivalent instructions:
            /// <br/><c>MOVI Vtmp.8B,#8</c>
            /// <br/><c>CMHS Vtmp.8B,Vm.8B,Vtmp.8B</c>
            /// <br/><c>TBL Vtmp1.8B,{Vn.16B},Vm.8B</c>
            /// <br/><c>BIF Vd.8B,Vtmp1.8B,Vtmp.8B</c></summary>
            [DebuggerStepThrough]
            public static v64 vtbx1_u8(v64 a0, v64 a1, v64 a2)
            {
                return vtbx1_s8(a0, a1, a2);
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static Byte vget_lane_u8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt16 vget_lane_u16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt32 vget_lane_u32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt64 vget_lane_u64(v64 a0, Int32 a1)
            {
                return a0.ULong0;
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static SByte vget_lane_s8(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int16 vget_lane_s16(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int32 vget_lane_s32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int64 vget_lane_s64(v64 a0, Int32 a1)
            {
                return a0.SLong0;
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Sd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static Single vget_lane_f32(v64 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static Byte vgetq_lane_u8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt16 vgetq_lane_u16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt32 vgetq_lane_u32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static UInt64 vgetq_lane_u64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.B[lane]</c></summary>
            [DebuggerStepThrough]
            public static SByte vgetq_lane_s8(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.H[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int16 vgetq_lane_s16(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Signed Move vector element to general-purpose register. This instruction reads the signed integer from the source SIMD&amp;FP register, sign-extends it to form a 32-bit or 64-bit value, and writes the result to destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>SMOV Rd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int32 vgetq_lane_s32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Unsigned Move vector element to general-purpose register. This instruction reads the unsigned integer from the source SIMD&amp;FP register, zero-extends it to form a 32-bit or 64-bit value, and writes the result to the destination general-purpose register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>UMOV Rd,Vn.D[lane]</c></summary>
            [DebuggerStepThrough]
            public static Int64 vgetq_lane_s64(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Duplicate vector element to vector or scalar. This instruction duplicates the vector element at the specified element index in the source SIMD&amp;FP register into a scalar or each element in a vector, and writes the result to the destination SIMD&amp;FP register.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>DUP Sd,Vn.S[lane]</c></summary>
            [DebuggerStepThrough]
            public static Single vgetq_lane_f32(v128 a0, Int32 a1)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.B[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_u8(Byte a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.H[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_u16(UInt16 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_u32(UInt32 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.D[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_u64(UInt64 a0, v64 a1, Int32 a2)
            {
                return new v64(a0);
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.B[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_s8(SByte a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.H[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_s16(Int16 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_s32(Int32 a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.D[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_s64(Int64 a0, v64 a1, Int32 a2)
            {
                return new v64(a0);
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v64 vset_lane_f32(Single a0, v64 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.B[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_u8(Byte a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.H[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_u16(UInt16 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_u32(UInt32 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.D[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_u64(UInt64 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.B[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_s8(SByte a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.H[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_s16(Int16 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_s32(Int32 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.D[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_s64(Int64 a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Insert vector element from another vector element. This instruction copies the vector element of the source SIMD&amp;FP register to the specified vector element of the destination SIMD&amp;FP register.This instruction can insert data into individual elements within a SIMD&amp;FP register without clearing the remaining bits to zero.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>INS Vd.S[lane],Rn</c></summary>
            [DebuggerStepThrough]
            public static v128 vsetq_lane_f32(Single a0, v128 a1, Int32 a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Add to accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results in the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLA Vd.2S,Vn.2S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v64 vfma_n_f32(v64 a0, v64 a1, Single a2)
            {
                throw new NotImplementedException();
            }

            /// <summary>Floating-point fused Multiply-Add to accumulator (by element). This instruction multiplies the vector elements in the first source SIMD&amp;FP register by the specified value in the second source SIMD&amp;FP register, and accumulates the results in the vector elements of the destination SIMD&amp;FP register. All the values in this instruction are floating-point values.This instruction can generate a floating-point exception. Depending on the settings in FPCR, the exception results in either a flag being set in FPSR or a synchronous exception being generated. For more information, see Floating-point exception traps.Depending on the settings in the CPACR_EL1, CPTR_EL2, and CPTR_EL3 registers, and the current Security state and Exception level, an attempt to execute the instruction might be trapped.
            /// <br/>Equivalent instruction: <c>FMLA Vd.4S,Vn.4S,Vm.S[0]</c></summary>
            [DebuggerStepThrough]
            public static v128 vfmaq_n_f32(v128 a0, v128 a1, Single a2)
            {
                throw new NotImplementedException();
            }
        }
    }
}
#endif // BURST_INTERNAL || UNITY_BURST_EXPERIMENTAL_NEON_INTRINSICS
