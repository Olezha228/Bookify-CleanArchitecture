﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews.ValueObjects;

public sealed record Rating
{
    public static readonly DomainError Invalid = new("Rating.Invalid", "The rating is invalid");

    private Rating(int value) => Value = value;

    public int Value { get; init; }

    public static Result<Rating> Create(int value)
    {
        if (value is < 1 or > 5)
        {
            return Result.Failure<Rating>(Invalid);
        }

        return new Rating(value);
    }
}