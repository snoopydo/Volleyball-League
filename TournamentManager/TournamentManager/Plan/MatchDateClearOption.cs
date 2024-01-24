namespace TournamentManager.Plan;

/// <summary>
/// Specifies the options for clearing match dates.
/// </summary>
[Flags]
public enum MatchDateClearOption
{
    /// <summary>
    /// No match dates are cleared.
    /// </summary>
    None = 0,
    /// <summary>
    /// Only auto-generated match dates are cleared.
    /// </summary>
    OnlyAutoGenerated = 1,
    /// <summary>
    /// Only manually added match dates are cleared.
    /// </summary>
    OnlyManual = 2,
    /// <summary>
    /// All match dates are cleared.
    /// </summary>
    All = 3
}
