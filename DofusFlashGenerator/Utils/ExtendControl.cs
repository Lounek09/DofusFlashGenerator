namespace DofusFlashGenerator.Utils;

public static class ExtendControl
{
    public static T? GetNearestParentAs<T>(this Control control)
    {
        if (control.Parent is T parent)
        {
            return parent;
        }

        if (control.Parent is null)
        {
            return default;
        }

        return GetNearestParentAs<T>(control.Parent);
    }
}
