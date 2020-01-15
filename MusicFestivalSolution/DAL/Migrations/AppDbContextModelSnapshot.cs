﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Domain.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipmentHourlyPrice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EquipmentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LenderPersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EquipmentId");

                    b.HasIndex("LenderPersonId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Domain.EventSet", b =>
                {
                    b.Property<int>("EventSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EventSetId");

                    b.HasIndex("EventId");

                    b.HasIndex("PersonId");

                    b.ToTable("EventSets");
                });

            modelBuilder.Entity("Domain.Festival", b =>
                {
                    b.Property<int>("FestivalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FestivalName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FestivalId");

                    b.ToTable("Festivals");
                });

            modelBuilder.Entity("Domain.FestivalEvent", b =>
                {
                    b.Property<int>("FestivalEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FestivalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrganisedEventId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FestivalEventId");

                    b.HasIndex("FestivalId");

                    b.HasIndex("OrganisedEventId");

                    b.ToTable("FestivalEvents");
                });

            modelBuilder.Entity("Domain.OrganisedEvent", b =>
                {
                    b.Property<int>("OrganisedEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CleanUpTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PreparationTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TicketCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VenueId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrganisedEventId");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Domain.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganisedEventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParticipantTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParticipateBeginDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParticipateBeginTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParticipateEndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParticipateEndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParticipantId");

                    b.HasIndex("OrganisedEventId");

                    b.HasIndex("ParticipantTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Domain.ParticipantType", b =>
                {
                    b.Property<int>("ParticipantTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FixedSum")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GetsFixedSum")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GetsHourly")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HourlyWage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParticipantTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ParticipantTypeId");

                    b.ToTable("ParticipantTypes");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("StageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("VatSubjectNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Domain.SetTrack", b =>
                {
                    b.Property<int>("SetTrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActualPlayTimeInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventSetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlannedPlayTimeInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QueueNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SetTrackId");

                    b.HasIndex("EventSetId");

                    b.HasIndex("TrackId");

                    b.ToTable("SetTracks");
                });

            modelBuilder.Entity("Domain.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LengthInSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TrackId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Domain.TrackAuthor", b =>
                {
                    b.Property<int>("TrackAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackAuthorTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TrackAuthorId");

                    b.HasIndex("PersonId");

                    b.HasIndex("TrackAuthorTypeId");

                    b.HasIndex("TrackId");

                    b.ToTable("TrackAuthors");
                });

            modelBuilder.Entity("Domain.TrackAuthorType", b =>
                {
                    b.Property<int>("TrackAuthorTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TrackAuthorTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TrackAuthorTypeId");

                    b.ToTable("TrackAuthorTypes");
                });

            modelBuilder.Entity("Domain.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HourlyPrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SimplePrice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VenueAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VenueId");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("Domain.VenueEquipment", b =>
                {
                    b.Property<int>("VenueEquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArrivalAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArrivalTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrganisedEventId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReturnAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReturnTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VenueEquipmentId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("OrganisedEventId");

                    b.ToTable("VenueEquipments");
                });

            modelBuilder.Entity("Domain.Equipment", b =>
                {
                    b.HasOne("Domain.Person", "Lender")
                        .WithMany()
                        .HasForeignKey("LenderPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.EventSet", b =>
                {
                    b.HasOne("Domain.OrganisedEvent", "Event")
                        .WithMany("Sets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Person", "Dj")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.FestivalEvent", b =>
                {
                    b.HasOne("Domain.Festival", "Festival")
                        .WithMany("FestivalEvents")
                        .HasForeignKey("FestivalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.OrganisedEvent", "OrganisedEvent")
                        .WithMany("FestivalEvents")
                        .HasForeignKey("OrganisedEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.OrganisedEvent", b =>
                {
                    b.HasOne("Domain.Venue", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Participant", b =>
                {
                    b.HasOne("Domain.OrganisedEvent", null)
                        .WithMany("Participants")
                        .HasForeignKey("OrganisedEventId");

                    b.HasOne("Domain.ParticipantType", "ParticipantType")
                        .WithMany("Participants")
                        .HasForeignKey("ParticipantTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Person", "Person")
                        .WithMany("Participants")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.SetTrack", b =>
                {
                    b.HasOne("Domain.EventSet", "EventSet")
                        .WithMany("SetTracks")
                        .HasForeignKey("EventSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Track", "Track")
                        .WithMany("SetTracks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.TrackAuthor", b =>
                {
                    b.HasOne("Domain.Person", "Author")
                        .WithMany("TrackAuthors")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.TrackAuthorType", "TrackAuthorType")
                        .WithMany("TrackAuthors")
                        .HasForeignKey("TrackAuthorTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Track", "Track")
                        .WithMany("TrackAuthors")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.VenueEquipment", b =>
                {
                    b.HasOne("Domain.Equipment", "Equipment")
                        .WithMany("VenueEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.OrganisedEvent", "OrganisedEvent")
                        .WithMany("VenueEquipment")
                        .HasForeignKey("OrganisedEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
