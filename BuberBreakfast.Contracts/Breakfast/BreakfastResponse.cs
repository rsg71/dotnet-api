using System;
using System.Collections.Generic;
namespace BuberBreakast.Contracts.Breakfast;

public record CreateBreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);
