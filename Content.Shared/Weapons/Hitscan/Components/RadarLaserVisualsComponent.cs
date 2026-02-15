// Copyright (c) 2026 <Space Battle> <AndreyCamper>
// SPDX-License-Identifier: AGPL-3.0-or-later
namespace Content.Shared.Weapons.Hitscan.Components;

/// <summary>
/// Хранит данные о визуализации лазера для радара.
/// </summary>
[RegisterComponent]
public sealed partial class RadarLaserVisualsComponent : Component
{
    // Длина луча (в метрах)
    [ViewVariables(VVAccess.ReadWrite)]
    public float Length = 1f;

    // Угол полета луча
    [ViewVariables(VVAccess.ReadWrite)]
    public Angle Angle = Angle.Zero;

    // Тип отрисовки (0 = обычный, 1 = жирный шаттловый)
    [ViewVariables(VVAccess.ReadWrite)]
    public byte Type = 0;
}
