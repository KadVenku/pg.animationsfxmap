using System;
using pg.animationsfxmap.data.interfaces;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.basetypes
{
    public abstract class ASfxEvent : ISfxEvent
    {
        protected readonly Guid _GUID;
        protected SfxEventType _sfxEventType;
        protected string _animationKey;
        protected uint _frameTick;

        public string Uid => _GUID.ToString();
        public SfxEventType EventType { get => _sfxEventType; }
        public uint FrameTick
        {
            get => _frameTick;
            set => _frameTick = value;
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
    }
}