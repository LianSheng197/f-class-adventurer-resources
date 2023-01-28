using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Spine
{
	public class TrackEntry : Pool<TrackEntry>.IPoolable
	{
		internal Animation animation;

		internal TrackEntry next;

		internal TrackEntry mixingFrom;

		internal int trackIndex;

		internal bool loop;

		internal float eventThreshold;

		internal float attachmentThreshold;

		internal float drawOrderThreshold;

		internal float animationStart;

		internal float animationEnd;

		internal float animationLast;

		internal float nextAnimationLast;

		internal float delay;

		internal float trackTime;

		internal float trackLast;

		internal float nextTrackLast;

		internal float trackEnd;

		internal float timeScale;

		internal float alpha;

		internal float mixTime;

		internal float mixDuration;

		internal float interruptAlpha;

		internal float totalAlpha;

		internal readonly ExposedList<int> timelineData;

		internal readonly ExposedList<TrackEntry> timelineDipMix;

		internal readonly ExposedList<float> timelinesRotation;

		public int TrackIndex => 0;

		public Animation Animation => null;

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Delay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TrackTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TrackEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnimationStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnimationEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnimationLast
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnimationTime => 0f;

		public float TimeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EventThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AttachmentThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float DrawOrderThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TrackEntry Next => null;

		public bool IsComplete => false;

		public float MixTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MixDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TrackEntry MixingFrom => null;

		public event AnimationState.TrackEntryDelegate Start
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event AnimationState.TrackEntryDelegate Interrupt
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event AnimationState.TrackEntryDelegate End
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event AnimationState.TrackEntryDelegate Dispose
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event AnimationState.TrackEntryDelegate Complete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event AnimationState.TrackEntryEventDelegate Event
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Reset()
		{
		}

		internal TrackEntry SetTimelineData(TrackEntry to, ExposedList<TrackEntry> mixingToArray, HashSet<int> propertyIDs)
		{
			return null;
		}

		private bool HasTimeline(int id)
		{
			return false;
		}

		internal void OnStart()
		{
		}

		internal void OnInterrupt()
		{
		}

		internal void OnEnd()
		{
		}

		internal void OnDispose()
		{
		}

		internal void OnComplete()
		{
		}

		internal void OnEvent(Event e)
		{
		}

		public void ResetRotationDirections()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
