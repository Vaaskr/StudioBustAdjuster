using KKABMX.Core;
using KKAPI.Studio;
using KKAPI.Utilities;
using Studio;
using System;
using System.Xml;
using UnityEngine;

namespace KK_StudioBustAdjuster
{
    internal static class StudioBustSizeTimeline
    {
        internal static void PopulateTimeline()
        {
            if (!TimelineCompatibility.IsTimelineAvailable())
                return;
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustSize", "Bust Size", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Size);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(4), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustVertPos", "Vertical Position", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.VertPos);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(5), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustHorzAngle", "Horizontal Angle", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.HorzAngle);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(6), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustHorzPos", "Horizontal Position", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.HorzPos);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(7), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustVertAngle", "Vertical Angle", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.VertAngle);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(8), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustPointiness", "Pointiness", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Pointiness);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(9), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustShape", "Shape", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.Shape);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(10), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustAreolaBulge", "Areola Bulge", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.AreolaBulge);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(11), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustNipCircum", "Nipple Circumference", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.NipCircum);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(12), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<float, ObjectCtrlInfo>("BustAdjustment", "bustNipProtrusion", "Nipple Protrusion", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, float leftValue, float rightValue, float factor)
            {
                StudioBustAdjuster.UpdateBustAdjustmentProportions((OCIChar)oci, Mathf.LerpUnclamped(leftValue, rightValue, factor), StudioBustAdjuster.Bust.NipProtrusion);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetShapeBodyValue(13), (ObjectCtrlInfo parameter, XmlNode node) => XmlConvert.ToSingle(node.Attributes["value"].Value), delegate (ObjectCtrlInfo parameter, XmlTextWriter writer, float value)
            {
                writer.WriteAttributeString("value", value.ToString());
            }, (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);           
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale1L", "Bust L. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust01_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust01_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale1R", "Bust R. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust01_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust01_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale2L", "Bust L. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale2R", "Bust R. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale3L", "Bust L. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust03_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust03_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustScale3R", "Bust R. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust03_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_d_bust03_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale1L", "Extra Bust L. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust00_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust00_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale1R", "Extra Bust R. Scale 1", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust00_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust00_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale2L", "Extra Bust L. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust01_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust01_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale2R", "Extra Bust R. Scale 2", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust01_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust01_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale3L", "Extra Bust L. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale3R", "Extra Bust R. Scale 3", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale4L", "Extra Bust L. Scale 4", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust03_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust03_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "xtraBustScale4R", "Extra Bust R. Scale 4", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust03_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_s_bust03_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustColL", "Bust L. Collision", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_hit_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);
                
            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_hit_bust02_L", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
            TimelineCompatibility.AddInterpolableModelDynamic<Vector3, ObjectCtrlInfo>("BustAdjustment", "bustColR", "Bust R. Collision", delegate (ObjectCtrlInfo oci, ObjectCtrlInfo parameter, Vector3 leftValue, Vector3 rightValue, float factor)
            {
                StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_hit_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier = Vector3.LerpUnclamped(leftValue, rightValue, factor);

            }, null, (ObjectCtrlInfo oci) => oci is OCIChar, (ObjectCtrlInfo oci, ObjectCtrlInfo parameter) => StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().GetOrAddModifier("cf_hit_bust02_R", BoneLocation.BodyTop).GetModifier(StudioObjectExtensions.GetChaControl((OCIChar)oci).GetComponent<BoneController>().CurrentCoordinate.Value).ScaleModifier, new Func<ObjectCtrlInfo, XmlNode, Vector3>(StudioBustSizeTimeline.ReadVector3XML), new Action<ObjectCtrlInfo, XmlTextWriter, Vector3>(StudioBustSizeTimeline.WriteVector3XML), (ObjectCtrlInfo oci) => oci, null, null, null, true, null, null);
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
