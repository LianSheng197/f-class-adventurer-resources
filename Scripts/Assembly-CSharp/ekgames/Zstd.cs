using System;
using System.Runtime.InteropServices;

namespace ekgames
{
	public static class Zstd
	{
		public enum ErrorCode
		{
			ZSTD_error_no_error = 0,
			ZSTD_error_GENERIC = 1,
			ZSTD_error_prefix_unknown = 10,
			ZSTD_error_version_unsupported = 12,
			ZSTD_error_frameParameter_unsupported = 14,
			ZSTD_error_frameParameter_windowTooLarge = 16,
			ZSTD_error_corruption_detected = 20,
			ZSTD_error_checksum_wrong = 22,
			ZSTD_error_dictionary_corrupted = 30,
			ZSTD_error_dictionary_wrong = 32,
			ZSTD_error_dictionaryCreation_failed = 34,
			ZSTD_error_parameter_unsupported = 40,
			ZSTD_error_parameter_outOfBound = 42,
			ZSTD_error_tableLog_tooLarge = 44,
			ZSTD_error_maxSymbolValue_tooLarge = 46,
			ZSTD_error_maxSymbolValue_tooSmall = 48,
			ZSTD_error_stage_wrong = 60,
			ZSTD_error_init_missing = 62,
			ZSTD_error_memory_allocation = 64,
			ZSTD_error_workSpace_tooSmall = 66,
			ZSTD_error_dstSize_tooSmall = 70,
			ZSTD_error_srcSize_wrong = 72,
			ZSTD_error_dstBuffer_null = 74,
			ZSTD_error_frameIndex_tooLarge = 100,
			ZSTD_error_seekableIO = 102,
			ZSTD_error_dstBuffer_wrong = 104,
			ZSTD_error_maxCode = 120
		}

		public struct Result
		{
			public ErrorCode errorCode;

			public string errorDescription;

			public ArraySegment<byte>? data;
		}

		internal static class Extern
		{
			[PreserveSig]
			internal static extern uint ZSTD_versionNumber();

			[PreserveSig]
			internal static extern IntPtr ZSTD_versionString();

			[PreserveSig]
			internal static extern int ZSTD_maxCLevel();

			[PreserveSig]
			internal static extern UIntPtr ZSTD_compressBound(UIntPtr srcSize);

			[PreserveSig]
			internal static extern uint ZSTD_isError(UIntPtr code);

			[PreserveSig]
			internal static extern ErrorCode ZSTD_getErrorCode(UIntPtr functionResult);

			[PreserveSig]
			internal static extern IntPtr ZSTD_getErrorName(UIntPtr code);

			[PreserveSig]
			internal static extern UIntPtr ZSTD_compress(byte[] dst, UIntPtr dstCapacity, byte[] src, UIntPtr srcSize, int compressionLevel);

			[PreserveSig]
			internal static extern UIntPtr ZSTD_decompress(byte[] dst, UIntPtr dstCapacity, byte[] src, UIntPtr compressedSize);

			[PreserveSig]
			internal static extern ulong ZSTD_getFrameContentSize(byte[] compressedSrc, UIntPtr compressedSrcSize);
		}

		public static string GetVersionString()
		{
			return null;
		}

		public static uint GetVersionNumber()
		{
			return 0u;
		}

		public static int GetMaxLevel()
		{
			return 0;
		}

		public static bool IsError(UIntPtr code)
		{
			return false;
		}

		public static Result Compress(ArraySegment<byte> src, int compressionLevel)
		{
			return default(Result);
		}

		public static Result Decompress(ArraySegment<byte> src)
		{
			return default(Result);
		}
	}
}
