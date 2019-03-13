using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SoundEvent : ASfxEvent
    {
        private string _soundEventKey;

        public string SoundEventKey
        {
            get => _soundEventKey;
            set => _soundEventKey = value;
        }
        public SoundEvent(string animationKey, uint frameTick, string soundEventKey) : base(SfxEventType.SOUND)
        {
            AnimationKey = animationKey;
            FrameTick = frameTick;
            SoundEventKey = soundEventKey;
        }
        public override string ToAnimationSfxMapEntry()
        {
            return $"{nameof(EventType).ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{SoundEventKey}";
        }
    }
}
