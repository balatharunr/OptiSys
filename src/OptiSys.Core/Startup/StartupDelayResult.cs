namespace OptiSys.Core.Startup;

public sealed record StartupDelayResult(bool Succeeded, string? ReplacementTaskPath, string? ErrorMessage);
