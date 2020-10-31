/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Ldind_I,
        Ldelem_R8,
        Shr_Un,
        Mkrefany,
        Conv_U,
        Newobj,
        Rem,
        Stloc,
        Blt,
        CallExtern,
        Ldelem_I1,
        Readonly,
        Stelem_I2,
        Stobj,
        Conv_R_Un,
        Conv_Ovf_I2,
        Sub,
        Conv_R8,
        Brtrue,
        Conv_R4,

        //Pseudo instruction
        StackSpace,
        Ldsflda,
        Ldelema,
        Clt_Un,
        Bgt,
        Unaligned,
        Dup,
        Shl,
        Ldc_I8,
        Rethrow,
        Ldelem_Ref,
        Ldvirtftn2,
        Div_Un,
        Isinst,
        Newarr,
        Conv_I2,
        Stind_Ref,
        Conv_U1,
        Mul,
        Sub_Ovf_Un,
        Brfalse,
        Conv_U4,
        Stind_I1,
        Ldvirtftn,
        Stelem_I4,
        Xor,
        Bge,
        Conv_Ovf_U_Un,
        Conv_Ovf_I8,
        Stelem_R8,
        Ldnull,
        Rem_Un,
        Callvirt,
        Ldelem_U1,
        Ldelem_Any,
        Conv_Ovf_I,
        Conv_Ovf_I2_Un,
        Conv_Ovf_U1_Un,
        Stelem_Ref,
        Cgt,
        Initblk,
        Stind_I8,
        Conv_I,
        Pop,
        Conv_U8,
        Newanon,
        Conv_U2,
        No,
        Stfld,
        Jmp,
        Refanytype,
        Stsfld,
        Ldelem_I2,
        Cpblk,
        Conv_Ovf_I8_Un,
        Ldind_I8,
        Ldind_I2,
        Not,
        Conv_Ovf_I4_Un,
        Ble,
        Conv_Ovf_I4,
        Ldelem_U2,
        Add_Ovf,
        Ldind_U2,
        Ldc_R4,
        Volatile,
        Conv_Ovf_U8,
        Tail,
        Conv_I1,
        Ldtoken,
        Call,
        Leave,
        Cgt_Un,
        Ldelem_I8,
        Localloc,
        Stind_I,
        Throw,
        Conv_Ovf_I_Un,
        Ceq,
        Ldobj,
        Starg,
        Ldelem_I4,
        Ldloca,
        Ldind_Ref,
        Ldc_R8,
        Bgt_Un,
        Switch,
        Add,
        Conv_Ovf_U8_Un,
        Conv_Ovf_U1,
        Ldflda,
        Ldc_I4,
        Ldsfld,
        Mul_Ovf,
        Conv_I8,
        Ldloc,
        Stind_R4,
        Ldftn,
        Ldind_U1,
        Break,
        Unbox_Any,
        Ldarg,
        Castclass,
        Conv_I4,
        Ldstr,
        Unbox,
        Stind_I2,
        Ble_Un,
        Stind_I4,
        Ldarga,
        Constrained,
        Ldind_I4,
        Stelem_R4,
        Cpobj,
        Bge_Un,
        Initobj,
        Br,
        Sizeof,
        And,
        Endfinally,
        Sub_Ovf,
        Ldlen,
        Blt_Un,
        Shr,
        Conv_Ovf_U4,
        Add_Ovf_Un,
        Beq,
        Neg,
        Nop,
        Stelem_I1,
        Conv_Ovf_U4_Un,
        Stelem_I,
        Endfilter,
        Stelem_Any,
        Or,
        Ldind_R8,
        Arglist,
        Ldind_I1,
        Refanyval,
        Ldfld,
        Ldelem_R4,
        Ldelem_U4,
        Ldind_U4,
        Bne_Un,
        Conv_Ovf_I1,
        Stelem_I8,
        Mul_Ovf_Un,
        Clt,
        Div,
        Box,
        Ldtype, // custom
        //Calli,
        Conv_Ovf_U2,
        Ldelem_I,
        Conv_Ovf_U,
        Callvirtvirt,
        Stind_R8,
        Conv_Ovf_U2_Un,
        Ckfinite,
        Conv_Ovf_I1_Un,
        Ldind_R4,
        Ret,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 3067433598421528260;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}