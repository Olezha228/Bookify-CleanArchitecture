﻿using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Bookify.Domain.Reviews;
using Bookify.Domain.Reviews.ValueObjects;
using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastucture.Configurations;

internal sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("reviews");

        builder.HasKey(review => review.Id);

        builder.Property(review => review.Id)
            .HasConversion(reviewId => reviewId.Value, value => new ReviewId(value));

        builder.Property(review => review.Id)
            .HasConversion(reviewId => reviewId.Value, value => new ReviewId(value));

        builder.Property(review => review.Rating)
            .HasConversion(rating => rating.Value, value => Rating.Create(value).Value);

        builder.Property(review => review.Comment)
            .HasMaxLength(200)
            .HasConversion(comment => comment.Value, value => new Comment(value));

        builder.HasOne<Apartment>()
            .WithMany()
            .HasForeignKey(review => review.ApartmentId);

        builder.HasOne<Booking>()
            .WithMany()
            .HasForeignKey(review => review.BookingId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(review => review.UserId);
    }
}
