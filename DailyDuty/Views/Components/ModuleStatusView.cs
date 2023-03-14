﻿using DailyDuty.Abstracts;
using DailyDuty.Models.Attributes;
using Dalamud.Interface;
using ImGuiNET;

namespace DailyDuty.Views.Components;

public static class ModuleStatusView
{
    public static void Draw(BaseModule module)
    {
        ImGui.Text("Module Status");
        ImGui.Separator();
        ImGuiHelpers.ScaledIndent(15.0f);

        if (ImGui.BeginTable("##StatusTable", 2, ImGuiTableFlags.SizingStretchSame))
        {
            ImGui.TableNextColumn();
            ImGui.Text("Current Status");

            ImGui.TableNextColumn();
            ImGui.TextColored(module.ModuleStatus.GetColor(), module.ModuleStatus.GetLabel());
            
            ImGui.EndTable();
        }
        
        ImGuiHelpers.ScaledDummy(10.0f);
        ImGuiHelpers.ScaledIndent(-15.0f);
    }
}