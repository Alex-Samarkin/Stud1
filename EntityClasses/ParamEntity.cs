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
	/// <summary>Entity class which represents the entity 'Param'.<br/><br/></summary>
	[Serializable]
	public partial class ParamEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ParamEntityStaticMetaData _staticMetaData = new ParamEntityStaticMetaData();
		private static ParamRelations _relationsFactory = new ParamRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ParamEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ParamEntityStaticMetaData()
			{
				SetEntityCoreInfo("ParamEntity", InheritanceHierarchyType.None, false, (int)Stud1.EntityType.ParamEntity, typeof(ParamEntity), typeof(ParamEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static ParamEntity()
		{
		}

		/// <summary> CTor</summary>
		public ParamEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ParamEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ParamEntity</param>
		public ParamEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Param which data should be fetched into this Param object</param>
		public ParamEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Param which data should be fetched into this Param object</param>
		/// <param name="validator">The custom validator object for this ParamEntity</param>
		public ParamEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParamEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
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
		/// <param name="validator">The validator object for this ParamEntity</param>
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
		public static ParamRelations Relations { get { return _relationsFactory; } }

		/// <summary>The Id property of the Entity Param<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Param"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ParamFieldIndex.Id, true); }
			set	{ SetValue((int)ParamFieldIndex.Id, value); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Stud1
{
	public enum ParamFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Stud1.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Param. </summary>
	public partial class ParamRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticParamRelations
	{

		/// <summary>CTor</summary>
		static StaticParamRelations() { }
	}
}