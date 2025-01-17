﻿// Copyright (c) Microsoft Corporation and Contributors
// Licensed under the MIT license.

using System;
using System.Diagnostics.Tracing;
using DevHome.Common.Helpers;
using DevHome.Telemetry;
using Microsoft.Diagnostics.Telemetry;
using Microsoft.Diagnostics.Telemetry.Internal;

namespace DevHome.Dashboard.TelemetryEvents;

[EventData]
public class ReportInstalledExtensionEvent : EventBase
{
    public override PartA_PrivTags PartA_PrivTags => PrivTags.ProductAndServiceUsage;

    public Guid DeploymentIdentifier
    {
        get;
    }

    public string ExtensionUniqueId
    {
        get;
    }

    public bool IsExtensionEnabled
    {
        get;
    }

    public ReportInstalledExtensionEvent(string? extensionUniqueId, bool isEnabled)
    {
        DeploymentIdentifier = Deployment.Identifier;
        ExtensionUniqueId = !string.IsNullOrEmpty(extensionUniqueId) ? extensionUniqueId : string.Empty;
        IsExtensionEnabled = isEnabled;
    }

    public override void ReplaceSensitiveStrings(Func<string, string> replaceSensitiveStrings)
    {
        // No sensitive strings to replace.
    }
}
