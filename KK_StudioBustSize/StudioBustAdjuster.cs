using BepInEx;
using BepInEx.Logging;
using Illusion.Component.Correct;
using KK_Plugins;
using KKABMX.Core;
using KKAPI;
using KKAPI.Chara;
using KKAPI.Studio;
using KKAPI.Studio.UI;
using MessagePack;
using Studio;
using System;
using UniRx;
using UnityEngine;
using static Illusion.Utils;
using static KK_Plugins.Pushup;

namespace KK_StudioBustAdjuster
{
    [BepInPlugin(GUID, "Studio Bust Adjuster", Version)]
    [BepInDependency(KoikatuAPI.GUID, KoikatuAPI.VersionConst)]
    [BepInDependency(KKABMX_Core.GUID, "5.1")]
    [BepInDependency(KK_Plugins.Pushup.GUID, "1.3.2")]
    public partial class StudioBustAdjuster : BaseUnityPlugin
    {
        public const string GUID = "Vaaskr.StudioBustAdjuster";
        public const string Version = "1.0.0";
        internal static new ManualLogSource Logger;
        public static PushupController GetPushupController(OCIChar Char) => Char == null ? null : StudioObjectExtensions.GetChaControl(Char).GetComponent<Pushup.PushupController>();
        private void Awake()
        {
            if (StudioAPI.InsideStudio)
            {
                StudioBustAdjuster.Logger = base.Logger;
            }
        }
        private void Start()
        {
            if (StudioAPI.InsideStudio)
            {
                this.RegisterStudioControls();
                StudioBustSizeTimeline.PopulateTimeline();
            }
        }
        private void RegisterStudioControls()
        {
            CurrentStateCategory BustStateCategories = StudioAPI.GetOrCreateCurrentStateCategory("Studio Bust Adjuster");
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Size", (OCIChar Char) => GetPushupController(Char).BaseData.Size, 0f, 1f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Size);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Position", (OCIChar Char) => GetPushupController(Char).BaseData.VerticalPosition, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Angle", (OCIChar Char) => GetPushupController(Char).BaseData.HorizontalAngle, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Position", (OCIChar Char) => GetPushupController(Char).BaseData.HorizontalPosition, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Angle", (OCIChar Char) => GetPushupController(Char).BaseData.VerticalAngle, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Pointiness", (OCIChar Char) => GetPushupController(Char).BaseData.Depth, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Pointiness);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Shape", (OCIChar Char) => GetPushupController(Char).BaseData.Roundness, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Shape);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Softness", (OCIChar Char) => GetPushupController(Char).BaseData.Softness, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Softness);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Weight", (OCIChar Char) => GetPushupController(Char).BaseData.Weight, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Weight);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Areola Bulge", (OCIChar Char) => GetPushupController(Char).BaseData.AreolaDepth, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.AreolaBulge);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Circumference", (OCIChar Char) => GetPushupController(Char).BaseData.NippleWidth, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.NipCircum);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Protrusion", (OCIChar Char) => GetPushupController(Char).BaseData.NippleDepth, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.NipProtrusion);
            });
        }
        internal static void UpdateBustAdjustmentProportions(float value, StudioBustAdjuster.Bust bust)
        {
            foreach (OCIChar ociChar in StudioAPI.GetSelectedCharacters())
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(ociChar, value, bust);
            }
        }
        internal static void UpdateBustAdjustmentProportions(OCIChar ociChar, float value, StudioBustAdjuster.Bust bust)
        {
            if (bust == StudioBustAdjuster.Bust.Size)
            {
                GetPushupController(ociChar).BaseData.Size = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertPos)
            {
                GetPushupController(ociChar).BaseData.VerticalPosition = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzAngle)
            {
                GetPushupController(ociChar).BaseData.HorizontalAngle = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzPos)
            {
                GetPushupController(ociChar).BaseData.HorizontalPosition = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertAngle)
            {
                GetPushupController(ociChar).BaseData.VerticalAngle = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Pointiness)
            {
                GetPushupController(ociChar).BaseData.Depth = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Shape)
            {
                GetPushupController(ociChar).BaseData.Roundness = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Softness)
            {
                GetPushupController(ociChar).BaseData.Softness = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Weight)
            {
                GetPushupController(ociChar).BaseData.Weight = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.AreolaBulge)
            {
                GetPushupController(ociChar).BaseData.AreolaDepth = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipCircum)
            {
                GetPushupController(ociChar).BaseData.NippleWidth = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipProtrusion)
            {
                GetPushupController(ociChar).BaseData.NippleDepth = value;
                GetPushupController(ociChar).RecalculateBody();
                return;
            }
        }
        internal enum Bust
        {
            Null,
            Size,
            VertPos,
            HorzAngle,
            HorzPos,
            VertAngle,
            Pointiness,
            Shape,
            Softness,
            Weight,
            AreolaBulge,
            NipCircum,
            NipProtrusion,
            AreolaSize,
        }
    }
}
