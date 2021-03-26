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
/// <date>2021/3/25 21:58:40</date>
namespace NespSdkNetFramework
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets total milliseconds of date time.
        /// </summary>
        /// <param name="dateTime">Date time to get total milliseconds</param>
        /// <returns>Total miliseconds</returns>
        public static double TotalMilliseconds(this DateTime dateTime)
        {
            return TimeSpan.FromTicks(dateTime.Ticks).TotalMilliseconds;
        }

    }
}
