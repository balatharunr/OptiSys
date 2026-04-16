namespace OptiSys.App.Services;

public interface IHighFrictionPromptService
{
    void TryShowPrompt(HighFrictionScenario scenario, ActivityLogEntry entry);
}
