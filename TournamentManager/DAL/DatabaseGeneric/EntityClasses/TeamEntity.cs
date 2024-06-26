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
	/// <summary>Entity class which represents the entity 'Team'.<br/><br/></summary>
	[Serializable]
	public partial class TeamEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<AvailableMatchDateEntity> _availableMatchDates;
		private EntityCollection<ExcludeMatchDateEntity> _excludeMatchDates;
		private EntityCollection<ManagerOfTeamEntity> _managerOfTeams;
		private EntityCollection<MatchEntity> _matchGuestTeam;
		private EntityCollection<MatchEntity> _matchHomeTeam;
		private EntityCollection<MatchEntity> _matchReferee;
		private EntityCollection<PlayerInTeamEntity> _playerInTeams;
		private EntityCollection<RankingEntity> _rankings;
		private EntityCollection<RegistrationEntity> _registration;
		private EntityCollection<TeamInRoundEntity> _teamInRounds;
		private EntityCollection<RoundEntity> _roundCollectionViaTeamsInRounds;
		private VenueEntity _venue;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TeamEntityStaticMetaData _staticMetaData = new TeamEntityStaticMetaData();
		private static TeamRelations _relationsFactory = new TeamRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Venue</summary>
			public static readonly string Venue = "Venue";
			/// <summary>Member name AvailableMatchDates</summary>
			public static readonly string AvailableMatchDates = "AvailableMatchDates";
			/// <summary>Member name ExcludeMatchDates</summary>
			public static readonly string ExcludeMatchDates = "ExcludeMatchDates";
			/// <summary>Member name ManagerOfTeams</summary>
			public static readonly string ManagerOfTeams = "ManagerOfTeams";
			/// <summary>Member name MatchGuestTeam</summary>
			public static readonly string MatchGuestTeam = "MatchGuestTeam";
			/// <summary>Member name MatchHomeTeam</summary>
			public static readonly string MatchHomeTeam = "MatchHomeTeam";
			/// <summary>Member name MatchReferee</summary>
			public static readonly string MatchReferee = "MatchReferee";
			/// <summary>Member name PlayerInTeams</summary>
			public static readonly string PlayerInTeams = "PlayerInTeams";
			/// <summary>Member name Rankings</summary>
			public static readonly string Rankings = "Rankings";
			/// <summary>Member name Registration</summary>
			public static readonly string Registration = "Registration";
			/// <summary>Member name TeamInRounds</summary>
			public static readonly string TeamInRounds = "TeamInRounds";
			/// <summary>Member name RoundCollectionViaTeamsInRounds</summary>
			public static readonly string RoundCollectionViaTeamsInRounds = "RoundCollectionViaTeamsInRounds";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TeamEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TeamEntityStaticMetaData()
			{
				SetEntityCoreInfo("TeamEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.TeamEntity, typeof(TeamEntity), typeof(TeamEntityFactory), false);
				AddNavigatorMetaData<TeamEntity, EntityCollection<AvailableMatchDateEntity>>("AvailableMatchDates", a => a._availableMatchDates, (a, b) => a._availableMatchDates = b, a => a.AvailableMatchDates, () => new TeamRelations().AvailableMatchDateEntityUsingHomeTeamId, typeof(AvailableMatchDateEntity), (int)TournamentManager.DAL.EntityType.AvailableMatchDateEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<ExcludeMatchDateEntity>>("ExcludeMatchDates", a => a._excludeMatchDates, (a, b) => a._excludeMatchDates = b, a => a.ExcludeMatchDates, () => new TeamRelations().ExcludeMatchDateEntityUsingTeamId, typeof(ExcludeMatchDateEntity), (int)TournamentManager.DAL.EntityType.ExcludeMatchDateEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<ManagerOfTeamEntity>>("ManagerOfTeams", a => a._managerOfTeams, (a, b) => a._managerOfTeams = b, a => a.ManagerOfTeams, () => new TeamRelations().ManagerOfTeamEntityUsingTeamId, typeof(ManagerOfTeamEntity), (int)TournamentManager.DAL.EntityType.ManagerOfTeamEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<MatchEntity>>("MatchGuestTeam", a => a._matchGuestTeam, (a, b) => a._matchGuestTeam = b, a => a.MatchGuestTeam, () => new TeamRelations().MatchEntityUsingGuestTeamId, typeof(MatchEntity), (int)TournamentManager.DAL.EntityType.MatchEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<MatchEntity>>("MatchHomeTeam", a => a._matchHomeTeam, (a, b) => a._matchHomeTeam = b, a => a.MatchHomeTeam, () => new TeamRelations().MatchEntityUsingHomeTeamId, typeof(MatchEntity), (int)TournamentManager.DAL.EntityType.MatchEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<MatchEntity>>("MatchReferee", a => a._matchReferee, (a, b) => a._matchReferee = b, a => a.MatchReferee, () => new TeamRelations().MatchEntityUsingRefereeId, typeof(MatchEntity), (int)TournamentManager.DAL.EntityType.MatchEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<PlayerInTeamEntity>>("PlayerInTeams", a => a._playerInTeams, (a, b) => a._playerInTeams = b, a => a.PlayerInTeams, () => new TeamRelations().PlayerInTeamEntityUsingTeamId, typeof(PlayerInTeamEntity), (int)TournamentManager.DAL.EntityType.PlayerInTeamEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<RankingEntity>>("Rankings", a => a._rankings, (a, b) => a._rankings = b, a => a.Rankings, () => new TeamRelations().RankingEntityUsingTeamId, typeof(RankingEntity), (int)TournamentManager.DAL.EntityType.RankingEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<RegistrationEntity>>("Registration", a => a._registration, (a, b) => a._registration = b, a => a.Registration, () => new TeamRelations().RegistrationEntityUsingTeamId, typeof(RegistrationEntity), (int)TournamentManager.DAL.EntityType.RegistrationEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<TeamInRoundEntity>>("TeamInRounds", a => a._teamInRounds, (a, b) => a._teamInRounds = b, a => a.TeamInRounds, () => new TeamRelations().TeamInRoundEntityUsingTeamId, typeof(TeamInRoundEntity), (int)TournamentManager.DAL.EntityType.TeamInRoundEntity);
				AddNavigatorMetaData<TeamEntity, VenueEntity>("Venue", "Teams", (a, b) => a._venue = b, a => a._venue, (a, b) => a.Venue = b, TournamentManager.DAL.RelationClasses.StaticTeamRelations.VenueEntityUsingVenueIdStatic, ()=>new TeamRelations().VenueEntityUsingVenueId, null, new int[] { (int)TeamFieldIndex.VenueId }, null, true, (int)TournamentManager.DAL.EntityType.VenueEntity);
				AddNavigatorMetaData<TeamEntity, EntityCollection<RoundEntity>>("RoundCollectionViaTeamsInRounds", a => a._roundCollectionViaTeamsInRounds, (a, b) => a._roundCollectionViaTeamsInRounds = b, a => a.RoundCollectionViaTeamsInRounds, () => new TeamRelations().TeamInRoundEntityUsingTeamId, () => new TeamInRoundRelations().RoundEntityUsingRoundId, "TeamEntity__", "TeamInRound_", typeof(RoundEntity), (int)TournamentManager.DAL.EntityType.RoundEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TeamEntity()
		{
		}

		/// <summary> CTor</summary>
		public TeamEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TeamEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		public TeamEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Team which data should be fetched into this Team object</param>
		public TeamEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Team which data should be fetched into this Team object</param>
		/// <param name="validator">The custom validator object for this TeamEntity</param>
		public TeamEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TeamEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'AvailableMatchDate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAvailableMatchDates() { return CreateRelationInfoForNavigator("AvailableMatchDates"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ExcludeMatchDate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoExcludeMatchDates() { return CreateRelationInfoForNavigator("ExcludeMatchDates"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ManagerOfTeam' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoManagerOfTeams() { return CreateRelationInfoForNavigator("ManagerOfTeams"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Match' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoMatchGuestTeam() { return CreateRelationInfoForNavigator("MatchGuestTeam"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Match' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoMatchHomeTeam() { return CreateRelationInfoForNavigator("MatchHomeTeam"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Match' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoMatchReferee() { return CreateRelationInfoForNavigator("MatchReferee"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PlayerInTeam' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPlayerInTeams() { return CreateRelationInfoForNavigator("PlayerInTeams"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Ranking' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRankings() { return CreateRelationInfoForNavigator("Rankings"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Registration' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRegistration() { return CreateRelationInfoForNavigator("Registration"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'TeamInRound' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeamInRounds() { return CreateRelationInfoForNavigator("TeamInRounds"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Round' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRoundCollectionViaTeamsInRounds() { return CreateRelationInfoForNavigator("RoundCollectionViaTeamsInRounds"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Venue' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVenue() { return CreateRelationInfoForNavigator("Venue"); }
		
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
		/// <param name="validator">The validator object for this TeamEntity</param>
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
		public static TeamRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AvailableMatchDate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAvailableMatchDates { get { return _staticMetaData.GetPrefetchPathElement("AvailableMatchDates", CommonEntityBase.CreateEntityCollection<AvailableMatchDateEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ExcludeMatchDate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathExcludeMatchDates { get { return _staticMetaData.GetPrefetchPathElement("ExcludeMatchDates", CommonEntityBase.CreateEntityCollection<ExcludeMatchDateEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ManagerOfTeam' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathManagerOfTeams { get { return _staticMetaData.GetPrefetchPathElement("ManagerOfTeams", CommonEntityBase.CreateEntityCollection<ManagerOfTeamEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Match' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathMatchGuestTeam { get { return _staticMetaData.GetPrefetchPathElement("MatchGuestTeam", CommonEntityBase.CreateEntityCollection<MatchEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Match' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathMatchHomeTeam { get { return _staticMetaData.GetPrefetchPathElement("MatchHomeTeam", CommonEntityBase.CreateEntityCollection<MatchEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Match' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathMatchReferee { get { return _staticMetaData.GetPrefetchPathElement("MatchReferee", CommonEntityBase.CreateEntityCollection<MatchEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PlayerInTeam' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPlayerInTeams { get { return _staticMetaData.GetPrefetchPathElement("PlayerInTeams", CommonEntityBase.CreateEntityCollection<PlayerInTeamEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Ranking' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRankings { get { return _staticMetaData.GetPrefetchPathElement("Rankings", CommonEntityBase.CreateEntityCollection<RankingEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Registration' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRegistration { get { return _staticMetaData.GetPrefetchPathElement("Registration", CommonEntityBase.CreateEntityCollection<RegistrationEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TeamInRound' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeamInRounds { get { return _staticMetaData.GetPrefetchPathElement("TeamInRounds", CommonEntityBase.CreateEntityCollection<TeamInRoundEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Round' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRoundCollectionViaTeamsInRounds { get { return _staticMetaData.GetPrefetchPathElement("RoundCollectionViaTeamsInRounds", CommonEntityBase.CreateEntityCollection<RoundEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Venue' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVenue { get { return _staticMetaData.GetPrefetchPathElement("Venue", CommonEntityBase.CreateEntityCollection<VenueEntity>()); } }

		/// <summary>The Id property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)TeamFieldIndex.Id, true); }
			set { SetValue((int)TeamFieldIndex.Id, value); }
		}

		/// <summary>The VenueId property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."VenueId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int64> VenueId
		{
			get { return (Nullable<System.Int64>)GetValue((int)TeamFieldIndex.VenueId, false); }
			set { SetValue((int)TeamFieldIndex.VenueId, value); }
		}

		/// <summary>The Name property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TeamFieldIndex.Name, true); }
			set { SetValue((int)TeamFieldIndex.Name, value); }
		}

		/// <summary>The MatchDayOfWeek property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."MatchDayOfWeek".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MatchDayOfWeek
		{
			get { return (Nullable<System.Int32>)GetValue((int)TeamFieldIndex.MatchDayOfWeek, false); }
			set { SetValue((int)TeamFieldIndex.MatchDayOfWeek, value); }
		}

		/// <summary>The MatchTime property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."MatchTime".<br/>Table field type characteristics (type, precision, scale, length): Time, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.TimeSpan> MatchTime
		{
			get { return (Nullable<System.TimeSpan>)GetValue((int)TeamFieldIndex.MatchTime, false); }
			set { SetValue((int)TeamFieldIndex.MatchTime, value); }
		}

		/// <summary>The ClubName property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."ClubName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ClubName
		{
			get { return (System.String)GetValue((int)TeamFieldIndex.ClubName, true); }
			set { SetValue((int)TeamFieldIndex.ClubName, value); }
		}

		/// <summary>The CreatedOn property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."CreatedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedOn
		{
			get { return (System.DateTime)GetValue((int)TeamFieldIndex.CreatedOn, true); }
			set { SetValue((int)TeamFieldIndex.CreatedOn, value); }
		}

		/// <summary>The ModifiedOn property of the Entity Team<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Team"."ModifiedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedOn
		{
			get { return (System.DateTime)GetValue((int)TeamFieldIndex.ModifiedOn, true); }
			set { SetValue((int)TeamFieldIndex.ModifiedOn, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'AvailableMatchDateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AvailableMatchDateEntity))]
		public virtual EntityCollection<AvailableMatchDateEntity> AvailableMatchDates { get { return GetOrCreateEntityCollection<AvailableMatchDateEntity, AvailableMatchDateEntityFactory>("Team", true, false, ref _availableMatchDates); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ExcludeMatchDateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ExcludeMatchDateEntity))]
		public virtual EntityCollection<ExcludeMatchDateEntity> ExcludeMatchDates { get { return GetOrCreateEntityCollection<ExcludeMatchDateEntity, ExcludeMatchDateEntityFactory>("Team", true, false, ref _excludeMatchDates); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ManagerOfTeamEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ManagerOfTeamEntity))]
		public virtual EntityCollection<ManagerOfTeamEntity> ManagerOfTeams { get { return GetOrCreateEntityCollection<ManagerOfTeamEntity, ManagerOfTeamEntityFactory>("Team", true, false, ref _managerOfTeams); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'MatchEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(MatchEntity))]
		public virtual EntityCollection<MatchEntity> MatchGuestTeam { get { return GetOrCreateEntityCollection<MatchEntity, MatchEntityFactory>("GuestTeam", true, false, ref _matchGuestTeam); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'MatchEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(MatchEntity))]
		public virtual EntityCollection<MatchEntity> MatchHomeTeam { get { return GetOrCreateEntityCollection<MatchEntity, MatchEntityFactory>("HomeTeam", true, false, ref _matchHomeTeam); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'MatchEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(MatchEntity))]
		public virtual EntityCollection<MatchEntity> MatchReferee { get { return GetOrCreateEntityCollection<MatchEntity, MatchEntityFactory>("RefereeTeam", true, false, ref _matchReferee); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'PlayerInTeamEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PlayerInTeamEntity))]
		public virtual EntityCollection<PlayerInTeamEntity> PlayerInTeams { get { return GetOrCreateEntityCollection<PlayerInTeamEntity, PlayerInTeamEntityFactory>("Team", true, false, ref _playerInTeams); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RankingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RankingEntity))]
		public virtual EntityCollection<RankingEntity> Rankings { get { return GetOrCreateEntityCollection<RankingEntity, RankingEntityFactory>("Team", true, false, ref _rankings); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RegistrationEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RegistrationEntity))]
		public virtual EntityCollection<RegistrationEntity> Registration { get { return GetOrCreateEntityCollection<RegistrationEntity, RegistrationEntityFactory>("Team", true, false, ref _registration); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'TeamInRoundEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TeamInRoundEntity))]
		public virtual EntityCollection<TeamInRoundEntity> TeamInRounds { get { return GetOrCreateEntityCollection<TeamInRoundEntity, TeamInRoundEntityFactory>("Team", true, false, ref _teamInRounds); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'RoundEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RoundEntity))]
		public virtual EntityCollection<RoundEntity> RoundCollectionViaTeamsInRounds { get { return GetOrCreateEntityCollection<RoundEntity, RoundEntityFactory>("TeamCollectionViaTeamInRound", false, true, ref _roundCollectionViaTeamsInRounds); } }

		/// <summary>Gets / sets related entity of type 'VenueEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VenueEntity Venue
		{
			get { return _venue; }
			set { SetSingleRelatedEntityNavigator(value, "Venue"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum TeamFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>VenueId. </summary>
		VenueId,
		///<summary>Name. </summary>
		Name,
		///<summary>MatchDayOfWeek. </summary>
		MatchDayOfWeek,
		///<summary>MatchTime. </summary>
		MatchTime,
		///<summary>ClubName. </summary>
		ClubName,
		///<summary>CreatedOn. </summary>
		CreatedOn,
		///<summary>ModifiedOn. </summary>
		ModifiedOn,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Team. </summary>
	public partial class TeamRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TeamEntity and AvailableMatchDateEntity over the 1:n relation they have, using the relation between the fields: Team.Id - AvailableMatchDate.HomeTeamId</summary>
		public virtual IEntityRelation AvailableMatchDateEntityUsingHomeTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "AvailableMatchDates", true, new[] { TeamFields.Id, AvailableMatchDateFields.HomeTeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and ExcludeMatchDateEntity over the 1:n relation they have, using the relation between the fields: Team.Id - ExcludeMatchDate.TeamId</summary>
		public virtual IEntityRelation ExcludeMatchDateEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ExcludeMatchDates", true, new[] { TeamFields.Id, ExcludeMatchDateFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and ManagerOfTeamEntity over the 1:n relation they have, using the relation between the fields: Team.Id - ManagerOfTeam.TeamId</summary>
		public virtual IEntityRelation ManagerOfTeamEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ManagerOfTeams", true, new[] { TeamFields.Id, ManagerOfTeamFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and MatchEntity over the 1:n relation they have, using the relation between the fields: Team.Id - Match.GuestTeamId</summary>
		public virtual IEntityRelation MatchEntityUsingGuestTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "MatchGuestTeam", true, new[] { TeamFields.Id, MatchFields.GuestTeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and MatchEntity over the 1:n relation they have, using the relation between the fields: Team.Id - Match.HomeTeamId</summary>
		public virtual IEntityRelation MatchEntityUsingHomeTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "MatchHomeTeam", true, new[] { TeamFields.Id, MatchFields.HomeTeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and MatchEntity over the 1:n relation they have, using the relation between the fields: Team.Id - Match.RefereeId</summary>
		public virtual IEntityRelation MatchEntityUsingRefereeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "MatchReferee", true, new[] { TeamFields.Id, MatchFields.RefereeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and PlayerInTeamEntity over the 1:n relation they have, using the relation between the fields: Team.Id - PlayerInTeam.TeamId</summary>
		public virtual IEntityRelation PlayerInTeamEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PlayerInTeams", true, new[] { TeamFields.Id, PlayerInTeamFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and RankingEntity over the 1:n relation they have, using the relation between the fields: Team.Id - Ranking.TeamId</summary>
		public virtual IEntityRelation RankingEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Rankings", true, new[] { TeamFields.Id, RankingFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and RegistrationEntity over the 1:n relation they have, using the relation between the fields: Team.Id - Registration.TeamId</summary>
		public virtual IEntityRelation RegistrationEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Registration", true, new[] { TeamFields.Id, RegistrationFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and TeamInRoundEntity over the 1:n relation they have, using the relation between the fields: Team.Id - TeamInRound.TeamId</summary>
		public virtual IEntityRelation TeamInRoundEntityUsingTeamId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "TeamInRounds", true, new[] { TeamFields.Id, TeamInRoundFields.TeamId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamEntity and VenueEntity over the m:1 relation they have, using the relation between the fields: Team.VenueId - Venue.Id</summary>
		public virtual IEntityRelation VenueEntityUsingVenueId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Venue", false, new[] { VenueFields.Id, TeamFields.VenueId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTeamRelations
	{
		internal static readonly IEntityRelation AvailableMatchDateEntityUsingHomeTeamIdStatic = new TeamRelations().AvailableMatchDateEntityUsingHomeTeamId;
		internal static readonly IEntityRelation ExcludeMatchDateEntityUsingTeamIdStatic = new TeamRelations().ExcludeMatchDateEntityUsingTeamId;
		internal static readonly IEntityRelation ManagerOfTeamEntityUsingTeamIdStatic = new TeamRelations().ManagerOfTeamEntityUsingTeamId;
		internal static readonly IEntityRelation MatchEntityUsingGuestTeamIdStatic = new TeamRelations().MatchEntityUsingGuestTeamId;
		internal static readonly IEntityRelation MatchEntityUsingHomeTeamIdStatic = new TeamRelations().MatchEntityUsingHomeTeamId;
		internal static readonly IEntityRelation MatchEntityUsingRefereeIdStatic = new TeamRelations().MatchEntityUsingRefereeId;
		internal static readonly IEntityRelation PlayerInTeamEntityUsingTeamIdStatic = new TeamRelations().PlayerInTeamEntityUsingTeamId;
		internal static readonly IEntityRelation RankingEntityUsingTeamIdStatic = new TeamRelations().RankingEntityUsingTeamId;
		internal static readonly IEntityRelation RegistrationEntityUsingTeamIdStatic = new TeamRelations().RegistrationEntityUsingTeamId;
		internal static readonly IEntityRelation TeamInRoundEntityUsingTeamIdStatic = new TeamRelations().TeamInRoundEntityUsingTeamId;
		internal static readonly IEntityRelation VenueEntityUsingVenueIdStatic = new TeamRelations().VenueEntityUsingVenueId;

		/// <summary>CTor</summary>
		static StaticTeamRelations() { }
	}
}
