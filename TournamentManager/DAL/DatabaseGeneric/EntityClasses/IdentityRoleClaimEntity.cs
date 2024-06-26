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
	/// <summary>Entity class which represents the entity 'IdentityRoleClaim'.<br/><br/></summary>
	[Serializable]
	public partial class IdentityRoleClaimEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private IdentityRoleEntity _identityRole;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static IdentityRoleClaimEntityStaticMetaData _staticMetaData = new IdentityRoleClaimEntityStaticMetaData();
		private static IdentityRoleClaimRelations _relationsFactory = new IdentityRoleClaimRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name IdentityRole</summary>
			public static readonly string IdentityRole = "IdentityRole";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IdentityRoleClaimEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IdentityRoleClaimEntityStaticMetaData()
			{
				SetEntityCoreInfo("IdentityRoleClaimEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.IdentityRoleClaimEntity, typeof(IdentityRoleClaimEntity), typeof(IdentityRoleClaimEntityFactory), false);
				AddNavigatorMetaData<IdentityRoleClaimEntity, IdentityRoleEntity>("IdentityRole", "IdentityRoleClaims", (a, b) => a._identityRole = b, a => a._identityRole, (a, b) => a.IdentityRole = b, TournamentManager.DAL.RelationClasses.StaticIdentityRoleClaimRelations.IdentityRoleEntityUsingRoleIdStatic, ()=>new IdentityRoleClaimRelations().IdentityRoleEntityUsingRoleId, null, new int[] { (int)IdentityRoleClaimFieldIndex.RoleId }, null, true, (int)TournamentManager.DAL.EntityType.IdentityRoleEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IdentityRoleClaimEntity()
		{
		}

		/// <summary> CTor</summary>
		public IdentityRoleClaimEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IdentityRoleClaimEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IdentityRoleClaimEntity</param>
		public IdentityRoleClaimEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityRoleClaim which data should be fetched into this IdentityRoleClaim object</param>
		public IdentityRoleClaimEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for IdentityRoleClaim which data should be fetched into this IdentityRoleClaim object</param>
		/// <param name="validator">The custom validator object for this IdentityRoleClaimEntity</param>
		public IdentityRoleClaimEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IdentityRoleClaimEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'IdentityRole' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoIdentityRole() { return CreateRelationInfoForNavigator("IdentityRole"); }
		
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
		/// <param name="validator">The validator object for this IdentityRoleClaimEntity</param>
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
		public static IdentityRoleClaimRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'IdentityRole' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathIdentityRole { get { return _staticMetaData.GetPrefetchPathElement("IdentityRole", CommonEntityBase.CreateEntityCollection<IdentityRoleEntity>()); } }

		/// <summary>The ClaimType property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."ClaimType".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ClaimType
		{
			get { return (System.String)GetValue((int)IdentityRoleClaimFieldIndex.ClaimType, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.ClaimType, value); }
		}

		/// <summary>The ClaimValue property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."ClaimValue".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ClaimValue
		{
			get { return (System.String)GetValue((int)IdentityRoleClaimFieldIndex.ClaimValue, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.ClaimValue, value); }
		}

		/// <summary>The Id property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)IdentityRoleClaimFieldIndex.Id, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.Id, value); }
		}

		/// <summary>The Issuer property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."Issuer".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Issuer
		{
			get { return (System.String)GetValue((int)IdentityRoleClaimFieldIndex.Issuer, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.Issuer, value); }
		}

		/// <summary>The RoleId property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."RoleId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 RoleId
		{
			get { return (System.Int64)GetValue((int)IdentityRoleClaimFieldIndex.RoleId, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.RoleId, value); }
		}

		/// <summary>The ValueType property of the Entity IdentityRoleClaim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityRoleClaim"."ValueType".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ValueType
		{
			get { return (System.String)GetValue((int)IdentityRoleClaimFieldIndex.ValueType, true); }
			set { SetValue((int)IdentityRoleClaimFieldIndex.ValueType, value); }
		}

		/// <summary>Gets / sets related entity of type 'IdentityRoleEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual IdentityRoleEntity IdentityRole
		{
			get { return _identityRole; }
			set { SetSingleRelatedEntityNavigator(value, "IdentityRole"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum IdentityRoleClaimFieldIndex
	{
		///<summary>ClaimType. </summary>
		ClaimType,
		///<summary>ClaimValue. </summary>
		ClaimValue,
		///<summary>Id. </summary>
		Id,
		///<summary>Issuer. </summary>
		Issuer,
		///<summary>RoleId. </summary>
		RoleId,
		///<summary>ValueType. </summary>
		ValueType,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: IdentityRoleClaim. </summary>
	public partial class IdentityRoleClaimRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between IdentityRoleClaimEntity and IdentityRoleEntity over the m:1 relation they have, using the relation between the fields: IdentityRoleClaim.RoleId - IdentityRole.Id</summary>
		public virtual IEntityRelation IdentityRoleEntityUsingRoleId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "IdentityRole", false, new[] { IdentityRoleFields.Id, IdentityRoleClaimFields.RoleId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIdentityRoleClaimRelations
	{
		internal static readonly IEntityRelation IdentityRoleEntityUsingRoleIdStatic = new IdentityRoleClaimRelations().IdentityRoleEntityUsingRoleId;

		/// <summary>CTor</summary>
		static StaticIdentityRoleClaimRelations() { }
	}
}
