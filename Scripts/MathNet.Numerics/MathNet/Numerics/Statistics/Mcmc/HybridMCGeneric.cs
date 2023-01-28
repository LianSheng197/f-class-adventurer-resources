using System;

namespace MathNet.Numerics.Statistics.Mcmc
{
	public abstract class HybridMCGeneric<T> : McmcSampler<T>
	{
		public delegate T DiffMethod(DensityLn<T> f, T x);

		private readonly DensityLn<T> _energy;

		protected T Current;

		private int _burnInterval;

		private double _stepSize;

		private int _frogLeapSteps;

		private readonly DiffMethod _diff;

		public int BurnInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int FrogLeapSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double StepSize
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		protected HybridMCGeneric(T x0, DensityLn<T> pdfLnP, int frogLeapSteps, double stepSize, int burnInterval, System.Random randomSource, DiffMethod diff)
		{
			((McmcSampler<>)(object)this)._002Ector();
		}

		public override T Sample()
		{
			return default(T);
		}

		protected void Burn(int n)
		{
		}

		protected void Update(ref double e, ref T gradient, T mNew, T gNew, double enew, double dh)
		{
		}

		protected abstract T Create();

		protected abstract T Copy(T source);

		protected abstract double DoProduct(T first, T second);

		protected abstract void DoAdd(ref T first, double factor, T second);

		protected abstract void DoSubtract(ref T first, double factor, T second);

		protected abstract void RandomizeMomentum(ref T p);

		protected void HamiltonianEquations(ref T gNew, ref T mNew, ref T p)
		{
		}

		protected double Hamiltonian(T momentum, double e)
		{
			return 0.0;
		}

		protected int SetNonNegative(int value)
		{
			return 0;
		}

		protected int SetPositive(int value)
		{
			return 0;
		}

		protected double SetPositive(double value)
		{
			return 0.0;
		}
	}
}
