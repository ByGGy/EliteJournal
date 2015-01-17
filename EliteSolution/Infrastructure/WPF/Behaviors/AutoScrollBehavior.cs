using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Infrastructure
{
    public class AutoScrollBehavior : Behavior<ItemsControl>
    {
        protected override void OnAttached()
        {
            AssociatedObject.Loaded += OnLoadedHandler;
            AssociatedObject.Unloaded += OnUnloadedHandler;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.Loaded -= OnLoadedHandler;
            AssociatedObject.Unloaded -= OnUnloadedHandler;
        }

        private void OnLoadedHandler(object sender, RoutedEventArgs e)
        {
            INotifyCollectionChanged target = AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (target != null)
                target.CollectionChanged += OnCollectionChangedHandler;
        }

        private void OnUnloadedHandler(object sender, RoutedEventArgs e)
        {
            INotifyCollectionChanged target = AssociatedObject.ItemsSource as INotifyCollectionChanged;
            if (target != null)
                target.CollectionChanged -= OnCollectionChangedHandler;
        }

        private void OnCollectionChangedHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            ScrollViewer scroller = AssociatedObject.GetFirstChild<ScrollViewer>();
            if (scroller != null)
                scroller.ScrollToEnd();
        }
    }
}
