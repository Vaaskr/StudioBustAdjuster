using ExtensibleSaveFormat;
using KKABMX.Core;
using KKAPI;
using KKAPI.Chara;
using KKAPI.Studio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace KK_StudioBustAdjuster
{
    internal class StudioBustAdjsuterController : CharaCustomFunctionController
    {
        public float BustSize
        {
            get
            {
                return ChaControl.GetShapeBodyValue(4);
            }
            set
            {
                ChaControl.SetShapeBodyValue(4, value);
            }
        }
        public float BustVertPos
        {
            get
            {
                return ChaControl.GetShapeBodyValue(5);
            }
            set
            {
                ChaControl.SetShapeBodyValue(5, value);
            }
        }
        public float BustHorzAngle
        {
            get
            {
                return ChaControl.GetShapeBodyValue(6);
            }
            set
            {
                ChaControl.SetShapeBodyValue(6, value);
            }
        }
        public float BustHorzPos
        {
            get
            {
                return ChaControl.GetShapeBodyValue(7);
            }
            set
            {
                ChaControl.SetShapeBodyValue(7, value);
            }
        }
        public float BustVertAngle
        {
            get
            {
                return ChaControl.GetShapeBodyValue(8);
            }
            set
            {
                ChaControl.SetShapeBodyValue(8, value);
            }
        }
        public float BustPointness
        {
            get
            {
                return ChaControl.GetShapeBodyValue(9);
            }
            set
            {
                ChaControl.SetShapeBodyValue(9, value);
            }
        }
        public float BustShape
        {
            get
            {
                return ChaControl.GetShapeBodyValue(10);
            }
            set
            {
                ChaControl.SetShapeBodyValue(10, value);
            }
        }
        public float AreolaBulge
        {
            get
            {
                return ChaControl.GetShapeBodyValue(11);
            }
            set
            {
                ChaControl.SetShapeBodyValue(11, value);
            }
        }
        public float NipCircumfrence
        {
            get
            {
                return ChaControl.GetShapeBodyValue(12);
            }
            set
            {
                ChaControl.SetShapeBodyValue(12, value);
            }
        }
        public float NipProtrusion
        {
            get
            {
                return ChaControl.GetShapeBodyValue(13);
            }
            set
            {
                ChaControl.SetShapeBodyValue(13, value);
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
    }
}
