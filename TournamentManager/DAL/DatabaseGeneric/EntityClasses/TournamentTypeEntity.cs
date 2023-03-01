﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
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
	/// <summary>Entity class which represents the entity 'TournamentType'.<br/><br/></summary>
	[Serializable]
	public partial class TournamentTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<TournamentEntity> _tournaments;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TournamentTypeEntityStaticMetaData _staticMetaData = new TournamentTypeEntityStaticMetaData();
		private static TournamentTypeRelations _relationsFactory = new TournamentTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Tournaments</summary>
			public static readonly string Tournaments = "Tournaments";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TournamentTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TournamentTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("TournamentTypeEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.TournamentTypeEntity, typeof(TournamentTypeEntity), typeof(TournamentTypeEntityFactory), false);
				AddNavigatorMetaData<TournamentTypeEntity, EntityCollection<TournamentEntity>>("Tournaments", a => a._tournaments, (a, b) => a._tournaments = b, a => a.Tournaments, () => new TournamentTypeRelations().TournamentEntityUsingTypeId, typeof(TournamentEntity), (int)TournamentManager.DAL.EntityType.TournamentEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TournamentTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public TournamentTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TournamentTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TournamentTypeEntity</param>
		public TournamentTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TournamentType which data should be fetched into this TournamentType object</param>
		public TournamentTypeEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TournamentType which data should be fetched into this TournamentType object</param>
		/// <param name="validator">The custom validator object for this TournamentTypeEntity</param>
		public TournamentTypeEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TournamentTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Tournament' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTournaments() { return CreateRelationInfoForNavigator("Tournaments"); }
		
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
		/// <param name="validator">The validator object for this TournamentTypeEntity</param>
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
		public static TournamentTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Tournament' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTournaments { get { return _staticMetaData.GetPrefetchPathElement("Tournaments", CommonEntityBase.CreateEntityCollection<TournamentEntity>()); } }

		/// <summary>The Id property of the Entity TournamentType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TournamentType"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)TournamentTypeFieldIndex.Id, true); }
			set { SetValue((int)TournamentTypeFieldIndex.Id, value); }		}

		/// <summary>The Name property of the Entity TournamentType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TournamentType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TournamentTypeFieldIndex.Name, true); }
			set	{ SetValue((int)TournamentTypeFieldIndex.Name, value); }
		}

		/// <summary>The Description property of the Entity TournamentType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TournamentType"."Description".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)TournamentTypeFieldIndex.Description, true); }
			set	{ SetValue((int)TournamentTypeFieldIndex.Description, value); }
		}

		/// <summary>The CreatedOn property of the Entity TournamentType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TournamentType"."CreatedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedOn
		{
			get { return (System.DateTime)GetValue((int)TournamentTypeFieldIndex.CreatedOn, true); }
			set	{ SetValue((int)TournamentTypeFieldIndex.CreatedOn, value); }
		}

		/// <summary>The ModifiedOn property of the Entity TournamentType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TournamentType"."ModifiedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedOn
		{
			get { return (System.DateTime)GetValue((int)TournamentTypeFieldIndex.ModifiedOn, true); }
			set	{ SetValue((int)TournamentTypeFieldIndex.ModifiedOn, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'TournamentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TournamentEntity))]
		public virtual EntityCollection<TournamentEntity> Tournaments { get { return GetOrCreateEntityCollection<TournamentEntity, TournamentEntityFactory>("TournamentType", true, false, ref _tournaments); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum TournamentTypeFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
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
	/// <summary>Implements the relations factory for the entity: TournamentType. </summary>
	public partial class TournamentTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TournamentTypeEntity and TournamentEntity over the 1:n relation they have, using the relation between the fields: TournamentType.Id - Tournament.TypeId</summary>
		public virtual IEntityRelation TournamentEntityUsingTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Tournaments", true, new[] { TournamentTypeFields.Id, TournamentFields.TypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTournamentTypeRelations
	{
		internal static readonly IEntityRelation TournamentEntityUsingTypeIdStatic = new TournamentTypeRelations().TournamentEntityUsingTypeId;

		/// <summary>CTor</summary>
		static StaticTournamentTypeRelations() { }
	}
}
