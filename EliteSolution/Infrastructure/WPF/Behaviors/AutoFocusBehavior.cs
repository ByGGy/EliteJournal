using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Infrastructure
{
    public class AutoFocusBehavior : Behavior<FrameworkElement>
    {
        protected override void OnAttached()
        {
            AssociatedObject.Loaded += OnLoadedHandler;
            AssociatedObject.IsVisibleChanged += OnVisibleChangedHandler;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.Loaded -= OnLoadedHandler;
            AssociatedObject.IsVisibleChanged -= OnVisibleChangedHandler;
        }

        private void OnLoadedHandler(object sender, RoutedEventArgs e)
        {
            AssociatedObject.Focus();
            Keyboard.Focus(AssociatedObject);
        }

        private void OnVisibleChangedHandler(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                AssociatedObject.Focus();
                Keyboard.Focus(AssociatedObject);                
            }
        }
    }
}
