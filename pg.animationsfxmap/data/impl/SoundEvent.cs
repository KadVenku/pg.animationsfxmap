using System;
using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SoundEvent : ASfxEvent, IEquatable<SoundEvent>
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

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToAnimationSfxMapEntry()
        {
            return $"{EventType.ToString().ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{SoundEventKey}";
        }

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return false;
                case SoundEvent evt:
                    return Equals(evt);
                default:
                    return false;
            }
        }

        private bool Equals(SoundEvent evt)
        {
            return GetHashCode().Equals(evt.GetHashCode());
        }

        public override string ToString()
        {
            return ToAnimationSfxMapEntry();
        }

        bool IEquatable<SoundEvent>.Equals(SoundEvent other)
        {
            return Equals(other);
        }
    }
}
