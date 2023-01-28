public class ProgressData
{
	private int _progTotal;

	private int _progCur;

	private int _progOld;

	private float _percentCur;

	private float _percentOld;

	public ProgressData(int progCur, int progTotal)
	{
	}

	public void InitValue(int progCur, int progTotal)
	{
	}

	public void Advance(int adv)
	{
	}

	public bool IsPercentAdvanced(float advancedPercent)
	{
		return false;
	}

	public bool IsProgressAdvanced(int advancedProg)
	{
		return false;
	}

	public bool IsProgressDone()
	{
		return false;
	}

	public bool IsProgressZero()
	{
		return false;
	}

	public string GetPercentString()
	{
		return null;
	}

	public string GetProgressString()
	{
		return null;
	}

	public string GetProgressString2()
	{
		return null;
	}
}
