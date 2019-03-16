using System.Collections.Generic;
using pg.animationsfxmap.builder;
using pg.animationsfxmap.enums;
using pg.util.interfaces.impl;

namespace pg.animationsfxmap.data.holder
{
    public class SurfaceFxTriggerDataHolder : AImmutableDataHolder<string, SurfaceFxTrigger>
    {
        public override void Init()
        {
            List<SurfaceFxTrigger> triggers = SurfaceFxTriggerBuilder.BuildFromXml("");
            foreach (SurfaceFxTrigger surfaceFxTrigger in triggers)
            {
                _DATA.TryAdd(surfaceFxTrigger.Name.ToLower(), surfaceFxTrigger);
            }

            IsInitialised = true;
        }
    }
}
