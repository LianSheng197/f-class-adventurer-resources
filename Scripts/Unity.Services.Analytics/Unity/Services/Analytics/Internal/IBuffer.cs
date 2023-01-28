using System;
using System.Collections.Generic;

namespace Unity.Services.Analytics.Internal
{
	internal interface IBuffer
	{
		string UserID { get; set; }

		string InstallID { get; set; }

		string PlayerID { get; set; }

		string SessionID { get; set; }

		int Length { get; }

		string Serialize(List<Buffer.Token> tokens);

		void InsertTokens(List<Buffer.Token> tokens);

		void PushStartEvent(string name, DateTime datetime, long? eventVersion, bool addPlayerIdsToEventBody = false);

		void PushEndEvent();

		void PushObjectStart(string name = null);

		void PushObjectEnd();

		void PushArrayStart(string name = null);

		void PushArrayEnd();

		void PushDouble(double val, string name = null);

		void PushFloat(float val, string name = null);

		void PushString(string val, string name = null);

		void PushInt64(long val, string name = null);

		void PushInt(int val, string name = null);

		void PushBool(bool val, string name = null);

		void PushTimestamp(DateTime val, string name = null);

		void FlushToDisk();

		void ClearDiskCache();

		void ClearBuffer();

		void LoadFromDisk();

		void PushEvent(Event evt);

		List<Buffer.Token> CloneTokens();
	}
}
