using System;
using pg.animationsfxmap.data.interfaces;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.basetypes
{
    public abstract class ASfxEvent : ISfxEvent, IEquatable<ASfxEvent>
    {
        private readonly Guid _GUID;
        private readonly SfxEventType _sfxEventType;
        private string _animationKey;
        private uint _frameTick;
        private string _soundEventKey;
        private SurfaceFxTriggerType _surfaceFxTrigger;
        private string _attachmentBoneName;

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

        public string SoundEventKey
        {
            get => _soundEventKey;
            set => _soundEventKey = value;
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

        public SurfaceFxTriggerType SurfaceFxTrigger
        {
            get => _surfaceFxTrigger;
            set => _surfaceFxTrigger = value;
        }

        public string AttachmentBoneName
        {
            get => _attachmentBoneName;
            set => _attachmentBoneName = value;
        }

        public abstract string ToAnimationSfxMapEntry();

        public abstract override int GetHashCode();

        public override string ToString()
        {
            return $"[{nameof(Uid)}={Uid};{nameof(EventType)}={EventType.ToString()};{nameof(AnimationKey)}={AnimationKey};]";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ASfxEvent);
        }

        public bool Equals(ASfxEvent other)
        {
            if (other != null)
            {
                return GetHashCode() == other.GetHashCode();
            }

            return false;
        }

        public static bool operator ==(ASfxEvent event1, ASfxEvent event2)
        {
            return event1?._GUID == event2?._GUID;
        }

        public static bool operator !=(ASfxEvent event1, ASfxEvent event2)
        {
            return !(event1 == event2);
        }
    }
}