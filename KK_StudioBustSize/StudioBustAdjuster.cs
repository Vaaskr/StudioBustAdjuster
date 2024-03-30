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
                CharacterApi.RegisterExtraBehaviour<StudioBustAdjusterController>(GUID);
            }
        }
        private void RegisterStudioControls()
        {
            CurrentStateCategory BustStateCategories = StudioAPI.GetOrCreateCurrentStateCategory("Studio Bust Adjuster");
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Size", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustSize, 0f, 1f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Size);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Position", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustVertPos, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Angle", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustHorzAngle, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Horizontal Position", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustHorzPos, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.HorzPos);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Vertical Angle", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustVertAngle, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.VertAngle);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Pointiness", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustPointness, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Pointiness);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Shape", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustShape, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Shape);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Softness", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustSoftness, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Softness);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Weight", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().BustWeight, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.Weight);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Areola Bulge", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().AreolaBulge, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.AreolaBulge);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Circumference", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().NipCircumfrence, -1f, 2f)).Value, delegate (float f)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions(f, StudioBustAdjuster.Bust.NipCircum);
            });
            ObservableExtensions.Subscribe<float>(BustStateCategories.AddControl<CurrentStateCategorySlider>(new CurrentStateCategorySlider("   Nipple Protrusion", (OCIChar Char) => StudioObjectExtensions.GetChaControl(Char).GetComponent<StudioBustAdjusterController>().NipProtrusion, -1f, 2f)).Value, delegate (float f)
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
            StudioBustAdjusterController bustController = chaControl.GetComponent<StudioBustAdjusterController>();

            if (bust == StudioBustAdjuster.Bust.Size)
            {
                bustController.BustSize = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertPos)
            {
                bustController.BustVertPos = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzAngle)
            {
                bustController.BustHorzAngle = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.HorzPos)
            {
                bustController.BustHorzPos = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.VertAngle)
            {
                bustController.BustVertAngle = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Pointiness)
            {
                bustController.BustPointness= value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Shape)
            {
                bustController.BustShape = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Softness)
            {
                bustController.BustSoftness = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.Weight)
            {
                bustController.BustWeight = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.AreolaBulge)
            {
                bustController.AreolaBulge = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipCircum)
            {
                bustController.NipCircumfrence = value;
                bustController.setPushupBodyData();
                return;
            }
            if (bust == StudioBustAdjuster.Bust.NipProtrusion)
            {
                bustController.NipProtrusion = value;
                bustController.setPushupBodyData();
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
