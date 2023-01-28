using System.Numerics;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Providers.FourierTransform
{
	public sealed class ManagedFourierTransformProvider : IFourierTransformProvider
	{
		private const int BluesteinSequenceLengthThreshold = 46341;

		public static ManagedFourierTransformProvider Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private static Complex32[] BluesteinSequence32(int n)
		{
			return null;
		}

		private static Complex[] BluesteinSequence(int n)
		{
			return null;
		}

		private static void BluesteinConvolutionParallel(Complex32[] samples)
		{
		}

		private static void BluesteinConvolutionParallel(Complex[] samples)
		{
		}

		private static void SwapRealImaginary(Complex32[] samples)
		{
		}

		private static void SwapRealImaginary(Complex[] samples)
		{
		}

		private static void BluesteinForward(Complex[] samples)
		{
		}

		private static void BluesteinInverse(Complex[] spectrum)
		{
		}

		private static void BluesteinForward(Complex32[] samples)
		{
		}

		private static void BluesteinInverse(Complex32[] spectrum)
		{
		}

		public bool IsAvailable()
		{
			return false;
		}

		public void InitializeVerify()
		{
		}

		public void FreeResources()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Forward(Complex32[] samples, FourierTransformScaling scaling)
		{
		}

		public void Forward(Complex[] samples, FourierTransformScaling scaling)
		{
		}

		public void Backward(Complex32[] spectrum, FourierTransformScaling scaling)
		{
		}

		public void Backward(Complex[] spectrum, FourierTransformScaling scaling)
		{
		}

		public void ForwardReal(float[] samples, int n, FourierTransformScaling scaling)
		{
		}

		public void ForwardReal(double[] samples, int n, FourierTransformScaling scaling)
		{
		}

		public void BackwardReal(float[] spectrum, int n, FourierTransformScaling scaling)
		{
		}

		public void BackwardReal(double[] spectrum, int n, FourierTransformScaling scaling)
		{
		}

		public void ForwardMultidim(Complex32[] samples, int[] dimensions, FourierTransformScaling scaling)
		{
		}

		public void ForwardMultidim(Complex[] samples, int[] dimensions, FourierTransformScaling scaling)
		{
		}

		public void BackwardMultidim(Complex32[] spectrum, int[] dimensions, FourierTransformScaling scaling)
		{
		}

		public void BackwardMultidim(Complex[] spectrum, int[] dimensions, FourierTransformScaling scaling)
		{
		}

		private static void Radix2Reorder<T>(T[] samples)
		{
		}

		[MethodImpl(256)]
		private static void Radix2Step(Complex32[] samples, int exponentSign, int levelSize, int k)
		{
		}

		[MethodImpl(256)]
		private static void Radix2Step(Complex[] samples, int exponentSign, int levelSize, int k)
		{
		}

		private static void Radix2Forward(Complex32[] data)
		{
		}

		private static void Radix2Forward(Complex[] data)
		{
		}

		private static void Radix2Inverse(Complex32[] data)
		{
		}

		private static void Radix2Inverse(Complex[] data)
		{
		}

		private static void Radix2ForwardParallel(Complex32[] data)
		{
		}

		private static void Radix2ForwardParallel(Complex[] data)
		{
		}

		private static void Radix2InverseParallel(Complex32[] data)
		{
		}

		private static void Radix2InverseParallel(Complex[] data)
		{
		}

		private static void FullRescale(Complex32[] samples)
		{
		}

		private static void FullRescale(Complex[] samples)
		{
		}

		private static void HalfRescale(Complex32[] samples)
		{
		}

		private static void HalfRescale(Complex[] samples)
		{
		}
	}
}
