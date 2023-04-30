﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using Stud1.EntityClasses;
using Stud1.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace Stud1.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Address entity</summary>
		public EntityQuery<AddressEntity> Address { get { return Create<AddressEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Param entity</summary>
		public EntityQuery<ParamEntity> Param { get { return Create<ParamEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Person entity</summary>
		public EntityQuery<PersonEntity> Person { get { return Create<PersonEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}