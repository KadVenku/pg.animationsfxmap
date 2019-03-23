namespace pg.animationsfxmap.utils
{
    public sealed class TickUtility
    {
        private const uint TICKS_PER_FRAME = 80;

        public static uint FramesToTicks(uint frames)
        {
            return frames * TICKS_PER_FRAME;
        }

        public static uint TicksToFrames(uint ticks)
        {
            return ticks / TICKS_PER_FRAME;
        }
    }
}
