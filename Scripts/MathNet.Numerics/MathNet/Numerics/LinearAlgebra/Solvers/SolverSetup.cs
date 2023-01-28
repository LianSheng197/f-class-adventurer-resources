using System;
using System.Collections.Generic;
using System.Reflection;

namespace MathNet.Numerics.LinearAlgebra.Solvers
{
	public static class SolverSetup<T> where T : struct, IEquatable<T>, IFormattable
	{
		public static IEnumerable<IIterativeSolverSetup<T>> LoadFromAssembly(Assembly assembly, bool ignoreFailed = true, params Type[] typesToExclude)
		{
			return null;
		}

		public static IEnumerable<IIterativeSolverSetup<T>> LoadFromAssembly(Type typeInAssembly, bool ignoreFailed = true, params Type[] typesToExclude)
		{
			return null;
		}

		public static IEnumerable<IIterativeSolverSetup<T>> LoadFromAssembly(AssemblyName assemblyName, bool ignoreFailed = true, params Type[] typesToExclude)
		{
			return null;
		}

		public static IEnumerable<IIterativeSolverSetup<T>> Load(Type[] typesToExclude)
		{
			return null;
		}

		public static IEnumerable<IIterativeSolverSetup<T>> Load()
		{
			return null;
		}
	}
}
