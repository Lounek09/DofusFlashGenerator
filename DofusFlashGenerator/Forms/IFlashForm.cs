using DofusFlashGenerator.Models;

namespace DofusFlashGenerator.Forms;

public interface IFlashForm
{
    IReadOnlyList<IData> GenericData { get; }
    int Index { get; }
    int LastIndex => GenericData.Count - 1;
    bool IsAutoPlay { get; }
    bool IsAutoScreen { get; }

    Task Display(int index);

    Task AutoPlay(bool enable);

    void Screen();
}

public interface IFlashForm<T> : IFlashForm where T : IData
{
    IReadOnlyList<T> Data { get; }
}
