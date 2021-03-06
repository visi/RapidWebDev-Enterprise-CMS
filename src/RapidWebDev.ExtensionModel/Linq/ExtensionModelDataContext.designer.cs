﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapidWebDev.ExtensionModel.Linq
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Application.Framework")]
	public partial class ExtensionModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertObjectMetadata(ObjectMetadata instance);
    partial void UpdateObjectMetadata(ObjectMetadata instance);
    partial void DeleteObjectMetadata(ObjectMetadata instance);
    partial void InsertFieldMetadata(FieldMetadata instance);
    partial void UpdateFieldMetadata(FieldMetadata instance);
    partial void DeleteFieldMetadata(FieldMetadata instance);
    #endregion
		
		public ExtensionModelDataContext() : 
				base("Data Source=.\\sqlexpress;Initial Catalog=Application.Framework;Integrated Securit" +
						"y=True", mappingSource)
		{
			OnCreated();
		}
		
		public ExtensionModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtensionModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtensionModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ExtensionModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ObjectMetadata> ObjectMetadatas
		{
			get
			{
				return this.GetTable<ObjectMetadata>();
			}
		}
		
		public System.Data.Linq.Table<FieldMetadata> FieldMetadatas
		{
			get
			{
				return this.GetTable<FieldMetadata>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ext_ObjectMetadata")]
	public partial class ObjectMetadata : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ObjectMetadataId;
		
		private System.Nullable<System.Guid> _ParentObjectMetadataId;
		
		private System.Guid _ApplicationId;
		
		private string _Name;
		
		private string _Category;
		
		private string _Description;
		
		private System.DateTime _LastUpdatedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnObjectMetadataIdChanging(System.Guid value);
    partial void OnObjectMetadataIdChanged();
    partial void OnParentObjectMetadataIdChanging(System.Nullable<System.Guid> value);
    partial void OnParentObjectMetadataIdChanged();
    partial void OnApplicationIdChanging(System.Guid value);
    partial void OnApplicationIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnLastUpdatedOnChanging(System.DateTime value);
    partial void OnLastUpdatedOnChanged();
    #endregion
		
		public ObjectMetadata()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ObjectMetadataId", AutoSync=AutoSync.OnInsert, DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public System.Guid ObjectMetadataId
		{
			get
			{
				return this._ObjectMetadataId;
			}
			set
			{
				if ((this._ObjectMetadataId != value))
				{
					this.OnObjectMetadataIdChanging(value);
					this.SendPropertyChanging();
					this._ObjectMetadataId = value;
					this.SendPropertyChanged("ObjectMetadataId");
					this.OnObjectMetadataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentObjectMetadataId", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> ParentObjectMetadataId
		{
			get
			{
				return this._ParentObjectMetadataId;
			}
			set
			{
				if ((this._ParentObjectMetadataId != value))
				{
					this.OnParentObjectMetadataIdChanging(value);
					this.SendPropertyChanging();
					this._ParentObjectMetadataId = value;
					this.SendPropertyChanged("ParentObjectMetadataId");
					this.OnParentObjectMetadataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(127) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(127)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime LastUpdatedOn
		{
			get
			{
				return this._LastUpdatedOn;
			}
			set
			{
				if ((this._LastUpdatedOn != value))
				{
					this.OnLastUpdatedOnChanging(value);
					this.SendPropertyChanging();
					this._LastUpdatedOn = value;
					this.SendPropertyChanged("LastUpdatedOn");
					this.OnLastUpdatedOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ext_FieldMetadata")]
	public partial class FieldMetadata : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _FieldMetadataId;
		
		private System.Guid _ObjectMetadataId;
		
		private string _Name;
		
		private string _FieldGroup;
		
		private string _Description;
		
		private int _Ordinal;
		
		private string _Definition;
		
		private FieldType _Type;
		
		private FieldPriviledges _Priviledge;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFieldMetadataIdChanging(System.Guid value);
    partial void OnFieldMetadataIdChanged();
    partial void OnObjectMetadataIdChanging(System.Guid value);
    partial void OnObjectMetadataIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFieldGroupChanging(string value);
    partial void OnFieldGroupChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnOrdinalChanging(int value);
    partial void OnOrdinalChanged();
    partial void OnDefinitionChanging(string value);
    partial void OnDefinitionChanged();
    partial void OnTypeChanging(FieldType value);
    partial void OnTypeChanged();
    partial void OnPriviledgeChanging(FieldPriviledges value);
    partial void OnPriviledgeChanged();
    #endregion
		
		public FieldMetadata()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldMetadataId", AutoSync=AutoSync.OnInsert, DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public System.Guid FieldMetadataId
		{
			get
			{
				return this._FieldMetadataId;
			}
			set
			{
				if ((this._FieldMetadataId != value))
				{
					this.OnFieldMetadataIdChanging(value);
					this.SendPropertyChanging();
					this._FieldMetadataId = value;
					this.SendPropertyChanged("FieldMetadataId");
					this.OnFieldMetadataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ObjectMetadataId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ObjectMetadataId
		{
			get
			{
				return this._ObjectMetadataId;
			}
			set
			{
				if ((this._ObjectMetadataId != value))
				{
					this.OnObjectMetadataIdChanging(value);
					this.SendPropertyChanging();
					this._ObjectMetadataId = value;
					this.SendPropertyChanged("ObjectMetadataId");
					this.OnObjectMetadataIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(127) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldGroup", DbType="NVarChar(127)")]
		public string FieldGroup
		{
			get
			{
				return this._FieldGroup;
			}
			set
			{
				if ((this._FieldGroup != value))
				{
					this.OnFieldGroupChanging(value);
					this.SendPropertyChanging();
					this._FieldGroup = value;
					this.SendPropertyChanged("FieldGroup");
					this.OnFieldGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ordinal", DbType="Int NOT NULL")]
		public int Ordinal
		{
			get
			{
				return this._Ordinal;
			}
			set
			{
				if ((this._Ordinal != value))
				{
					this.OnOrdinalChanging(value);
					this.SendPropertyChanging();
					this._Ordinal = value;
					this.SendPropertyChanged("Ordinal");
					this.OnOrdinalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Definition", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Definition
		{
			get
			{
				return this._Definition;
			}
			set
			{
				if ((this._Definition != value))
				{
					this.OnDefinitionChanging(value);
					this.SendPropertyChanging();
					this._Definition = value;
					this.SendPropertyChanged("Definition");
					this.OnDefinitionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="INT NOT NULL", CanBeNull=false)]
		public FieldType Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priviledge", DbType="INT NOT NULL", CanBeNull=false)]
		public FieldPriviledges Priviledge
		{
			get
			{
				return this._Priviledge;
			}
			set
			{
				if ((this._Priviledge != value))
				{
					this.OnPriviledgeChanging(value);
					this.SendPropertyChanging();
					this._Priviledge = value;
					this.SendPropertyChanged("Priviledge");
					this.OnPriviledgeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
