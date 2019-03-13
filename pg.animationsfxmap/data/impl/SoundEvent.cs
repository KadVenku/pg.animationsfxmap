using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SoundEvent : ASfxEvent
    {
        public SoundEvent(string animationKey, uint frameTick, string soundEventKey) : base(SfxEventType.SOUND)
        {
            AnimationKey = animationKey;
            FrameTick = frameTick;
            SoundEventKey = soundEventKey;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return $"{EventType.ToString().ToUpper()}{AnimationKey.ToLower()}{FrameTick}{SoundEventKey}".GetHashCode();
        }

        public override string ToAnimationSfxMapEntry()
        {
            return $"{EventType.ToString().ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{SoundEventKey}";
        }
    }
}
