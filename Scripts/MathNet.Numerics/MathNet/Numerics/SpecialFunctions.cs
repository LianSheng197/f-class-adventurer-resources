using System;
using System.Numerics;

namespace MathNet.Numerics
{
	public static class SpecialFunctions
	{
		private static class Amos
		{
			public static Complex Cairy(Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCairy(Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCairy(double z)
			{
				return 0.0;
			}

			public static Complex CairyPrime(Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCairyPrime(Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCairyPrime(double z)
			{
				return 0.0;
			}

			public static Complex Cbiry(Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCbiry(Complex z)
			{
				return default(Complex);
			}

			public static Complex CbiryPrime(Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCbiryPrime(Complex z)
			{
				return default(Complex);
			}

			public static Complex Cbesj(double v, Complex z)
			{
				return default(Complex);
			}

			public static double Cbesj(double v, double z)
			{
				return 0.0;
			}

			public static Complex ScaledCbesj(double v, Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCbesj(double v, double z)
			{
				return 0.0;
			}

			public static Complex Cbesy(double v, Complex z)
			{
				return default(Complex);
			}

			public static double Cbesy(double v, double x)
			{
				return 0.0;
			}

			public static Complex ScaledCbesy(double v, Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCbesy(double v, double x)
			{
				return 0.0;
			}

			public static Complex Cbesi(double v, Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCbesi(double v, Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCbesi(double v, double x)
			{
				return 0.0;
			}

			public static Complex Cbesk(double v, Complex z)
			{
				return default(Complex);
			}

			public static double Cbesk(double v, double z)
			{
				return 0.0;
			}

			public static Complex ScaledCbesk(double v, Complex z)
			{
				return default(Complex);
			}

			public static double ScaledCbesk(double v, double z)
			{
				return 0.0;
			}

			public static Complex Cbesh1(double v, Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCbesh1(double v, Complex z)
			{
				return default(Complex);
			}

			public static Complex Cbesh2(double v, Complex z)
			{
				return default(Complex);
			}

			public static Complex ScaledCbesh2(double v, Complex z)
			{
				return default(Complex);
			}

			private static double SinPi(double x)
			{
				return 0.0;
			}

			private static double CosPi(double x)
			{
				return 0.0;
			}

			private static Complex Rotate(Complex z, double v)
			{
				return default(Complex);
			}

			private static Complex RotateJY(Complex j, Complex y, double v)
			{
				return default(Complex);
			}

			private static bool ReflectJY(ref Complex jy, double v)
			{
				return false;
			}

			private static bool ReflectI(double v)
			{
				return false;
			}

			private static Complex RotateI(Complex i, Complex k, double v)
			{
				return default(Complex);
			}
		}

		private static class AmosHelper
		{
			public static int zairy(double zr, double zi, int id, int kode, ref double air, ref double aii, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static int zbiry(double zr, double zi, int id, int kode, ref double bir, ref double bii, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static int zbesj(double zr, double zi, double fnu, int kode, int n, double[] cyr, double[] cyi, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static int zbesy(double zr, double zi, double fnu, int kode, int n, double[] cyr, double[] cyi, ref int nz, double[] cwrkr, double[] cwrki, ref int ierr)
			{
				return 0;
			}

			public static int zbesi(double zr, double zi, double fnu, int kode, int n, double[] cyr, double[] cyi, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static int zbesk(double zr, double zi, double fnu, int kode, int n, double[] cyr, double[] cyi, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static int zbesh(double zr, double zi, double fnu, int kode, int m, int n, double[] cyr, double[] cyi, ref int nz, ref int ierr)
			{
				return 0;
			}

			public static double dgamln(double z, ref int ierr)
			{
				return 0.0;
			}

			private static double d1mach(int i)
			{
				return 0.0;
			}

			private static int i1mach(int i)
			{
				return 0;
			}

			private static double dsign(double a, double b)
			{
				return 0.0;
			}

			private static double zabs(double zr, double zi)
			{
				return 0.0;
			}

			private static int zdiv(double ar, double ai, double br, double bi, ref double cr, ref double ci)
			{
				return 0;
			}

			private static int zexp(double ar, double ai, ref double br, ref double bi)
			{
				return 0;
			}

			private static int zlog(double ar, double ai, ref double br, ref double bi, ref int ierr)
			{
				return 0;
			}

			private static int zmlt(double ar, double ai, double br, double bi, ref double cr, ref double ci)
			{
				return 0;
			}

			private static int zsqrt(double ar, double ai, ref double br, ref double bi)
			{
				return 0;
			}

			private static int zacai(double zr, double zi, double fnu, int kode, int mr, int n, double[] yr, double[] yi, ref int nz, double rl, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zacon(double zr, double zi, double fnu, int kode, int mr, int n, double[] yr, double[] yi, ref int nz, double rl, double fnul, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zasyi(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, double rl, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zbinu(double zr, double zi, double fnu, int kode, int n, double[] cyr, double[] cyi, ref int nz, double rl, double fnul, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zbknu(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zbuni(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, int nui, ref int nlast, double fnul, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zbunk(double zr, double zi, double fnu, int kode, int mr, int n, double[] yr, double[] yi, ref int nz, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zkscl(double zrr, double zri, double fnu, int n, double[] yr, double[] yi, ref int nz, double rzr, double rzi, double ascle, double tol, double elim)
			{
				return 0;
			}

			private static int zmlri(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, double tol)
			{
				return 0;
			}

			private static int zrati(double zr, double zi, double fnu, int n, double[] cyr, double[] cyi, double tol)
			{
				return 0;
			}

			private static int zs1s2(double zrr, double zri, ref double s1r, ref double s1i, ref double s2r, ref double s2i, ref int nz, double ascle, double alim, ref int iuf)
			{
				return 0;
			}

			private static int zseri(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zshch(double zr, double zi, ref double cshr, ref double cshi, ref double cchr, ref double cchi)
			{
				return 0;
			}

			private static int zuchk(double yr, double yi, ref int nz, double ascle, double tol)
			{
				return 0;
			}

			private static int zunhj(double zr, double zi, double fnu, int ipmtr, double tol, ref double phir, ref double phii, ref double argr, ref double argi, ref double zeta1r, ref double zeta1i, ref double zeta2r, ref double zeta2i, ref double asumr, ref double asumi, ref double bsumr, ref double bsumi)
			{
				return 0;
			}

			private static int zuni1(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, ref int nlast, double fnul, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zuni2(double zr, double zi, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, ref int nlast, double fnul, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zunik(double zrr, double zri, double fnu, int ikflg, int ipmtr, double tol, ref int init, ref double phir, ref double phii, ref double zeta1r, ref double zeta1i, ref double zeta2r, ref double zeta2i, ref double sumr, ref double sumi, ref double[] cwrkr, ref double[] cwrki)
			{
				return 0;
			}

			private static int zunk1(double zr, double zi, double fnu, int kode, int mr, int n, double[] yr, double[] yi, ref int nz, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zunk2(double zr, double zi, double fnu, int kode, int mr, int n, double[] yr, double[] yi, ref int nz, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zuoik(double zr, double zi, double fnu, int kode, int ikflg, int n, double[] yr, double[] yi, ref int nuf, double tol, double elim, double alim)
			{
				return 0;
			}

			private static int zwrsk(double zrr, double zri, double fnu, int kode, int n, double[] yr, double[] yi, ref int nz, double[] cwr, double[] cwi, double tol, double elim, double alim)
			{
				return 0;
			}
		}

		internal static class MarcumQFunction
		{
			private static class IncompleteGamma
			{
				internal static void Incgam(double a, double x, out double p, out double q, out int ierr)
				{
					p = default(double);
					q = default(double);
					ierr = default(int);
				}

				internal static void Invincgam(double a, double p, double q, out double xr, out int ierr)
				{
					xr = default(double);
					ierr = default(int);
				}

				private static double Sinh(double x, double eps)
				{
					return 0.0;
				}

				private static double Exmin1(double x, double eps)
				{
					return 0.0;
				}

				private static double Exmin1minx(double x, double eps)
				{
					return 0.0;
				}

				private static double Logoneplusx(double x)
				{
					return 0.0;
				}

				private static double Lnec(double x)
				{
					return 0.0;
				}

				private static double Alfa(double x)
				{
					return 0.0;
				}

				internal static double Dompart(double a, double x, bool qt)
				{
					return 0.0;
				}

				private static double Chepolsum(int n, double x, double[] a)
				{
					return 0.0;
				}

				private static double Auxloggam(double x)
				{
					return 0.0;
				}

				internal static double Loggam(double x)
				{
					return 0.0;
				}

				private static double Auxgam(double x)
				{
					return 0.0;
				}

				private static double Lngam1(double x)
				{
					return 0.0;
				}

				private static double Stirling(double x)
				{
					return 0.0;
				}

				private static double Gamma(double x)
				{
					return 0.0;
				}

				private static double Gamstar(double x)
				{
					return 0.0;
				}

				private static double Errorfunction(double x, bool erfcc, bool expo)
				{
					return 0.0;
				}

				private static double Fractio(double x, int n, double[] r, double[] s)
				{
					return 0.0;
				}

				private static double PQasymp(double a, double x, double dp, bool p)
				{
					return 0.0;
				}

				private static double Saeta(double a, double eta)
				{
					return 0.0;
				}

				private static double Qfraction(double a, double x, double dp)
				{
					return 0.0;
				}

				private static double Qtaylor(double a, double x, double dp)
				{
					return 0.0;
				}

				private static double Ptaylor(double a, double x, double dp)
				{
					return 0.0;
				}

				private static double Eps1(double eta)
				{
					return 0.0;
				}

				private static double Eps2(double eta)
				{
					return 0.0;
				}

				private static double Eps3(double eta)
				{
					return 0.0;
				}

				private static double Lambdaeta(double eta)
				{
					return 0.0;
				}

				private static double Invq(double x)
				{
					return 0.0;
				}

				private static double Inverfc(double x)
				{
					return 0.0;
				}

				private static double Ratfun(double x, double[] ak, double[] bk)
				{
					return 0.0;
				}

				private static double InvGam(double a, double q, bool pgam)
				{
					return 0.0;
				}

				private static double Inveta(double x)
				{
					return 0.0;
				}
			}

			private static readonly double Tiny;

			private static readonly double Huge;

			private static readonly double TwoExp1Over4;

			private static readonly double MachTol;

			private static readonly double LnSqrt2Pi;

			private static readonly double Dwarf;

			private static readonly double Giant;

			private static readonly double ExpLow;

			private static readonly double Epss;

			public static void Marcum(double mu, double x, double y, out double p, out double q, out int ierr)
			{
				p = default(double);
				q = default(double);
				ierr = default(int);
			}

			private static double Fc(double pnu, double z)
			{
				return 0.0;
			}

			private static double Factor(double x, int n)
			{
				return 0.0;
			}

			private static double Pol(double[] fjkm, int d, double v)
			{
				return 0.0;
			}

			private static void Fjkproc16(double u, double[,] fjk)
			{
			}

			private static void SetFjk16(double[,] fjk, int j, int k, double[] un, double[] fjkm, double v)
			{
			}

			private static int Startingpser(double mu, double x, double y)
			{
				return 0;
			}

			private static double Ps(double mu, double mulnmu, double lnx, double y, double lny, double n, int a, int b)
			{
				return 0.0;
			}

			private static void Hypfun(double x, out double sinh, out double cosh)
			{
				sinh = default(double);
				cosh = default(double);
			}

			private static double Ignega(int n, double x)
			{
				return 0.0;
			}

			private static double Alfinv(int t, double r)
			{
				return 0.0;
			}

			private static double Falfa(double al, double r, int t, out double df)
			{
				df = default(double);
				return 0.0;
			}

			private static double Fi(double al, double r, int t)
			{
				return 0.0;
			}

			private static double Recipgam(double x, out double q, out double r)
			{
				q = default(double);
				r = default(double);
				return 0.0;
			}

			private static double Errorfunction(double x, bool erfcc, bool expo)
			{
				return 0.0;
			}

			private static double Fractio(double x, int n, double[] r, double[] s)
			{
				return 0.0;
			}

			private static double Zetaxy(double x, double y)
			{
				return 0.0;
			}

			private static double Chepolsum(int n, double t, double[] ak)
			{
				return 0.0;
			}

			private static double Oddchepolsum(int n, double x, double[] ak)
			{
				return 0.0;
			}

			private static double Logoneplusx(double t)
			{
				return 0.0;
			}

			private static double Xminsinx(double x)
			{
				return 0.0;
			}

			private static double Trapsum(double a, double b, double h, double d, double xis2, double mu, double wxis, double ys)
			{
				return 0.0;
			}

			private static double Trap(double a, double b, double e, double xis2, double mu, double wxis, double ys)
			{
				return 0.0;
			}

			private static void Integrand(double theta, ref double b0, out double inte, double xis2, double mu, double wxis, double ys)
			{
				inte = default(double);
			}

			private static void Qser(double mu, double x, double y, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void Pser(double mu, double x, double y, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void Prec(double mu, double x, double y, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void Qrec(double mu, double x, double y, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void PQasyxy(double mu, double x, double y, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void PQasymu(double mu0, double x0, double y0, out double p, out double q, out int ierro)
			{
				p = default(double);
				q = default(double);
				ierro = default(int);
			}

			private static void MarcumPQtrap(double mu, double x, double y, out double p, out double q, ref int ierr)
			{
				p = default(double);
				q = default(double);
			}
		}

		private static readonly double[] ErfImpAn;

		private static readonly double[] ErfImpAd;

		private static readonly double[] ErfImpBn;

		private static readonly double[] ErfImpBd;

		private static readonly double[] ErfImpCn;

		private static readonly double[] ErfImpCd;

		private static readonly double[] ErfImpDn;

		private static readonly double[] ErfImpDd;

		private static readonly double[] ErfImpEn;

		private static readonly double[] ErfImpEd;

		private static readonly double[] ErfImpFn;

		private static readonly double[] ErfImpFd;

		private static readonly double[] ErfImpGn;

		private static readonly double[] ErfImpGd;

		private static readonly double[] ErfImpHn;

		private static readonly double[] ErfImpHd;

		private static readonly double[] ErfImpIn;

		private static readonly double[] ErfImpId;

		private static readonly double[] ErfImpJn;

		private static readonly double[] ErfImpJd;

		private static readonly double[] ErfImpKn;

		private static readonly double[] ErfImpKd;

		private static readonly double[] ErfImpLn;

		private static readonly double[] ErfImpLd;

		private static readonly double[] ErfImpMn;

		private static readonly double[] ErfImpMd;

		private static readonly double[] ErfImpNn;

		private static readonly double[] ErfImpNd;

		private static readonly double[] ErvInvImpAn;

		private static readonly double[] ErvInvImpAd;

		private static readonly double[] ErvInvImpBn;

		private static readonly double[] ErvInvImpBd;

		private static readonly double[] ErvInvImpCn;

		private static readonly double[] ErvInvImpCd;

		private static readonly double[] ErvInvImpDn;

		private static readonly double[] ErvInvImpDd;

		private static readonly double[] ErvInvImpEn;

		private static readonly double[] ErvInvImpEd;

		private static readonly double[] ErvInvImpFn;

		private static readonly double[] ErvInvImpFd;

		private static readonly double[] ErvInvImpGn;

		private static readonly double[] ErvInvImpGd;

		private static readonly double[] _factorialCache;

		private const int GammaN = 10;

		private const double GammaR = 10.900511;

		private static readonly double[] GammaDk;

		private static readonly double[] BesselI0A;

		private static readonly double[] BesselI0B;

		private static readonly double[] BesselI1A;

		private static readonly double[] BesselI1B;

		private static readonly double[] BesselK0A;

		private static readonly double[] BesselK0B;

		private static readonly double[] BesselK1A;

		private static readonly double[] BesselK1B;

		public static Complex AiryAi(Complex z)
		{
			return default(Complex);
		}

		public static Complex AiryAiScaled(Complex z)
		{
			return default(Complex);
		}

		public static double AiryAi(double z)
		{
			return 0.0;
		}

		public static double AiryAiScaled(double z)
		{
			return 0.0;
		}

		public static Complex AiryAiPrime(Complex z)
		{
			return default(Complex);
		}

		public static Complex AiryAiPrimeScaled(Complex z)
		{
			return default(Complex);
		}

		public static double AiryAiPrime(double z)
		{
			return 0.0;
		}

		public static double AiryAiPrimeScaled(double z)
		{
			return 0.0;
		}

		public static Complex AiryBi(Complex z)
		{
			return default(Complex);
		}

		public static Complex AiryBiScaled(Complex z)
		{
			return default(Complex);
		}

		public static double AiryBi(double z)
		{
			return 0.0;
		}

		public static double AiryBiScaled(double z)
		{
			return 0.0;
		}

		public static Complex AiryBiPrime(Complex z)
		{
			return default(Complex);
		}

		public static Complex AiryBiPrimeScaled(Complex z)
		{
			return default(Complex);
		}

		public static double AiryBiPrime(double z)
		{
			return 0.0;
		}

		public static double AiryBiPrimeScaled(double z)
		{
			return 0.0;
		}

		public static Complex BesselJ(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex BesselJScaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static double BesselJ(double n, double z)
		{
			return 0.0;
		}

		public static double BesselJScaled(double n, double z)
		{
			return 0.0;
		}

		public static Complex BesselY(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex BesselYScaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static double BesselY(double n, double z)
		{
			return 0.0;
		}

		public static double BesselYScaled(double n, double z)
		{
			return 0.0;
		}

		public static Complex BesselI(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex BesselIScaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static double BesselI(double n, double z)
		{
			return 0.0;
		}

		public static double BesselIScaled(double n, double z)
		{
			return 0.0;
		}

		public static Complex BesselK(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex BesselKScaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static double BesselK(double n, double z)
		{
			return 0.0;
		}

		public static double BesselKScaled(double n, double z)
		{
			return 0.0;
		}

		public static double BetaLn(double z, double w)
		{
			return 0.0;
		}

		public static double Beta(double z, double w)
		{
			return 0.0;
		}

		public static double BetaIncomplete(double a, double b, double x)
		{
			return 0.0;
		}

		public static double BetaRegularized(double a, double b, double x)
		{
			return 0.0;
		}

		public static double Erf(double x)
		{
			return 0.0;
		}

		public static double Erfc(double x)
		{
			return 0.0;
		}

		public static double ErfInv(double z)
		{
			return 0.0;
		}

		private static double ErfImp(double z, bool invert)
		{
			return 0.0;
		}

		public static double ErfcInv(double z)
		{
			return 0.0;
		}

		private static double ErfInvImpl(double p, double q, double s)
		{
			return 0.0;
		}

		public static double Expm1(double power)
		{
			return 0.0;
		}

		[Obsolete("Use Expm1 instead")]
		public static double ExponentialMinusOne(double power)
		{
			return 0.0;
		}

		public static double ExponentialIntegral(double x, int n)
		{
			return 0.0;
		}

		public static double Factorial(int x)
		{
			return 0.0;
		}

		public static BigInteger Factorial(BigInteger x)
		{
			return default(BigInteger);
		}

		public static double FactorialLn(int x)
		{
			return 0.0;
		}

		public static double Binomial(int n, int k)
		{
			return 0.0;
		}

		public static double BinomialLn(int n, int k)
		{
			return 0.0;
		}

		public static double Multinomial(int n, int[] ni)
		{
			return 0.0;
		}

		public static double GammaLn(double z)
		{
			return 0.0;
		}

		public static double Gamma(double z)
		{
			return 0.0;
		}

		public static double GammaUpperRegularized(double a, double x)
		{
			return 0.0;
		}

		public static double GammaUpperIncomplete(double a, double x)
		{
			return 0.0;
		}

		public static double GammaLowerIncomplete(double a, double x)
		{
			return 0.0;
		}

		public static double GammaLowerRegularized(double a, double x)
		{
			return 0.0;
		}

		public static double GammaLowerRegularizedInv(double a, double y0)
		{
			return 0.0;
		}

		public static double DiGamma(double x)
		{
			return 0.0;
		}

		public static double DiGammaInv(double p)
		{
			return 0.0;
		}

		public static double RisingFactorial(double x, int n)
		{
			return 0.0;
		}

		public static double FallingFactorial(double x, int n)
		{
			return 0.0;
		}

		public static double GeneralizedHypergeometric(double[] a, double[] b, int z)
		{
			return 0.0;
		}

		private static double HGIncrement(double[] a, double[] b, int z, int currentN)
		{
			return 0.0;
		}

		public static Complex HankelH1(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex HankelH1Scaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex HankelH2(double n, Complex z)
		{
			return default(Complex);
		}

		public static Complex HankelH2Scaled(double n, Complex z)
		{
			return default(Complex);
		}

		public static double Harmonic(int t)
		{
			return 0.0;
		}

		public static double GeneralHarmonic(int n, double m)
		{
			return 0.0;
		}

		public static Complex KelvinBe(double nu, double x)
		{
			return default(Complex);
		}

		public static double KelvinBer(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinBer(double x)
		{
			return 0.0;
		}

		public static double KelvinBei(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinBei(double x)
		{
			return 0.0;
		}

		public static double KelvinBerPrime(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinBerPrime(double x)
		{
			return 0.0;
		}

		public static double KelvinBeiPrime(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinBeiPrime(double x)
		{
			return 0.0;
		}

		public static Complex KelvinKe(double nu, double x)
		{
			return default(Complex);
		}

		public static double KelvinKer(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinKer(double x)
		{
			return 0.0;
		}

		public static double KelvinKei(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinKei(double x)
		{
			return 0.0;
		}

		public static double KelvinKerPrime(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinKerPrime(double x)
		{
			return 0.0;
		}

		public static double KelvinKeiPrime(double nu, double x)
		{
			return 0.0;
		}

		public static double KelvinKeiPrime(double x)
		{
			return 0.0;
		}

		public static double Log1p(double x)
		{
			return 0.0;
		}

		public static double Logistic(double p)
		{
			return 0.0;
		}

		public static double Logit(double p)
		{
			return 0.0;
		}

		public static double MarcumQ(double nu, double a, double b)
		{
			return 0.0;
		}

		public static double MarcumQ(double nu, double a, double b, out int err)
		{
			err = default(int);
			return 0.0;
		}

		public static double BesselI0(double x)
		{
			return 0.0;
		}

		public static double BesselI1(double x)
		{
			return 0.0;
		}

		public static double BesselK0(double x)
		{
			return 0.0;
		}

		public static double BesselK0e(double x)
		{
			return 0.0;
		}

		public static double BesselK1(double x)
		{
			return 0.0;
		}

		public static double BesselK1e(double x)
		{
			return 0.0;
		}

		public static double StruveL0(double x)
		{
			return 0.0;
		}

		public static double StruveL1(double x)
		{
			return 0.0;
		}

		public static double BesselI0MStruveL0(double x)
		{
			return 0.0;
		}

		public static double BesselI1MStruveL1(double x)
		{
			return 0.0;
		}

		public static Complex SphericalBesselJ(double n, Complex z)
		{
			return default(Complex);
		}

		public static double SphericalBesselJ(double n, double z)
		{
			return 0.0;
		}

		public static Complex SphericalBesselY(double n, Complex z)
		{
			return default(Complex);
		}

		public static double SphericalBesselY(double n, double z)
		{
			return 0.0;
		}

		public static Complex Hypotenuse(Complex a, Complex b)
		{
			return default(Complex);
		}

		public static Complex32 Hypotenuse(Complex32 a, Complex32 b)
		{
			return default(Complex32);
		}

		public static double Hypotenuse(double a, double b)
		{
			return 0.0;
		}

		public static float Hypotenuse(float a, float b)
		{
			return 0f;
		}
	}
}
