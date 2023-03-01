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
	/// <summary>Entity class which represents the entity 'IdentityUserToken'.<br/><br/></summary>
	[Serializable]
	public partial class IdentityUserTokenEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private UserEntity _user;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static IdentityUserTokenEntityStaticMetaData _staticMetaData = new IdentityUserTokenEntityStaticMetaData();
		private static IdentityUserTokenRelations _relationsFactory = new IdentityUserTokenRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IdentityUserTokenEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IdentityUserTokenEntityStaticMetaData()
			{
				SetEntityCoreInfo("IdentityUserTokenEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.IdentityUserTokenEntity, typeof(IdentityUserTokenEntity), typeof(IdentityUserTokenEntityFactory), false);
				AddNavigatorMetaData<IdentityUserTokenEntity, UserEntity>("User", "IdentityUserTokens", (a, b) => a._user = b, a => a._user, (a, b) => a.User = b, TournamentManager.DAL.RelationClasses.StaticIdentityUserTokenRelations.UserEntityUsingUserIdStatic, ()=>new IdentityUserTokenRelations().UserEntityUsingUserId, null, new int[] { (int)IdentityUserTokenFieldIndex.UserId }, null, true, (int)TournamentManager.DAL.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IdentityUserTokenEntity()
		{
		}

		/// <summary> CTor</summary>
		public IdentityUserTokenEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IdentityUserTokenEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IdentityUserTokenEntity</param>
		public IdentityUserTokenEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="loginProvider">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		/// <param name="name">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		/// <param name="userId">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		public IdentityUserTokenEntity(System.String loginProvider, System.String name, System.Int64 userId) : this(loginProvider, name, userId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="loginProvider">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		/// <param name="name">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		/// <param name="userId">PK value for IdentityUserToken which data should be fetched into this IdentityUserToken object</param>
		/// <param name="validator">The custom validator object for this IdentityUserTokenEntity</param>
		public IdentityUserTokenEntity(System.String loginProvider, System.String name, System.Int64 userId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.LoginProvider = loginProvider;
			this.Name = name;
			this.UserId = userId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IdentityUserTokenEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: Id .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCId()
		{
			var filter = new PredicateExpression();
			filter.Add(TournamentManager.DAL.HelperClasses.IdentityUserTokenFields.Id == this.Fields.GetCurrentValue((int)IdentityUserTokenFieldIndex.Id));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser() { return CreateRelationInfoForNavigator("User"); }
		
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
		/// <param name="validator">The validator object for this IdentityUserTokenEntity</param>
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
		public static IdentityUserTokenRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("User", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The Id property of the Entity IdentityUserToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserToken"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)IdentityUserTokenFieldIndex.Id, true); }
		}

		/// <summary>The LoginProvider property of the Entity IdentityUserToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserToken"."LoginProvider".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String LoginProvider
		{
			get { return (System.String)GetValue((int)IdentityUserTokenFieldIndex.LoginProvider, true); }
			set	{ SetValue((int)IdentityUserTokenFieldIndex.LoginProvider, value); }
		}

		/// <summary>The Name property of the Entity IdentityUserToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserToken"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)IdentityUserTokenFieldIndex.Name, true); }
			set	{ SetValue((int)IdentityUserTokenFieldIndex.Name, value); }
		}

		/// <summary>The UserId property of the Entity IdentityUserToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserToken"."UserId".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int64 UserId
		{
			get { return (System.Int64)GetValue((int)IdentityUserTokenFieldIndex.UserId, true); }
			set	{ SetValue((int)IdentityUserTokenFieldIndex.UserId, value); }
		}

		/// <summary>The Value property of the Entity IdentityUserToken<br/><br/></summary>
		/// <remarks>Mapped on  table field: "IdentityUserToken"."Value".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Value
		{
			get { return (System.String)GetValue((int)IdentityUserTokenFieldIndex.Value, true); }
			set	{ SetValue((int)IdentityUserTokenFieldIndex.Value, value); }
		}

		/// <summary>Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get { return _user; }
			set { SetSingleRelatedEntityNavigator(value, "User"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum IdentityUserTokenFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>LoginProvider. </summary>
		LoginProvider,
		///<summary>Name. </summary>
		Name,
		///<summary>UserId. </summary>
		UserId,
		///<summary>Value. </summary>
		Value,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: IdentityUserToken. </summary>
	public partial class IdentityUserTokenRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between IdentityUserTokenEntity and UserEntity over the m:1 relation they have, using the relation between the fields: IdentityUserToken.UserId - User.Id</summary>
		public virtual IEntityRelation UserEntityUsingUserId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "User", false, new[] { UserFields.Id, IdentityUserTokenFields.UserId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIdentityUserTokenRelations
	{
		internal static readonly IEntityRelation UserEntityUsingUserIdStatic = new IdentityUserTokenRelations().UserEntityUsingUserId;

		/// <summary>CTor</summary>
		static StaticIdentityUserTokenRelations() { }
	}
}
