using MudBlazor;

namespace SimRacingManager.Miscellaneous;

public static class TrackHelper
{
    public static (string, Color) TrackRemainingTimeAndColour(DateTime date)
    {
        var daysRemaining = date - DateTime.Now;
        
        string? localRemainingValue = null;
        var localRemainingColour = Color.Default;
        
        if (daysRemaining.Days > 1)
        {
            localRemainingColour = Color.Primary;
            localRemainingValue = daysRemaining.Days + " Days";
        }
        else if (daysRemaining.Days < 1 && daysRemaining.Hours > 1)
        {
            localRemainingColour = Color.Success;
            localRemainingValue = daysRemaining.Hours + " Hours";
        }
        else if (daysRemaining.Hours < 1 && daysRemaining.Minutes > 1)
        {
            localRemainingColour = Color.Warning;
            localRemainingValue = daysRemaining.Minutes + " Minutes";
        }
        else if (daysRemaining.Minutes < 1 && daysRemaining.Seconds > 1)
        {
            localRemainingColour = Color.Error;
            localRemainingValue = daysRemaining.Seconds + " Seconds";
        }

        return (localRemainingValue, localRemainingColour);
    }
}