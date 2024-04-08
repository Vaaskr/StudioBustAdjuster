using KKABMX.Core;
using KKAPI.Studio;
using KKAPI.Utilities;
using Studio;
using System;
using System.Xml;
using UnityEngine;

namespace StudioBustAdjuster
{
    internal static class StudioBustAdjusterTimeline
    {
        internal static void PopulateTimeline()
        {
            BoneController GetBoneController(OCIChar oci) => oci == null ? null : StudioObjectExtensions.GetChaControl(oci).GetComponent<BoneController>();
            BoneModifierData GetBoneScale(OCIChar oci, string bone) => oci == null ? null : GetBoneController(oci).GetOrAddModifier(bone, BoneLocation.BodyTop).GetModifier(GetBoneController(oci).CurrentCoordinate.Value);
            if (!TimelineCompatibility.IsTimelineAvailable())
                return;
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustSize", "Bust Size", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Size);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.Size, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustVertPos", "Vertical Position", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.VertPos);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.VerticalPosition, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustHorzAngle", "Horizontal Angle", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.HorzAngle);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.HorizontalAngle, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustHorzPos", "Horizontal Position", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.HorzPos);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.HorizontalPosition, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustVertAngle", "Vertical Angle", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.VertAngle);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.VerticalAngle, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustPointiness", "Pointiness", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Pointiness);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.Depth, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustShape", "Shape", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Shape);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.Roundness, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustSoftness", "Softness", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Softness);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.Softness, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustWeight", "Weight", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Weight);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.Weight, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustAreolaBulge", "Areola Bulge", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.AreolaBulge);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.AreolaDepth, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustNipCircum", "Nipple Circumference", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.NipCircum);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.NippleWidth, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustNipProtrusion", "Nipple Protrusion", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.NipProtrusion);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioBustAdjuster.GetPushupController((OCIChar)oci).BaseData.NippleDepth, (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale1L", "Bust L. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust01_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust01_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale1R", "Bust R. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust01_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust01_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale2L", "Bust L. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust02_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust02_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale2R", "Bust R. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust02_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust02_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale3L", "Bust L. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust03_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust03_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale3R", "Bust R. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bust03_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bust03_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale1L", "Extra Bust L. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust00_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust00_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale1R", "Extra Bust R. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust00_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust00_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale2L", "Extra Bust L. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust01_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust01_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale2R", "Extra Bust R. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust01_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust01_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale3L", "Extra Bust L. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust02_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust02_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale3R", "Extra Bust R. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust02_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust02_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale4L", "Extra Bust L. Scale 4", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust03_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust03_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale4R", "Extra Bust R. Scale 4", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bust03_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bust03_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustColL", "Bust L. Collision", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_hit_bust02_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_hit_bust02_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustColR", "Bust R. Collision", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_hit_bust02_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_hit_bust02_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "areolaScale1L", "Areola L. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip01_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip01_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "areolaScale1R", "Areola R. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip01_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip01_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "areolaScale2L", "Areola L. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip025_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip025_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "areolaScale2R", "Areola R. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip025_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip025_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipScaleL", "Nipple L. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bnip01_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bnip01_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipScaleR", "Nipple R. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_d_bnip01_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_d_bnip01_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipTipScaleL", "Nipple Tip L. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip02_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip02_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipTipScaleR", "Nipple Tip R. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnip02_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnip02_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipAccScaleL", "Nipple Accessory L. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnipacc_L").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnipacc_L").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "nipAccScaleR", "Nipple Accessory R. Scale", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                GetBoneScale((OCIChar)oci, "cf_s_bnipacc_R").ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => GetBoneScale((OCIChar)oci, "cf_s_bnipacc_R").ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustAdjusterTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustAdjusterTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
        }
        private static void WriteVector3XML(ObjectCtrlInfo oci, XmlTextWriter writer, Vector3 value)
        {
            writer.WriteAttributeString("X", XmlConvert.ToString(value.x));
            writer.WriteAttributeString("Y", XmlConvert.ToString(value.y));
            writer.WriteAttributeString("Z", XmlConvert.ToString(value.z));
        }
        private static Vector3 ReadVector3XML(ObjectCtrlInfo oci, XmlNode node)
        {
            return new Vector3(XmlConvert.ToSingle(node.Attributes["X"].Value), XmlConvert.ToSingle(node.Attributes["Y"].Value), XmlConvert.ToSingle(node.Attributes["Z"].Value));
        }
    }
}
