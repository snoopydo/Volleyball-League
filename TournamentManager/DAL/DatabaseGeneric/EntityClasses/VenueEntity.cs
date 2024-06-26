﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TournamentManager.DAL.HelperClasses;
using TournamentManager.DAL.FactoryClasses;
using TournamentManager.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TournamentManager.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Venue'.<br/><br/></summary>
	[Serializable]
	public partial class VenueEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<AvailableMatchDateEntity> _availableMatchDates;
		private EntityCollection<MatchEntity> _origVenueMatches;
		private EntityCollection<MatchEntity> _currentVenueMatches;
		private EntityCollection<TeamEntity> _teams;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static VenueEntityStaticMetaData _staticMetaData = new VenueEntityStaticMetaData();
		private static VenueRelations _relationsFactory = new VenueRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AvailableMatchDates</summary>
			public static readonly string AvailableMatchDates = "AvailableMatchDates";
			/// <summary>Member name OrigVenueMatches</summary>
			public static readonly string OrigVenueMatches = "OrigVenueMatches";
			/// <summary>Member name CurrentVenueMatches</summary>
			public static readonly string CurrentVenueMatches = "CurrentVenueMatches";
			/// <summary>Member name Teams</summary>
			public static readonly string Teams = "Teams";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class VenueEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public VenueEntityStaticMetaData()
			{
				SetEntityCoreInfo("VenueEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.VenueEntity, typeof(VenueEntity), typeof(VenueEntityFactory), false);
				AddNavigatorMetaData<VenueEntity, EntityCollection<AvailableMatchDateEntity>>("AvailableMatchDates", a => a._availableMatchDates, (a, b) => a._availableMatchDates = b, a => a.AvailableMatchDates, () => new VenueRelations().AvailableMatchDateEntityUsingVenueId, typeof(AvailableMatchDateEntity), (int)TournamentManager.DAL.EntityType.AvailableMatchDateEntity);
				AddNavigatorMetaData<VenueEntity, EntityCollection<MatchEntity>>("OrigVenueMatches", a => a._origVenueMatches, (a, b) => a._origVenueMatches = b, a => a.OrigVenueMatches, () => new VenueRelations().MatchEntityUsingOrigVenueId, typeof(MatchEntity), (int)TournamentManager.DAL.EntityType.MatchEntity);
				AddNavigatorMetaData<VenueEntity, EntityCollection<MatchEntity>>("CurrentVenueMatches", a => a._currentVenueMatches, (a, b) => a._currentVenueMatches = b, a => a.CurrentVenueMatches, () => new VenueRelations().MatchEntityUsingVenueId, typeof(MatchEntity), (int)TournamentManager.DAL.EntityType.MatchEntity);
				AddNavigatorMetaData<VenueEntity, EntityCollection<TeamEntity>>("Teams", a => a._teams, (a, b) => a._teams = b, a => a.Teams, () => new VenueRelations().TeamEntityUsingVenueId, typeof(TeamEntity), (int)TournamentManager.DAL.EntityType.TeamEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static VenueEntity()
		{
		}

		/// <summary> CTor</summary>
		public VenueEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VenueEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VenueEntity</param>
		public VenueEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Venue which data should be fetched into this Venue object</param>
		public VenueEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Venue which data should be fetched into this Venue object</param>
		/// <param name="validator">The custom validator object for this VenueEntity</param>
		public VenueEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VenueEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AvailableMatchDate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAvailableMatchDates() { return CreateRelationInfoForNavigator("AvailableMatchDates"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Match' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrigVenueMatches() { return CreateRelationInfoForNavigator("OrigVenueMatches"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Match' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrentVenueMatches() { return CreateRelationInfoForNavigator("CurrentVenueMatches"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Team' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeams() { return CreateRelationInfoForNavigator("Teams"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this VenueEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static VenueRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AvailableMatchDate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAvailableMatchDates { get { return _staticMetaData.GetPrefetchPathElement("AvailableMatchDates", CommonEntityBase.CreateEntityCollection<AvailableMatchDateEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Match' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrigVenueMatches { get { return _staticMetaData.GetPrefetchPathElement("OrigVenueMatches", CommonEntityBase.CreateEntityCollection<MatchEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Match' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrentVenueMatches { get { return _staticMetaData.GetPrefetchPathElement("CurrentVenueMatches", CommonEntityBase.CreateEntityCollection<MatchEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeams { get { return _staticMetaData.GetPrefetchPathElement("Teams", CommonEntityBase.CreateEntityCollection<TeamEntity>()); } }

		/// <summary>The Id property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)VenueFieldIndex.Id, true); }
			set { SetValue((int)VenueFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.Name, true); }
			set { SetValue((int)VenueFieldIndex.Name, value); }
		}

		/// <summary>The Extension property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Extension".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Extension
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.Extension, true); }
			set { SetValue((int)VenueFieldIndex.Extension, value); }
		}

		/// <summary>The Street property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Street".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Street
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.Street, true); }
			set { SetValue((int)VenueFieldIndex.Street, value); }
		}

		/// <summary>The PostalCode property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."PostalCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.PostalCode, true); }
			set { SetValue((int)VenueFieldIndex.PostalCode, value); }
		}

		/// <summary>The City property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."City".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.City, true); }
			set { SetValue((int)VenueFieldIndex.City, value); }
		}

		/// <summary>The Longitude property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Longitude".<br/>Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> Longitude
		{
			get { return (Nullable<System.Double>)GetValue((int)VenueFieldIndex.Longitude, false); }
			set { SetValue((int)VenueFieldIndex.Longitude, value); }
		}

		/// <summary>The Latitude property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Latitude".<br/>Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> Latitude
		{
			get { return (Nullable<System.Double>)GetValue((int)VenueFieldIndex.Latitude, false); }
			set { SetValue((int)VenueFieldIndex.Latitude, value); }
		}

		/// <summary>The Direction property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."Direction".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Direction
		{
			get { return (System.String)GetValue((int)VenueFieldIndex.Direction, true); }
			set { SetValue((int)VenueFieldIndex.Direction, value); }
		}

		/// <summary>The CreatedOn property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."CreatedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedOn
		{
			get { return (System.DateTime)GetValue((int)VenueFieldIndex.CreatedOn, true); }
			set { SetValue((int)VenueFieldIndex.CreatedOn, value); }
		}

		/// <summary>The ModifiedOn property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."ModifiedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedOn
		{
			get { return (System.DateTime)GetValue((int)VenueFieldIndex.ModifiedOn, true); }
			set { SetValue((int)VenueFieldIndex.ModifiedOn, value); }
		}

		/// <summary>The PrecisePosition property of the Entity Venue<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Venue"."PrecisePosition".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PrecisePosition
		{
			get { return (System.Boolean)GetValue((int)VenueFieldIndex.PrecisePosition, true); }
			set { SetValue((int)VenueFieldIndex.PrecisePosition, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'AvailableMatchDateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AvailableMatchDateEntity))]
		public virtual EntityCollection<AvailableMatchDateEntity> AvailableMatchDates { get { return GetOrCreateEntityCollection<AvailableMatchDateEntity, AvailableMatchDateEntityFactory>("Venue", true, false, ref _availableMatchDates); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'MatchEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(MatchEntity))]
		public virtual EntityCollection<MatchEntity> OrigVenueMatches { get { return GetOrCreateEntityCollection<MatchEntity, MatchEntityFactory>("OrigVenue", true, false, ref _origVenueMatches); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'MatchEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(MatchEntity))]
		public virtual EntityCollection<MatchEntity> CurrentVenueMatches { get { return GetOrCreateEntityCollection<MatchEntity, MatchEntityFactory>("Venue", true, false, ref _currentVenueMatches); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'TeamEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TeamEntity))]
		public virtual EntityCollection<TeamEntity> Teams { get { return GetOrCreateEntityCollection<TeamEntity, TeamEntityFactory>("Venue", true, false, ref _teams); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum VenueFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Extension. </summary>
		Extension,
		///<summary>Street. </summary>
		Street,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>City. </summary>
		City,
		///<summary>Longitude. </summary>
		Longitude,
		///<summary>Latitude. </summary>
		Latitude,
		///<summary>Direction. </summary>
		Direction,
		///<summary>CreatedOn. </summary>
		CreatedOn,
		///<summary>ModifiedOn. </summary>
		ModifiedOn,
		///<summary>PrecisePosition. </summary>
		PrecisePosition,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Venue. </summary>
	public partial class VenueRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between VenueEntity and AvailableMatchDateEntity over the 1:n relation they have, using the relation between the fields: Venue.Id - AvailableMatchDate.VenueId</summary>
		public virtual IEntityRelation AvailableMatchDateEntityUsingVenueId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AvailableMatchDates", true, new[] { VenueFields.Id, AvailableMatchDateFields.VenueId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between VenueEntity and MatchEntity over the 1:n relation they have, using the relation between the fields: Venue.Id - Match.OrigVenueId</summary>
		public virtual IEntityRelation MatchEntityUsingOrigVenueId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "OrigVenueMatches", true, new[] { VenueFields.Id, MatchFields.OrigVenueId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between VenueEntity and MatchEntity over the 1:n relation they have, using the relation between the fields: Venue.Id - Match.VenueId</summary>
		public virtual IEntityRelation MatchEntityUsingVenueId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "CurrentVenueMatches", true, new[] { VenueFields.Id, MatchFields.VenueId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between VenueEntity and TeamEntity over the 1:n relation they have, using the relation between the fields: Venue.Id - Team.VenueId</summary>
		public virtual IEntityRelation TeamEntityUsingVenueId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Teams", true, new[] { VenueFields.Id, TeamFields.VenueId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticVenueRelations
	{
		internal static readonly IEntityRelation AvailableMatchDateEntityUsingVenueIdStatic = new VenueRelations().AvailableMatchDateEntityUsingVenueId;
		internal static readonly IEntityRelation MatchEntityUsingOrigVenueIdStatic = new VenueRelations().MatchEntityUsingOrigVenueId;
		internal static readonly IEntityRelation MatchEntityUsingVenueIdStatic = new VenueRelations().MatchEntityUsingVenueId;
		internal static readonly IEntityRelation TeamEntityUsingVenueIdStatic = new VenueRelations().TeamEntityUsingVenueId;

		/// <summary>CTor</summary>
		static StaticVenueRelations() { }
	}
}
