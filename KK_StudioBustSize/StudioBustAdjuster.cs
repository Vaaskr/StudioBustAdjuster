using BepInEx;
using BepInEx.Logging;
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
                CharacterApi.RegisterExtraBehaviour<StudioBustAdjsuterController>(GUID);
            }
        }
        private void RegisterStudioControls()
        {
            CurrentStateCategory BustStateCategories = StudioAPI.GetOrCreateCurrentStateCategory("Studio Bust Adjuster");
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Size", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(4), 0f, 1f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Size);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Position", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(5), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Angle", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(6), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Position", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(7), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Angle", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(8), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Pointiness", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(9), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Pointiness);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Shape", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(10), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Shape);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Areola Bulge", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(11), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.AreolaBulge);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Circumference", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(12), -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.NipCircum);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Protrusion", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetShapeBodyValue(13), -1f, 2f)).Value, delegate (float f)
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
            ChaControl chaControl = StudioObjectExtensions.GetChaControl(ociChar);
            StudioBustAdjsuterController bustController = chaControl.GetComponent<StudioBustAdjsuterController>();
            if (bust == StudioBustAdjuster.Bust.Size)
            {
                bustController.BustSize = value;
                chaControl.SetShapeBodyValue(4, bustController.BustSize);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.Size = bustController.BustSize;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertPos)
            {
                bustController.BustVertPos = value;
                chaControl.SetShapeBodyValue(5, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalPosition = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzAngle)
            {
                bustController.BustHorzAngle = value;
                chaControl.SetShapeBodyValue(6, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalAngle = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzPos)
            {
                bustController.BustHorzPos = value;
                chaControl.SetShapeBodyValue(7, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalPosition = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertAngle)
            {
                bustController.BustVertAngle = value;
                chaControl.SetShapeBodyValue(8, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalAngle = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Pointiness)
            {
                bustController.BustPointness= value;
                chaControl.SetShapeBodyValue(9, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.Depth = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Shape)
            {
                bustController.BustShape = value;
                chaControl.SetShapeBodyValue(10, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.Roundness = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.AreolaBulge)
            {
                bustController.AreolaBulge = value;
                chaControl.SetShapeBodyValue(11, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.AreolaDepth = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipCircum)
            {
                bustController.NipCircumfrence = value;
                chaControl.SetShapeBodyValue(12, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.NippleWidth = value;
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipProtrusion)
            {
                bustController.NipProtrusion = value;
                chaControl.SetShapeBodyValue(13, value);
                chaControl.GetComponent<Pushup.PushupController>().BaseData.NippleDepth = value;
                return;
            }
        }
        internal enum Bust
        {
            Size,
            VertPos,
            HorzAngle,
            HorzPos,
            VertAngle,
            Pointiness,
            Shape,
            AreolaBulge,
            NipCircum,
            NipProtrusion,
            AreolaSize,
        }
        internal enum ExtraBust
        {
            Scale1,
            Scale2,
            Scale3,
            XtraScale0,
            XtraScale1,
            XtraScale2,
            XtraScale3,
            BustColZ,
        }
      
        public static Vector3 _LRbustscale1;
        public static Vector3 _LRbustscale2;
        public static Vector3 _LRbustscale3;
        public static Vector3 _LRxtrabustscale0;
        public static Vector3 _LRxtrabustscale1;
        public static Vector3 _LRxtrabustscale2;
        public static Vector3 _LRxtrabustscale3;
        public static Vector3 _LRbustcollidescale;
    }
}
