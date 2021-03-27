#pragma once
namespace NespSdkNetFrameworkNative 
{
	public ref class Arrays
	{
	public:
		///
		/// <summary>
		/// Copy array from src to dest.
		/// </summary>
		/// <param name="src">the source array</param>
		/// <param name="srcPos">starting position in the source array.</param>
		/// <param name="dest">the destination array.</param>
		/// <param name="destPos">starting position in the destination data.</param>
		/// <param name="length">the number of array elements to be copied.</param>
		static void Copy(const int* src, int srcPos, int* dest, int destPos, int length);
	};
}

