using System.Security.Cryptography;

public class SecureRandom : RandomNumberGenerator
{
	private readonly RandomNumberGenerator rng;

	public int Next()
	{
		return 0;
	}

	public int Next(int maxValue)
	{
		return 0;
	}

	public int Next(int minValue, int maxValue)
	{
		return 0;
	}

	public double NextDouble()
	{
		return 0.0;
	}

	public override void GetBytes(byte[] data)
	{
	}

	public override void GetNonZeroBytes(byte[] data)
	{
	}
}
