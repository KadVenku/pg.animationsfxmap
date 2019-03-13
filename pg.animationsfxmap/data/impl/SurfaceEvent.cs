using pg.animationsfxmap.data.basetypes;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.data.impl
{
    public class SurfaceEvent : ASfxEvent
    {
        public SurfaceEvent(string animationKey, uint frameTick, SurfaceFxTriggerType surfaceFxTrigger, string attachmentBoneName) : base(SfxEventType.SURFACE)
        {
            AnimationKey = animationKey;
            FrameTick = frameTick;
            SurfaceFxTrigger = surfaceFxTrigger;
            AttachmentBoneName = attachmentBoneName;
        }

        public override int GetHashCode()
        {
            return $"{EventType.ToString().ToUpper()}{AnimationKey.ToLower()}{FrameTick}{SurfaceFxTrigger.ToString().ToUpper()}{AttachmentBoneName}".GetHashCode();
        }

        public override string ToAnimationSfxMapEntry()
        {
            return $"{EventType.ToString().ToUpper()}\t{AnimationKey.ToLower()}\t{FrameTick}\t{SurfaceFxTrigger.ToString().ToUpper()}\t{AttachmentBoneName}";
        }
    }
}
