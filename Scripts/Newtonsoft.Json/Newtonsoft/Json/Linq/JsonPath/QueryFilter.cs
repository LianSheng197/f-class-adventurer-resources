using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	internal class QueryFilter : PathFilter
	{
		[CompilerGenerated]
		private sealed class _003CExecuteFilter_003Ed__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<JToken> current;

			public IEnumerable<JToken> _003C_003E3__current;

			public QueryFilter _003C_003E4__this;

			private JToken root;

			public JToken _003C_003E3__root;

			private JsonSelectSettings settings;

			public JsonSelectSettings _003C_003E3__settings;

			private IEnumerator<JToken> _003C_003E7__wrap1;

			private IEnumerator<JToken> _003C_003E7__wrap2;

			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CExecuteFilter_003Ed__2(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		internal QueryExpression Expression;

		public QueryFilter(QueryExpression expression)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteFilter_003Ed__2))]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings? settings)
		{
			return null;
		}
	}
}
