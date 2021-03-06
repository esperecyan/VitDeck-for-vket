#if VRC_SDK_VRCSDK3
using UnityEngine;

namespace VitDeck.Validator
{
    public class UdonCubeRuleSet : VketUdonRuleSetBase
    {
        public override string RuleSetName
        {
            get
            {
                return "Vket - UdonCube";
            }
        }

        protected override long FolderSizeLimit
        {
            get
            {
                return 100 * MegaByte;
            }
        }

        protected override Vector3 BoothSizeLimit
        {
            get
            {
                return new Vector3(10, 10, 10);
            }
        }

        protected override int UdonBehaviourCountLimit
        {
            get
            {
                return 25;
            }
        }

        protected override int UdonBehaviourSynchronizePositionCountLimit
        {
            get
            {
                return 10;
            }
        }

        protected override int UdonScriptSyncedVariablesLimit
        {
            get
            {
                return 3;
            }
        }

        protected override int MaterialUsesLimit
        {
            get
            {
                return 60;
            }
        }

        protected override int LightmapCountLimit
        {
            get
            {
                return 2;
            }
        }

        protected override int VRCStationCountLimit
        {
            get
            {
                return 8;
            }
        }

        protected override LightConfigRule.LightConfig ApprovedPointLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new [] { LightmapBakeType.Baked, LightmapBakeType.Realtime });
            }
        }

        protected override LightConfigRule.LightConfig ApprovedSpotLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked, LightmapBakeType.Realtime });
            }
        }

        protected override LightConfigRule.LightConfig ApprovedAreaLightConfig
        {
            get
            {
                return new LightConfigRule.LightConfig(
                            new[] { LightmapBakeType.Baked });
            }
        }

        protected override int AreaLightUsesLimit
        {
            get
            {
                return 3;
            }
        }

        protected override LightmapBakeType[] unusablePointLightModes
        {
            get
            {
                return new LightmapBakeType[] { LightmapBakeType.Realtime, LightmapBakeType.Mixed };
            }
        }

        protected override LightmapBakeType[] unusableSpotLightModes
        {
            get
            {
                return new LightmapBakeType[] { LightmapBakeType.Realtime, LightmapBakeType.Mixed };
            }
        }

        protected override ValidationLevel MoreAdvancedObjectValidationLevel
        {
            get
            {
                return ValidationLevel.ALLOW;
            }
        }

        protected override int ChairPrefabUsesLimit
        {
            get
            {
                return 1;
            }
        }

        protected override int PickupObjectSyncUsesLimit
        {
            get
            {
                return 10;
            }
        }
    }
}
#endif