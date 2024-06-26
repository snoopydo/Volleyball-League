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
	/// <summary>Entity class which represents the entity 'IdentityRole'.<br/><br/></summary>
	[Serializable]
	public partial class IdentityRoleEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<IdentityRoleClaimEntity> _identityRoleClaims;
		private EntityCollection<IdentityUserRoleEntity> _identityUserRoles;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static IdentityRoleEntityStaticMetaData _staticMetaData = new IdentityRoleEntityStaticMetaData();
		private static IdentityRoleRelations _relationsFactory = new IdentityRoleRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name IdentityRoleClaims</summary>
			public static readonly string IdentityRoleClaims = "IdentityRoleClaims";
			/// <summary>Member name IdentityUserRoles</summary>
			public static readonly string IdentityUserRoles = "IdentityUserRoles";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IdentityRoleEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IdentityRoleEntityStaticMetaData()
			{
				SetEntityCoreInfo("IdentityRoleEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.IdentityRoleEntity, typeof(IdentityRoleEntity), typeof(IdentityRoleEntityFactory), false);
				AddNavigatorMetaData<IdentityRoleEntity, EntityCollection<IdentityRoleClaimEntity>>("IdentityRoleClaims", a => a._identityRoleClaims, (a, b) => a._identityRoleClaims = b, a => a.IdentityRoleClaims, () => new IdentityRoleRelations().IdentityRoleClaimEntityUsingRoleId, typeof(IdentityRoleClaimEntity), (int)TournamentManager.DAL.EntityType.IdentityRoleClaimEntity);
				AddNavigatorMetaData<IdentityRoleEntity, EntityCollection<IdentityUserRoleEntity>>("IdentityUserRoles", a => a._identityUserRoles, (a, b) => a._identityUserRoles = b, a => a.IdentityUserRoles, () => new IdentityRoleRelations().IdentityUserRoleEntityUsingRoleId, typeof(IdentityUserRoleEntity), (int)TournamentManager.DAL.EntityType.IdentityUserRoleEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IdentityRoleEntity()
		{
		}

		/// <summary> CTor</summary>
		public IdentityRoleEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IdentityRoleEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IdentityRoleEntity</param>
		public IdentityRoleEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityRole which data should be fetched into this IdentityRole object</param>
		public IdentityRoleEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityRole which data should be fetched into this IdentityRole object</param>
		/// <param name="validator">The custom validator object for this IdentityRoleEntity</param>
		public IdentityRoleEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IdentityRoleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: Name .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCName()
		{
			var filter = new PredicateExpression();
			filter.Add(TournamentManager.DAL.HelperClasses.IdentityRoleFields.Name == this.Fields.GetCurrentValue((int)IdentityRoleFieldIndex.Name));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'IdentityRoleClaim' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoIdentityRoleClaims() { return CreateRelationInfoForNavigator("IdentityRoleClaims"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'IdentityUserRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoIdentityUserRoles() { return CreateRelationInfoForNavigator("IdentityUserRoles"); }
		
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
		/// <param name="validator">The validator object for this IdentityRoleEntity</param>
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
		public static IdentityRoleRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'IdentityRoleClaim' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathIdentityRoleClaims { get { return _staticMetaData.GetPrefetchPathElement("IdentityRoleClaims", CommonEntityBase.CreateEntityCollection<IdentityRoleClaimEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'IdentityUserRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathIdentityUserRoles { get { return _staticMetaData.GetPrefetchPathElement("IdentityUserRoles", CommonEntityBase.CreateEntityCollection<IdentityUserRoleEntity>()); } }

		/// <summary>The Id property of the Entity IdentityRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRole"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)IdentityRoleFieldIndex.Id, true); }
			set { SetValue((int)IdentityRoleFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity IdentityRole<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRole"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)IdentityRoleFieldIndex.Name, true); }
			set { SetValue((int)IdentityRoleFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'IdentityRoleClaimEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(IdentityRoleClaimEntity))]
		public virtual EntityCollection<IdentityRoleClaimEntity> IdentityRoleClaims { get { return GetOrCreateEntityCollection<IdentityRoleClaimEntity, IdentityRoleClaimEntityFactory>("IdentityRole", true, false, ref _identityRoleClaims); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'IdentityUserRoleEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(IdentityUserRoleEntity))]
		public virtual EntityCollection<IdentityUserRoleEntity> IdentityUserRoles { get { return GetOrCreateEntityCollection<IdentityUserRoleEntity, IdentityUserRoleEntityFactory>("IdentityRole", true, false, ref _identityUserRoles); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum IdentityRoleFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: IdentityRole. </summary>
	public partial class IdentityRoleRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between IdentityRoleEntity and IdentityRoleClaimEntity over the 1:n relation they have, using the relation between the fields: IdentityRole.Id - IdentityRoleClaim.RoleId</summary>
		public virtual IEntityRelation IdentityRoleClaimEntityUsingRoleId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "IdentityRoleClaims", true, new[] { IdentityRoleFields.Id, IdentityRoleClaimFields.RoleId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between IdentityRoleEntity and IdentityUserRoleEntity over the 1:n relation they have, using the relation between the fields: IdentityRole.Id - IdentityUserRole.RoleId</summary>
		public virtual IEntityRelation IdentityUserRoleEntityUsingRoleId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "IdentityUserRoles", true, new[] { IdentityRoleFields.Id, IdentityUserRoleFields.RoleId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIdentityRoleRelations
	{
		internal static readonly IEntityRelation IdentityRoleClaimEntityUsingRoleIdStatic = new IdentityRoleRelations().IdentityRoleClaimEntityUsingRoleId;
		internal static readonly IEntityRelation IdentityUserRoleEntityUsingRoleIdStatic = new IdentityRoleRelations().IdentityUserRoleEntityUsingRoleId;

		/// <summary>CTor</summary>
		static StaticIdentityRoleRelations() { }
	}
}
