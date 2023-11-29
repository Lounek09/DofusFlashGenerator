namespace DofusFlashGenerator.Forms;

public interface IFlashForm
{
    int Index { get; }
    bool IsAutoPlay { get; }
    bool IsAutoScreen { get; }

    Task Display(int index);

    Task AutoPlay(bool enable);

    void Screen();
}
