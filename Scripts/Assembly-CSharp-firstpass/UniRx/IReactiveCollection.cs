using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UniRx
{
	[DefaultMember("Item")]
	public interface IReactiveCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T>
	{
		new int Count { get; }

		new T Item { get; set; }

		void Move(int oldIndex, int newIndex);
	}
}
