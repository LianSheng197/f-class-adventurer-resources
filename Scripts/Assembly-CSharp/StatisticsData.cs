public class StatisticsData
{
	private long firstAddedTimestampInSec;

	private long count;

	private double oldMean;

	private double newMean;

	private double oldStdDev;

	private double newStdDev;

	private double min;

	private double max;

	private double sum;

	public long FirstAddedTimestampInSec => 0L;

	public long Count => 0L;

	public double Mean => 0.0;

	public double StdDev => 0.0;

	public double Min => 0.0;

	public double Max => 0.0;

	public double Sum => 0.0;

	public StatisticsData Init()
	{
		return null;
	}

	public void Clear()
	{
	}

	public void Add(double v, bool addToCount = false)
	{
	}

	private double Variance()
	{
		return 0.0;
	}
}
