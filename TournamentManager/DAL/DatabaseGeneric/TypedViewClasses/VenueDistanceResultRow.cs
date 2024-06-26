﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace TournamentManager.DAL.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'VenueDistanceResult'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="TournamentManager.DAL.FactoryClasses.QueryFactory.GetVenueDistanceResultTypedViewProjection"/>. </remarks>
	[Serializable]
	public partial class VenueDistanceResultRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="VenueDistanceResultRow"/> class.</summary>
		public VenueDistanceResultRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the City field.</summary>
		public System.String City { get; set; }
		/// <summary>Gets or sets the CreatedOn field.</summary>
		public System.DateTime CreatedOn { get; set; }
		/// <summary>Gets or sets the Direction field.</summary>
		public System.String Direction { get; set; }
		/// <summary>Gets or sets the Distance field.</summary>
		public System.Double Distance { get; set; }
		/// <summary>Gets or sets the Extension field.</summary>
		public System.String Extension { get; set; }
		/// <summary>Gets or sets the Id field.</summary>
		public System.Int64 Id { get; set; }
		/// <summary>Gets or sets the Latitude field.</summary>
		public Nullable<System.Double> Latitude { get; set; }
		/// <summary>Gets or sets the Longitude field.</summary>
		public Nullable<System.Double> Longitude { get; set; }
		/// <summary>Gets or sets the ModifiedOn field.</summary>
		public System.DateTime ModifiedOn { get; set; }
		/// <summary>Gets or sets the Name field.</summary>
		public System.String Name { get; set; }
		/// <summary>Gets or sets the PostalCode field.</summary>
		public System.String PostalCode { get; set; }
		/// <summary>Gets or sets the PrecisePosition field.</summary>
		public System.Boolean PrecisePosition { get; set; }
		/// <summary>Gets or sets the Street field.</summary>
		public System.String Street { get; set; }
	}
}

