using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//
// Copyright (C) 2021 NESP Technology Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// If you have any questions or if you find a bug,
// please contact the author by email or ask for Issues.
//
// Author:JinZhaolu <1756404649@qq.com>
//

/// <team>NESP Technology</team> 
/// <author><a href="mailto:1756404649@qq.com">JinZhaolu Email:1756404649@qq.com</a></author>
/// <date>2021/3/27 22:22:30</date>
namespace NespSdkNetFramework.Utils
{
    public static class Arrays
    {
        public static void Copy(int[] src, int srcPos, int[] dest, int destPos, int length)
        {
            Copy<int>(src, srcPos, dest, destPos, length);
        }

        public static void Copy(long[] src, int srcPos, long[] dest, int destPos, int length)
        {
            Copy<long>(src, srcPos, dest, destPos, length);
        }

        public static void Copy(double[] src, int srcPos, double[] dest, int destPos, int length)
        {
            Copy<double>(src, srcPos, dest, destPos, length);
        }

        public static void Copy(char[] src, int srcPos, char[] dest, int destPos, int length)
        {
            Copy<char>(src, srcPos, dest, destPos, length);
        }

        public static void Copy(byte[] src, int srcPos, byte[] dest, int destPos, int length)
        {
            Copy<byte>(src, srcPos, dest, destPos, length);
        }

        public static void Copy(sbyte[] src, int srcPos, sbyte[] dest, int destPos, int length)
        {
            Copy<sbyte>(src, srcPos, dest, destPos, length);
        }

        public static void Copy<T>(T[] src, int srcPos, T[] dest, int destPos, int length)
        {
            Array.Copy(src, srcPos, dest, destPos, length);
        }


    }
}
