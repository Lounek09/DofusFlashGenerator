namespace DofusFlashGenerator.Forms
{
    public interface IFlashForm
    {
        public int Index { get; }
        public bool IsAutoPlay { get; }
        public bool IsAutoScreen { get; }

        public Task Display(int index);

        public Task AutoPlay(bool enable);

        public void Screen();
    }
}
