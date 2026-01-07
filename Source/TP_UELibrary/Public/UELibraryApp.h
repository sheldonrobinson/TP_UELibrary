// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#ifdef __cplusplus
	#ifdef WIN32
		#define TP_UELibrary_EXPORT extern "C" __declspec(dllexport)
	#else
		#define TP_UELibrary_EXPORT extern "C" __attribute__((visibility("default"))) __attribute__((used))
	#endif
#else
    #ifdef WIN32
    #define TP_UELibrary_EXPORT extern
    #else
    #define TP_UELibrary_EXPORT extern __attribute__((visibility("default"))) __attribute__((used))
    #endif
#endif



// Windows Header Files
#if defined(__WIN32__) || defined(_WIN32) || defined(WIN32) || defined(__WINDOWS__) || defined(__TOS_WIN__)
	#if !defined(WIN32_LEAN_AND_MEAN)
		#define  WIN32_LEAN_AND_MEAN
	#endif
	#include <windows.h>
#endif

#ifdef __cplusplus
extern "C"
{
#endif

TP_UELibrary_EXPORT int AppMain(HINSTANCE hInst, HWND hWndParent, const char* CmdLine);

#ifdef __cplusplus
}
#endif