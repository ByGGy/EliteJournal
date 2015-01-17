using System.Windows.Media;

namespace Infrastructure
{
    public static class VisualExtension
    {
        public static T GetFirstParent<T>(this Visual element) where T : Visual
        {
            if (element != null)
            {
                if (element.GetType() == typeof(T))
                    return (T)element;

                Visual parent = VisualTreeHelper.GetParent(element) as Visual;
                return GetFirstParent<T>(parent);
            }

            return default(T);
        }

        public static T GetFirstChild<T>(this Visual element) where T : Visual
        {
            if (element != null)
            {
                if (element.GetType() == typeof(T))
                    return (T)element;

                T targetChild = default(T);
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
                {
                    Visual child = VisualTreeHelper.GetChild(element, i) as Visual;
                    targetChild = GetFirstChild<T>(child);
                    if (targetChild != default(T))
                        return targetChild;
                }
            }

            return default(T);
        }
    }
}
