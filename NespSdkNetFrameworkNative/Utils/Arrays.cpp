#include "../pch.h"
#include "pch.h"
#include "Arrays.h"

void NespSdkNetFrameworkNative::Arrays::Copy(const int* src, int srcPos, int* dest, int destPos, int length)
{
	for (int i = 0; i < length; ++i) *(dest + destPos + i) = *(src + srcPos + i);
}
