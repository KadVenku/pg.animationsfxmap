using System;
using pg.animationsfxmap.data.interfaces;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.basetypes
{
    public abstract class ASfxEvent : ISfxEvent
    {
        private readonly Guid _GUID;
        private readonly SfxEventType _sfxEventType;
        private string _animationKey;
        private uint _animationTick;

        public string Uid => _GUID.ToString();
        public SfxEventType EventType { get => _sfxEventType; }
        public uint AnimationTick
        {
            get => _animationTick;
            set => _animationTick = value;
        }
        public string AnimationKey
        {
            get => _animationKey;
            set => _animationKey = value;
        }
        
        protected ASfxEvent()
        {
            _GUID = Guid.NewGuid();
            _sfxEventType = SfxEventType.INVALID;
        }

        protected ASfxEvent(SfxEventType sfxEventType)
        {
            _GUID = Guid.NewGuid();
            _sfxEventType = sfxEventType;
        }

        public abstract string ToAnimationSfxMapEntry();

        public abstract override int GetHashCode();

        public override string ToString()
        {
            return $"[{nameof(Uid)}={Uid};{nameof(EventType)}={EventType.ToString()};{nameof(AnimationKey)}={AnimationKey};]";
        }
    }
}