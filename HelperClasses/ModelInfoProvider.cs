﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using Stud1.FactoryClasses;
using Stud1.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Stud1.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitAddressEntityInfo();
			InitParamEntityInfo();
			InitPersonEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits AddressEntity's info objects</summary>
		private void InitAddressEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(AddressFieldIndex), "AddressEntity");
			this.AddElementFieldInfo("AddressEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)AddressFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AddressEntity", "State", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.State, 50, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "Region", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.Region, 50, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "City", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.City, 50, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "Street", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.Street, 50, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "Apartment", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.Apartment, 50, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "PersonId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AddressFieldIndex.PersonId, 0, 0, 10);
		}

		/// <summary>Inits ParamEntity's info objects</summary>
		private void InitParamEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ParamFieldIndex), "ParamEntity");
			this.AddElementFieldInfo("ParamEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)ParamFieldIndex.Id, 0, 0, 10);
		}

		/// <summary>Inits PersonEntity's info objects</summary>
		private void InitPersonEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonFieldIndex), "PersonEntity");
			this.AddElementFieldInfo("PersonEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)PersonFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "Name", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "LastName", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)PersonFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Gender", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Gender, 2, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Code", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.Code, 50, 0, 0);
		}
	}
}