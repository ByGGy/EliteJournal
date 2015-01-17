using System.Windows;
using System.Windows.Interactivity;

namespace Infrastructure
{
    public class VisualStateSelectorBehavior : Behavior<FrameworkElement>
    {
        public string VisualStateSelected
        {
            get { return (string)GetValue(VisualStateSelectedProperty); }
            set { SetValue(VisualStateSelectedProperty, value); }
        }

        public static readonly DependencyProperty VisualStateSelectedProperty =
            DependencyProperty.Register("VisualStateSelected", typeof(string), typeof(VisualStateSelectorBehavior), new UIPropertyMetadata(string.Empty, OnVisualStateSelectedChangeHandler));

        private static void OnVisualStateSelectedChangeHandler(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //TODO: use GoToElementState to avoid using a ControlTemplate ?
            VisualStateSelectorBehavior behavior = d as VisualStateSelectorBehavior;
            if ((behavior != null) && (behavior.AssociatedObject != null))
                VisualStateManager.GoToElementState(behavior.AssociatedObject, behavior.VisualStateSelected, true);
//                VisualStateManager.GoToState(behavior.AssociatedObject, behavior.VisualStateSelected, true);
        }
    }
}
