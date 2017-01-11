using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms
{
	public interface INavigationPageController
	{
		Page Peek(int depth);

		IEnumerable<Page> Pages { get; }

		int StackDepth { get; }

		Task<Page> PopAsyncInner(bool animated, bool fast = false);

		event EventHandler<NavigationRequestedEventArgs> InsertPageBeforeRequested;

		event EventHandler<NavigationRequestedEventArgs> PopRequested;

		event EventHandler<NavigationRequestedEventArgs> PopToRootRequested;

		event EventHandler<NavigationRequestedEventArgs> PushRequested;

		event EventHandler<NavigationRequestedEventArgs> RemovePageRequested;
	}
}