namespace DofusFlashGenerator.Extensions;

public static class ControlExtension
{
    public static T? GetNearestParentOfType<T>(this Control control)
    {
        if (control.Parent is T parent)
        {
            return parent;
        }

        if (control.Parent is null)
        {
            return default;
        }

        return GetNearestParentOfType<T>(control.Parent);
    }
}
