﻿using Bookify.Domain.Abstractions;
using Bookify.Domain.Apartments.ValueObjects;
using Bookify.Domain.Shared;
#pragma warning disable CS8618

namespace Bookify.Domain.Apartments;

public sealed class Apartment : Entity<ApartmentId>
{
    public Apartment(
        ApartmentId id,
        Name name,
        Description description,
        Address address,
        Money price,
        Money cleaningFee,
        List<Amenity> amenities)
        : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        Amenities = amenities;
    }

    // an empty ctor fro EF
    private Apartment()
    {
    }

    public Name Name { get; private set; }

    public Description Description { get; private set; }

    public Address Address { get; private set; }

    public Money Price { get; private set; }

    public Money CleaningFee { get; private set; }

    public DateTime? LastBookedOnUtc { get; internal set; }

    public List<Amenity> Amenities { get; private set; } = new();
}
