﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace TournamentManager.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'PlannedMatch'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the property <see cref="TournamentManager.DAL.FactoryClasses.QueryFactory.PlannedMatch"/>. </remarks>
	[Serializable]
	public partial class PlannedMatchRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="PlannedMatchRow"/> class.</summary>
		public PlannedMatchRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ChangeSerial field.</summary>
		public System.Int64 ChangeSerial { get; set; }
		/// <summary>Gets or sets the GuestTeamId field.</summary>
		public System.Int64 GuestTeamId { get; set; }
		/// <summary>Gets or sets the GuestTeamNameForRound field.</summary>
		public System.String GuestTeamNameForRound { get; set; }
		/// <summary>Gets or sets the HomeTeamId field.</summary>
		public System.Int64 HomeTeamId { get; set; }
		/// <summary>Gets or sets the HomeTeamNameForRound field.</summary>
		public System.String HomeTeamNameForRound { get; set; }
		/// <summary>Gets or sets the Id field.</summary>
		public System.Int64 Id { get; set; }
		/// <summary>Gets or sets the ModifiedOn field.</summary>
		public System.DateTime ModifiedOn { get; set; }
		/// <summary>Gets or sets the OrigPlannedEnd field.</summary>
		public Nullable<System.DateTime> OrigPlannedEnd { get; set; }
		/// <summary>Gets or sets the OrigPlannedStart field.</summary>
		public Nullable<System.DateTime> OrigPlannedStart { get; set; }
		/// <summary>Gets or sets the OrigVenueExtension field.</summary>
		public System.String OrigVenueExtension { get; set; }
		/// <summary>Gets or sets the OrigVenueId field.</summary>
		public Nullable<System.Int64> OrigVenueId { get; set; }
		/// <summary>Gets or sets the OrigVenueName field.</summary>
		public System.String OrigVenueName { get; set; }
		/// <summary>Gets or sets the PlannedEnd field.</summary>
		public Nullable<System.DateTime> PlannedEnd { get; set; }
		/// <summary>Gets or sets the PlannedStart field.</summary>
		public Nullable<System.DateTime> PlannedStart { get; set; }
		/// <summary>Gets or sets the Remarks field.</summary>
		public System.String Remarks { get; set; }
		/// <summary>Gets or sets the RoundDescription field.</summary>
		public System.String RoundDescription { get; set; }
		/// <summary>Gets or sets the RoundId field.</summary>
		public System.Int64 RoundId { get; set; }
		/// <summary>Gets or sets the RoundLegDescription field.</summary>
		public System.String RoundLegDescription { get; set; }
		/// <summary>Gets or sets the RoundLegSequenceNo field.</summary>
		public System.Int32 RoundLegSequenceNo { get; set; }
		/// <summary>Gets or sets the RoundName field.</summary>
		public System.String RoundName { get; set; }
		/// <summary>Gets or sets the RoundTypeDescription field.</summary>
		public System.String RoundTypeDescription { get; set; }
		/// <summary>Gets or sets the RoundTypeName field.</summary>
		public System.String RoundTypeName { get; set; }
		/// <summary>Gets or sets the TournamentId field.</summary>
		public Nullable<System.Int64> TournamentId { get; set; }
		/// <summary>Gets or sets the TournamentName field.</summary>
		public System.String TournamentName { get; set; }
		/// <summary>Gets or sets the VenueExtension field.</summary>
		public System.String VenueExtension { get; set; }
		/// <summary>Gets or sets the VenueId field.</summary>
		public Nullable<System.Int64> VenueId { get; set; }
		/// <summary>Gets or sets the VenueName field.</summary>
		public System.String VenueName { get; set; }
	}
}

