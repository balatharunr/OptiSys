using System;

namespace OptiSys.Core.Startup;

public sealed record StartupDelayPlan(
    string Id,
    StartupItemSourceKind SourceKind,
    string ReplacementTaskPath,
    int DelaySeconds,
    DateTimeOffset CreatedAtUtc);
