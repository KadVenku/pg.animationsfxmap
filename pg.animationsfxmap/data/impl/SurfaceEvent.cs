using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SurfaceEvent : ASfxEvent
    {
        private SurfaceFxTriggerType _surfaceFxTrigger;
        private string _attachmentBoneName;

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

        public SurfaceEvent(string animationKey, uint frameTick, SurfaceFxTriggerType surfaceFxTrigger, string attachmentBoneName) : base(SfxEventType.SURFACE)
        {
            AnimationKey = animationKey;
            FrameTick = frameTick;
            SurfaceFxTrigger = surfaceFxTrigger;
            AttachmentBoneName = attachmentBoneName;
        }

        public override string ToAnimationSfxMapEntry()
        {
            return $"{nameof(_sfxEventType).ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{nameof(_surfaceFxTrigger)}\t{AttachmentBoneName}";
        }
    }
}
