using ExtensibleSaveFormat;
using Illusion.Component.Correct;
using KK_Plugins;
using KKABMX.Core;
using KKAPI;
using KKAPI.Chara;
using KKAPI.Studio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static Illusion.Utils;
using static KK_Plugins.Pushup;

namespace KK_StudioBustAdjuster
{
    internal class StudioBustAdjusterController : CharaCustomFunctionController
    {

        public float BustSize
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.Size;
            }
            set
            {;
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.Size = value;
            }
        }
        public float BustVertPos
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalPosition;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalPosition = value;
            }
        }
        public float BustHorzAngle
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalAngle;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalAngle = value;
            }
        }
        public float BustHorzPos
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalPosition;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.HorizontalPosition = value;       
            }
        }
        public float BustVertAngle
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalAngle;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.VerticalAngle = value;
            }
        }
        public float BustPointness
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.Depth;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.Depth = value;
            }
        }
        public float BustShape
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.Roundness;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.Roundness = value;
            }
        }
        public float BustSoftness
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.Softness;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.Softness = value;
            }
        }
        public float BustWeight
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.Weight;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.Weight = value;
            }
        }
        public float AreolaBulge
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.AreolaDepth;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.AreolaDepth = value;
            }
        }
        public float NipCircumfrence
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.NippleWidth;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.NippleWidth = value;
            }
        }
        public float NipProtrusion
        {
            get
            {
                return ChaControl.GetComponent<Pushup.PushupController>().BaseData.NippleDepth;
            }
            set
            {
                ChaControl.GetComponent<Pushup.PushupController>().BaseData.NippleDepth = value;
            }
        }
        protected override void OnCardBeingSaved(GameMode currentGameMode)
        {
            PluginData pluginData = new PluginData();
            pluginData.data["BustSize"] = this.BustSize;
            pluginData.data["BustVerticalPosition"] = this.BustVertPos;
            pluginData.data["BustHorizontalAngle"] = this.BustHorzAngle;
            pluginData.data["BustHorizontalPosition"] = this.BustHorzPos;
            pluginData.data["BustVerticalAngle"] = this.BustVertAngle;
            pluginData.data["BustPointness"] = this.BustPointness;
            pluginData.data["BustShape"] = this.BustShape;
            pluginData.data["AreolaBulge"] = this.AreolaBulge;
            pluginData.data["NippleCircumfrence"] = this.NipCircumfrence;
            pluginData.data["NippleProtrusion"] = this.NipProtrusion;
            base.SetExtendedData(pluginData);
        }
        protected override void OnReload(GameMode currentGameMode)
        {
            PluginData extendedData = base.GetExtendedData();
            if (extendedData != null)
            {
                object obj;
                if (extendedData.data.TryGetValue("BustSize", out obj))
                {
                    this.BustSize = (float)obj;
                }
                object obj2;
                if (extendedData.data.TryGetValue("BustVerticalPosition", out obj2))
                {
                    this.BustVertPos = (float)obj2;
                }
                object obj3;
                if (extendedData.data.TryGetValue("BustHorizontalAngle", out obj3))
                {
                    this.BustHorzAngle = (float)obj3;
                }
                object obj4;
                if (extendedData.data.TryGetValue("BustHorizontalPosition", out obj4))
                {
                    this.BustHorzPos = (float)obj4;
                }
                object obj5;
                if (extendedData.data.TryGetValue("BustVerticalAngle", out obj5))
                {
                    this.BustVertAngle = (float)obj5;
                }
                object obj6;
                if (extendedData.data.TryGetValue("BustPointness", out obj6))
                {
                    this.BustPointness = (float)obj6;
                }
                object obj7;
                if (extendedData.data.TryGetValue("BustShape", out obj7))
                {
                    this.BustShape = (float)obj7;
                }
                object obj8;
                if (extendedData.data.TryGetValue("AreolaBulge", out obj8))
                {
                    this.AreolaBulge = (float)obj8;
                }
                object obj9;
                if (extendedData.data.TryGetValue("NippleCircumfrence", out obj9))
                {
                    this.NipCircumfrence = (float)obj9;
                }
                object obj10;
                if (extendedData.data.TryGetValue("NippleProtrusion", out obj10))
                {
                    this.NipProtrusion = (float)obj10;
                }
            }
        }
        public void setPushupBodyData()
        {
            Wearing nowWearing = PushupCurrentlyWearing;
            if (nowWearing == Wearing.None)
            {
                RemapPushUpDataToChaFile(ChaControl.GetComponent<Pushup.PushupController>().BaseData);
            }
            else
            {
                RecalculatePush(nowWearing);
                RemapPushUpDataToChaFile(ChaControl.GetComponent<Pushup.PushupController>().CurrentPushupData);
            }
        }
        internal void RemapPushUpDataToChaFile(BodyData bodyData)
        {
            void setShapeValue(int idx, float val)
            {
                ChaControl.fileBody.shapeValueBody[idx] = val;
                ChaControl.SetShapeBodyValue(idx, val);
            }

            ChaControl.ChangeBustSoftness(bodyData.Softness);
            ChaControl.ChangeBustGravity(bodyData.Weight);

            setShapeValue(4, bodyData.Size);
            setShapeValue(5, bodyData.VerticalPosition);
            setShapeValue(6, bodyData.HorizontalAngle);
            setShapeValue(7, bodyData.HorizontalPosition);
            setShapeValue(8, bodyData.VerticalAngle);
            setShapeValue(9, bodyData.Depth);
            setShapeValue(10, bodyData.Roundness);
            setShapeValue(11, bodyData.AreolaDepth);
            setShapeValue(12, bodyData.NippleWidth);
            setShapeValue(13, bodyData.NippleDepth);
        }
        internal void RecalculatePush(Wearing wearing)
        {
            PushupController pushupController = ChaControl.GetComponent<Pushup.PushupController>();
            if (wearing == Wearing.Bra)
            {
                RecalculatePushFromClothes(pushupController.CurrentBraData, pushupController.CurrentBraData.UseAdvanced);
                return;
            }
            if (wearing == Wearing.Top)
            {
                RecalculatePushFromClothes(pushupController.CurrentTopData, pushupController.CurrentTopData.UseAdvanced);
                return;
            }
            if (pushupController.CurrentTopData.UseAdvanced)
            {
                RecalculatePushFromClothes(pushupController.CurrentTopData, true);
                return;
            }
            if (pushupController.CurrentBraData.UseAdvanced)
            {
                RecalculatePushFromClothes(pushupController.CurrentBraData, true);
                return;
            }

            var combo = new ClothData();
            combo.Firmness = System.Math.Max(pushupController.CurrentBraData.Firmness, pushupController.CurrentTopData.Firmness);
            combo.Lift = System.Math.Max(pushupController.CurrentBraData.Lift, pushupController.CurrentTopData.Lift);
            combo.Squeeze = System.Math.Max(pushupController.CurrentBraData.Squeeze, pushupController.CurrentTopData.Squeeze);
            combo.PushTogether = System.Math.Max(pushupController.CurrentBraData.PushTogether, pushupController.CurrentTopData.PushTogether);
            combo.CenterNipples = System.Math.Max(pushupController.CurrentBraData.CenterNipples, pushupController.CurrentTopData.CenterNipples);
            combo.FlattenNipples = pushupController.CurrentBraData.FlattenNipples || pushupController.CurrentTopData.FlattenNipples;
            combo.EnablePushup = true;

            RecalculatePushFromClothes(combo, false);
        }

        internal void RecalculatePushFromClothes(ClothData cData, bool useAdvanced)
        {
            PushupController pushupController = ChaControl.GetComponent<Pushup.PushupController>();
            if (useAdvanced)
            {
                cData.CopyTo(pushupController.CurrentPushupData);
                return;
            }

            if (1f - cData.Firmness < pushupController.BaseData.Softness)
            {
                pushupController.CurrentPushupData.Softness = 1 - cData.Firmness;
            }
            else
            {
                pushupController.CurrentPushupData.Softness = pushupController.BaseData.Softness;
            }

            if (cData.Lift > pushupController.BaseData.VerticalPosition)
            {
                pushupController.CurrentPushupData.VerticalPosition = cData.Lift;
            }
            else
            {
                pushupController.CurrentPushupData.VerticalPosition = pushupController.BaseData.VerticalPosition;
            }

            if (1f - cData.PushTogether < pushupController.BaseData.HorizontalAngle)
            {
                pushupController.CurrentPushupData.HorizontalAngle = 1 - cData.PushTogether;
            }
            else
            {
                pushupController.CurrentPushupData.HorizontalAngle = pushupController.BaseData.HorizontalAngle;
            }

            if (1f - cData.PushTogether < pushupController.BaseData.HorizontalPosition)
            {
                pushupController.CurrentPushupData.HorizontalPosition = 1 - cData.PushTogether;
            }
            else
            {
                pushupController.CurrentPushupData.HorizontalPosition = pushupController.BaseData.HorizontalPosition;
            }

            if (1f - cData.Squeeze < pushupController.BaseData.Depth)
            {
                pushupController.CurrentPushupData.Depth = 1 - cData.Squeeze;
                pushupController.CurrentPushupData.Size = pushupController.BaseData.Size + (pushupController.BaseData.Depth - (1 - cData.Squeeze)) / 10;
            }
            else
            {
                pushupController.CurrentPushupData.Depth = pushupController.BaseData.Depth;
                pushupController.CurrentPushupData.Size = pushupController.BaseData.Size;
            }

            if (cData.FlattenNipples)
            {
                pushupController.CurrentPushupData.NippleDepth = 0f;
                pushupController.CurrentPushupData.AreolaDepth = 0f;
            }
            else
            {
                pushupController.CurrentPushupData.NippleDepth = pushupController.BaseData.NippleDepth;
                pushupController.CurrentPushupData.AreolaDepth = pushupController.BaseData.AreolaDepth;
            }

            pushupController.CurrentPushupData.NippleWidth = pushupController.BaseData.NippleWidth;

            var nipDeviation = 0.5f - pushupController.BaseData.VerticalAngle;
            pushupController.CurrentPushupData.VerticalAngle = 0.5f - (nipDeviation - (nipDeviation * cData.CenterNipples));

            pushupController.CurrentPushupData.Weight = pushupController.BaseData.Weight;
            pushupController.CurrentPushupData.Roundness = pushupController.BaseData.Roundness;
        }
        private Wearing PushupCurrentlyWearing
        {
            get
            {
                var braIsOnAndEnabled = PushupEnabledAndBraOn;
                var topIsOnAndEnabled = PushupEnabledAndTopOn;

                if (topIsOnAndEnabled)
                    return braIsOnAndEnabled ? Wearing.Both : Wearing.Top;

                return braIsOnAndEnabled ? Wearing.Bra : Wearing.None;
            }
        }
        public bool PushupEnabledAndBraOn => ChaControl.IsClothesStateKind((int)ChaFileDefine.ClothesKind.bra) &&
                                              ChaControl.fileStatus.clothesState[(int)ChaFileDefine.ClothesKind.bra] == 0 &&
                                              ChaControl.GetComponent<Pushup.PushupController>().CurrentBraData.EnablePushup;
        public bool PushupEnabledAndTopOn => ChaControl.IsClothesStateKind((int)ChaFileDefine.ClothesKind.top) &&
                                              ChaControl.fileStatus.clothesState[(int)ChaFileDefine.ClothesKind.top] == 0 &&
                                              ChaControl.GetComponent<Pushup.PushupController>().CurrentTopData.EnablePushup;
        internal enum Wearing { None, Bra, Top, Both }
    }
}
