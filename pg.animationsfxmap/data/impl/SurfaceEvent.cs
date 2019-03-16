using System;
using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SurfaceEvent : ASfxEvent, IEquatable<SurfaceEvent>
    {
        private SurfaceFxTrigger _surfaceFxTrigger;
        private string _attachmentBoneName;

        public SurfaceFxTrigger SurfaceFxTrigger
        {
            get => _surfaceFxTrigger;
            set => _surfaceFxTrigger = value;
        }

        public string AttachmentBoneName
        {
            get => _attachmentBoneName;
            set => _attachmentBoneName = value;
        }

        public SurfaceEvent(string animationKey, uint frameTick, SurfaceFxTrigger surfaceFxTrigger, string attachmentBoneName) : base(SfxEventType.SURFACE)
        {
            AnimationKey = animationKey;
            FrameTick = frameTick;
            SurfaceFxTrigger = surfaceFxTrigger;
            AttachmentBoneName = attachmentBoneName;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToAnimationSfxMapEntry()
        {
            return $"{EventType.ToString().ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{SurfaceFxTrigger.ToString().ToUpper()}\t{AttachmentBoneName}";
        }

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return false;
                case SurfaceEvent evt:
                    return Equals(evt);
                default:
                    return false;
            }
        }

        private bool Equals(SurfaceEvent evt)
        {
            return GetHashCode().Equals(evt.GetHashCode());
        }

        public override string ToString()
        {
            return ToAnimationSfxMapEntry();
        }

        bool IEquatable<SurfaceEvent>.Equals(SurfaceEvent other)
        {
            return Equals(other);
        }
    }
}
