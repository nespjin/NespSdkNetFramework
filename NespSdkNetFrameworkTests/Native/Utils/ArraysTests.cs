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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NespSdkNetFramework.Native.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NespSdkNetFramework.Native.Utils.Tests
{
    [TestClass()]
    public class ArraysTests
    {
        [TestMethod()]
        public void CopyTest()
        {
            int length = 5;
            int[] src = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            int[] dest = new int[length];

            int sizeOfSrc = Marshal.SizeOf(src[0]) * src.Length;
            int sizeOfDest = Marshal.SizeOf(src[0]) * length;
            IntPtr pSrc = Marshal.AllocHGlobal(sizeOfSrc);
            IntPtr pDest = Marshal.AllocHGlobal(sizeOfDest);

            try
            {
                // Copy the array to unmanaged memory.
                Marshal.Copy(src, 0, pSrc, src.Length);
                unsafe
                {
                    //Arrays.Copy(pSrc, 0, pDest, 0, length);
                    //Arrays.Copy(pSrc.ToPointer());
                    NespSdkNetFrameworkNative.Arrays.Copy((int*)pSrc.ToPointer(),0, (int*)pDest.ToPointer(),0,length);
                    for (int i = 0; i < length; i++)
                    {
                        dest[i] = ((int*)pDest.ToPointer())[i];
                    }
                }
            }
            finally
            {
                // Free the unmanaged memory.
                Marshal.FreeHGlobal(pSrc);
            }

            foreach (var item in dest)
            {
                Console.WriteLine("Dest value = " + item);
            }
        }
    }
}

