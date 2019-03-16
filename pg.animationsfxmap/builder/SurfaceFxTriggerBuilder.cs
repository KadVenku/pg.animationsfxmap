using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using pg.animationsfxmap.enums;

namespace pg.animationsfxmap.builder
{
    public sealed class SurfaceFxTriggerBuilder
    {
        private static readonly Tuple<string, int>[] SURFACE_FX_TRIGGER_TYPE_FALLBACK =
        {
            new Tuple<string, int>("GENERIC_TRACK", 0),
            new Tuple<string, int>("AT_AT_FOOTPRINT", 1),
            new Tuple<string, int>("DYNAMIC_TRACK_DEFAULT", 2),
            new Tuple<string, int>("INFANTRY_FOOT_PLANT", 3),
            new Tuple<string, int>("GENERIC_IMPACT", 4),
            new Tuple<string, int>("TROOPER_IMPACT", 5),
            new Tuple<string, int>("PROJECTILE", 6),
            new Tuple<string, int>("HOVER", 7),
            new Tuple<string, int>("DYNAMIC_TRACK_WITH_EMITTER", 8),
            new Tuple<string, int>("PROJECTILE_INFANTRY", 9),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_MEDIUM", 10),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_SMALL", 11),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_LARGE", 12),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_HUGE", 13),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_TINY", 14),
            new Tuple<string, int>("RANCOR_FOOTPRINT", 15),
            new Tuple<string, int>("ATAA_FOOTPRINT_RIGHT", 16),
            new Tuple<string, int>("ATAA_FOOTPRINT_LEFT", 17),
            new Tuple<string, int>("GENERIC_TRACK_HALF", 18),
            new Tuple<string, int>("POD_WALKER_FOOTPRINT", 19),
            new Tuple<string, int>("AT-ST_FOOTPRINT", 20),
            new Tuple<string, int>("SPMAT_FOOTPRINT", 21),
            new Tuple<string, int>("GENERIC_FOOTPRINT", 22),
            new Tuple<string, int>("R2D2_FOOTPRINT", 23),
            new Tuple<string, int>("HOVER_NO_PARTICLES", 24),
            new Tuple<string, int>("GOOD_GROUND", 25),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_MASSIVE", 26),
            new Tuple<string, int>("EXPLOSION_SCORCH_MARK_MASSIVE_DARK", 27),
            new Tuple<string, int>("HIGH_GROUND", 28),
            new Tuple<string, int>("SLOW_GROUND", 29),
            new Tuple<string, int>("DAMAGE_GROUND", 30),
            new Tuple<string, int>("INFANTRY_TERRAIN_MODIFIER", 31),
            new Tuple<string, int>("VEHICLE_TERRAIN_MODIFIER", 32),
            new Tuple<string, int>("INFANTRY_ONLY_GROUND", 33)
        };

        public static SurfaceFxTrigger Build(string name, int id)
        {
            return new SurfaceFxTrigger(name, id);
        }

        public static List<SurfaceFxTrigger> BuildFromXml(string path)
        {
            List<SurfaceFxTrigger> surfaceFxTriggers = new List<SurfaceFxTrigger>();
            if (File.Exists(path))
            {
                XDocument xmlTriggerTypeEnumDefinition = XDocument.Load(path);
                if (xmlTriggerTypeEnumDefinition.Root != null)
                {
                    surfaceFxTriggers.AddRange(xmlTriggerTypeEnumDefinition.Root.Elements().Select(xElement => Build(xElement.Name.ToString(), int.Parse(xElement.Value))));
                }
            }
            else
            {
                surfaceFxTriggers.AddRange(SURFACE_FX_TRIGGER_TYPE_FALLBACK.Select(tuple => Build(tuple.Item1, tuple.Item2)));
            }

            return surfaceFxTriggers;
        }
    }
}