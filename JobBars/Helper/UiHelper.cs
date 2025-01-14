﻿using System;
using System.Numerics;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace JobBars.Helper {
    public static unsafe partial class UIHelper {
        public static unsafe Vector2 GetNodePosition(AtkResNode* node) {
            var pos = new Vector2(node->X, node->Y);
            var par = node->ParentNode;
            while (par != null) {
                pos *= new Vector2(par->ScaleX, par->ScaleY);
                pos += new Vector2(par->X, par->Y);
                par = par->ParentNode;
            }
            return pos;
        }

        public static unsafe Vector2 GetNodeScale(AtkResNode* node) {
            if (node == null) return new Vector2(1, 1);
            var scale = new Vector2(node->ScaleX, node->ScaleY);
            while (node->ParentNode != null) {
                node = node->ParentNode;
                scale *= new Vector2(node->ScaleX, node->ScaleY);
            }
            return scale;
        }

        public static void Hide(AtkResNode* node) {
            node->Flags &= ~0x10;
            node->Flags_2 |= 0x1;
        }

        public static void Show(AtkResNode* node) {
            node->Flags |= 0x10;
            node->Flags_2 |= 0x1;
        }

        public static void SetVisibility(AtkResNode* node, bool visiblity) {
            if (visiblity) Show(node);
            else Hide(node);
        }

        public static void Link(AtkResNode* next, AtkResNode* prev) {
            if (next == null || prev == null) return;
            next->PrevSiblingNode = prev;
            prev->NextSiblingNode = next;
        }

        public static void SetSize(AtkResNode* node, int? width, int? height) {
            if (width != null && width >= ushort.MinValue && width <= ushort.MaxValue) node->Width = (ushort)width.Value;
            if (height != null && height >= ushort.MinValue && height <= ushort.MaxValue) node->Height = (ushort)height.Value;
            node->Flags_2 |= 0x1;
        }

        public static void SetPosition(AtkResNode* node, float? x, float? y) {
            if (x != null) node->X = x.Value;
            if (y != null) node->Y = y.Value;
            node->Flags_2 |= 0x1;
        }

        public static void SetScale(AtkResNode* atkUnitBase, float? scaleX, float? scaleY) {
            atkUnitBase->ScaleX = scaleX.Value;
            atkUnitBase->ScaleY = scaleY.Value;
            atkUnitBase->Flags_2 |= 0x1;
            atkUnitBase->Flags_2 |= 0x4;
        }
    }
}
