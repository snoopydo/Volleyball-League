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
	/// <summary>Entity class which represents the entity 'TeamInRound'.<br/><br/></summary>
	[Serializable]
	public partial class TeamInRoundEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private RoundEntity _round;
		private TeamEntity _team;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TeamInRoundEntityStaticMetaData _staticMetaData = new TeamInRoundEntityStaticMetaData();
		private static TeamInRoundRelations _relationsFactory = new TeamInRoundRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Round</summary>
			public static readonly string Round = "Round";
			/// <summary>Member name Team</summary>
			public static readonly string Team = "Team";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TeamInRoundEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TeamInRoundEntityStaticMetaData()
			{
				SetEntityCoreInfo("TeamInRoundEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.TeamInRoundEntity, typeof(TeamInRoundEntity), typeof(TeamInRoundEntityFactory), false);
				AddNavigatorMetaData<TeamInRoundEntity, RoundEntity>("Round", "TeamInRounds", (a, b) => a._round = b, a => a._round, (a, b) => a.Round = b, TournamentManager.DAL.RelationClasses.StaticTeamInRoundRelations.RoundEntityUsingRoundIdStatic, ()=>new TeamInRoundRelations().RoundEntityUsingRoundId, null, new int[] { (int)TeamInRoundFieldIndex.RoundId }, null, true, (int)TournamentManager.DAL.EntityType.RoundEntity);
				AddNavigatorMetaData<TeamInRoundEntity, TeamEntity>("Team", "TeamInRounds", (a, b) => a._team = b, a => a._team, (a, b) => a.Team = b, TournamentManager.DAL.RelationClasses.StaticTeamInRoundRelations.TeamEntityUsingTeamIdStatic, ()=>new TeamInRoundRelations().TeamEntityUsingTeamId, null, new int[] { (int)TeamInRoundFieldIndex.TeamId }, null, true, (int)TournamentManager.DAL.EntityType.TeamEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TeamInRoundEntity()
		{
		}

		/// <summary> CTor</summary>
		public TeamInRoundEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TeamInRoundEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TeamInRoundEntity</param>
		public TeamInRoundEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="roundId">PK value for TeamInRound which data should be fetched into this TeamInRound object</param>
		/// <param name="teamId">PK value for TeamInRound which data should be fetched into this TeamInRound object</param>
		public TeamInRoundEntity(System.Int64 roundId, System.Int64 teamId) : this(roundId, teamId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="roundId">PK value for TeamInRound which data should be fetched into this TeamInRound object</param>
		/// <param name="teamId">PK value for TeamInRound which data should be fetched into this TeamInRound object</param>
		/// <param name="validator">The custom validator object for this TeamInRoundEntity</param>
		public TeamInRoundEntity(System.Int64 roundId, System.Int64 teamId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.RoundId = roundId;
			this.TeamId = teamId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TeamInRoundEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Round' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRound() { return CreateRelationInfoForNavigator("Round"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Team' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTeam() { return CreateRelationInfoForNavigator("Team"); }
		
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
		/// <param name="validator">The validator object for this TeamInRoundEntity</param>
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
		public static TeamInRoundRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Round' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRound { get { return _staticMetaData.GetPrefetchPathElement("Round", CommonEntityBase.CreateEntityCollection<RoundEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Team' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTeam { get { return _staticMetaData.GetPrefetchPathElement("Team", CommonEntityBase.CreateEntityCollection<TeamEntity>()); } }

		/// <summary>The Id property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)TeamInRoundFieldIndex.Id, true); }

		}

		/// <summary>The RoundId property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."RoundId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int64 RoundId
		{
			get { return (System.Int64)GetValue((int)TeamInRoundFieldIndex.RoundId, true); }
			set { SetValue((int)TeamInRoundFieldIndex.RoundId, value); }
		}

		/// <summary>The TeamId property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."TeamId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int64 TeamId
		{
			get { return (System.Int64)GetValue((int)TeamInRoundFieldIndex.TeamId, true); }
			set { SetValue((int)TeamInRoundFieldIndex.TeamId, value); }
		}

		/// <summary>The TeamNameForRound property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."TeamNameForRound".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TeamNameForRound
		{
			get { return (System.String)GetValue((int)TeamInRoundFieldIndex.TeamNameForRound, true); }
			set { SetValue((int)TeamInRoundFieldIndex.TeamNameForRound, value); }
		}

		/// <summary>The CreatedOn property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."CreatedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedOn
		{
			get { return (System.DateTime)GetValue((int)TeamInRoundFieldIndex.CreatedOn, true); }
			set { SetValue((int)TeamInRoundFieldIndex.CreatedOn, value); }
		}

		/// <summary>The ModifiedOn property of the Entity TeamInRound<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TeamInRound"."ModifiedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedOn
		{
			get { return (System.DateTime)GetValue((int)TeamInRoundFieldIndex.ModifiedOn, true); }
			set { SetValue((int)TeamInRoundFieldIndex.ModifiedOn, value); }
		}

		/// <summary>Gets / sets related entity of type 'RoundEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RoundEntity Round
		{
			get { return _round; }
			set { SetSingleRelatedEntityNavigator(value, "Round"); }
		}

		/// <summary>Gets / sets related entity of type 'TeamEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual TeamEntity Team
		{
			get { return _team; }
			set { SetSingleRelatedEntityNavigator(value, "Team"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum TeamInRoundFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>RoundId. </summary>
		RoundId,
		///<summary>TeamId. </summary>
		TeamId,
		///<summary>TeamNameForRound. </summary>
		TeamNameForRound,
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
	/// <summary>Implements the relations factory for the entity: TeamInRound. </summary>
	public partial class TeamInRoundRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between TeamInRoundEntity and RoundEntity over the m:1 relation they have, using the relation between the fields: TeamInRound.RoundId - Round.Id</summary>
		public virtual IEntityRelation RoundEntityUsingRoundId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Round", false, new[] { RoundFields.Id, TeamInRoundFields.RoundId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TeamInRoundEntity and TeamEntity over the m:1 relation they have, using the relation between the fields: TeamInRound.TeamId - Team.Id</summary>
		public virtual IEntityRelation TeamEntityUsingTeamId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Team", false, new[] { TeamFields.Id, TeamInRoundFields.TeamId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTeamInRoundRelations
	{
		internal static readonly IEntityRelation RoundEntityUsingRoundIdStatic = new TeamInRoundRelations().RoundEntityUsingRoundId;
		internal static readonly IEntityRelation TeamEntityUsingTeamIdStatic = new TeamInRoundRelations().TeamEntityUsingTeamId;

		/// <summary>CTor</summary>
		static StaticTeamInRoundRelations() { }
	}
}
