﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
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
using Stud1.HelperClasses;
using Stud1.FactoryClasses;
using Stud1.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Stud1.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Address'.<br/><br/></summary>
	[Serializable]
	public partial class AddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private PersonEntity _person;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AddressEntityStaticMetaData _staticMetaData = new AddressEntityStaticMetaData();
		private static AddressRelations _relationsFactory = new AddressRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AddressEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AddressEntityStaticMetaData()
			{
				SetEntityCoreInfo("AddressEntity", InheritanceHierarchyType.None, false, (int)Stud1.EntityType.AddressEntity, typeof(AddressEntity), typeof(AddressEntityFactory), false);
				AddNavigatorMetaData<AddressEntity, PersonEntity>("Person", "Address", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, Stud1.RelationClasses.StaticAddressRelations.PersonEntityUsingPersonIdStatic, ()=>new AddressRelations().PersonEntityUsingPersonId, null, new int[] { (int)AddressFieldIndex.PersonId }, null, true, (int)Stud1.EntityType.PersonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static AddressEntity()
		{
		}

		/// <summary> CTor</summary>
		public AddressEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AddressEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }
		
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
		/// <param name="validator">The validator object for this AddressEntity</param>
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
		public static AddressRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>The Id property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.Id, true); }
			set	{ SetValue((int)AddressFieldIndex.Id, value); }
		}

		/// <summary>The State property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."State".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.State, true); }
			set	{ SetValue((int)AddressFieldIndex.State, value); }
		}

		/// <summary>The Region property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."Region".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.Region, true); }
			set	{ SetValue((int)AddressFieldIndex.Region, value); }
		}

		/// <summary>The City property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."City".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set	{ SetValue((int)AddressFieldIndex.City, value); }
		}

		/// <summary>The Street property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."Street".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Street
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.Street, true); }
			set	{ SetValue((int)AddressFieldIndex.Street, value); }
		}

		/// <summary>The Apartment property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."Apartment".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Apartment
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.Apartment, true); }
			set	{ SetValue((int)AddressFieldIndex.Apartment, value); }
		}

		/// <summary>The PersonId property of the Entity Address<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Address"."PersonId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> PersonId
		{
			get { return (Nullable<System.Int32>)GetValue((int)AddressFieldIndex.PersonId, false); }
			set	{ SetValue((int)AddressFieldIndex.PersonId, value); }
		}

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Stud1
{
	public enum AddressFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>State. </summary>
		State,
		///<summary>Region. </summary>
		Region,
		///<summary>City. </summary>
		City,
		///<summary>Street. </summary>
		Street,
		///<summary>Apartment. </summary>
		Apartment,
		///<summary>PersonId. </summary>
		PersonId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Stud1.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Address. </summary>
	public partial class AddressRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and PersonEntity over the m:1 relation they have, using the relation between the fields: Address.PersonId - Person.Id</summary>
		public virtual IEntityRelation PersonEntityUsingPersonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Person", false, new[] { PersonFields.Id, AddressFields.PersonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAddressRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingPersonIdStatic = new AddressRelations().PersonEntityUsingPersonId;

		/// <summary>CTor</summary>
		static StaticAddressRelations() { }
	}
}