using System;

public class GachaCharacterReq : ReqParam
{
	public int _gachaIdx;

	public int _gachaBonusGroupId;

	public bool _isFree;

	public int _isItemCount;

	public int _gachaChangeId;

	public int _reqStep;

	[Obsolete("누른 구매 버튼에 해당하는 GachaGroup.gachaCountList 의 index 입력.", true)]
	public int _buyCount;

	public int gachaCountListIndex;

	public int countOfGachaGroupItemIDToConsume;
}
