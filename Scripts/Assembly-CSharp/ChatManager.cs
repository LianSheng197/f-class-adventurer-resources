using System.Collections.Generic;
using SocketIOUnity;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
	private static ChatManager _Instance;

	public byte _lastChatTab;

	public string _chatChannel;

	public string _initChannel;

	public string _chatGuildChannel;

	public GameObject _LinChatObj;

	public UILabel _LineChatLabel;

	public const int _maxBlockCount = 200;

	public Dictionary<string, ChatBlockInfo> _chatBlockList;

	public LimitedSizeList<ChatData> _chatList;

	public LimitedSizeList<ChatData> _guildChatList;

	public static SocketIO_Chat _chatSocket;

	private bool _isConnect;

	private bool _isActvie;

	private bool _init;

	public bool _isNewGuildChat;

	private double _disconnectedTime;

	private const double _reconnectElapseSeconds = 60.0;

	private const double _autoReconnectElapseSeconds = 300.0;

	private Dictionary<int, int> _channelNameDic;

	private string kickGuildUserString;

	public static ChatManager Instance => null;

	private bool IsConnect()
	{
		return false;
	}

	private bool IsReconnect()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void Reconnect()
	{
	}

	public void Clear()
	{
	}

	public void Close()
	{
	}

	public void InitChannel()
	{
	}

	public void Init()
	{
	}

	public void MoveChannel(string channel)
	{
	}

	public void MoveGuildChannel()
	{
	}

	public void SendChat(string chat)
	{
	}

	public void SendKickGuildUser(string name)
	{
	}

	private void ConnectAck(string res)
	{
	}

	private void ReConnectAck(string res)
	{
	}

	private void ReleaseAck(string res)
	{
	}

	private void MoveChannel()
	{
	}

	private void InitNormalTab(string initChannelId, string prevChannel)
	{
	}

	private void InitGuildTab(string initGuildId, string prevGuildId)
	{
	}

	private ChatData initChatData(byte type)
	{
		return null;
	}

	private void AddChat(ChatData data)
	{
	}

	public void UpdateLineChat()
	{
	}

	public bool IsMaxBlock()
	{
		return false;
	}

	public bool IsBlockUser(string userCode)
	{
		return false;
	}

	public void AddBlockUserList(List<ChatBlockInfo> blockDataList)
	{
	}

	public void AddBlockUser(ChatBlockInfo blockData)
	{
	}

	public void RemoveBlockUser(string userId)
	{
	}

	private void msgAck(string res)
	{
	}

	private void SubscribeChannelAck(string res)
	{
	}

	private void SubscribeGuildChannelAck(string res)
	{
	}
}
