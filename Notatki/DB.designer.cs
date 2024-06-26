﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notatki
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPage(Page instance);
    partial void UpdatePage(Page instance);
    partial void DeletePage(Page instance);
    partial void InsertShape(Shape instance);
    partial void UpdateShape(Shape instance);
    partial void DeleteShape(Shape instance);
    partial void InsertPoint(Point instance);
    partial void UpdatePoint(Point instance);
    partial void DeletePoint(Point instance);
    #endregion
		
		public DBDataContext() : 
				base(global::Notatki.Properties.Settings.Default.DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Page> Pages
		{
			get
			{
				return this.GetTable<Page>();
			}
		}
		
		public System.Data.Linq.Table<Shape> Shapes
		{
			get
			{
				return this.GetTable<Shape>();
			}
		}
		
		public System.Data.Linq.Table<Point> Points
		{
			get
			{
				return this.GetTable<Point>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Page")]
	public partial class Page : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private EntitySet<Shape> _Shapes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public Page()
		{
			this._Shapes = new EntitySet<Shape>(new Action<Shape>(this.attach_Shapes), new Action<Shape>(this.detach_Shapes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Shape", Storage="_Shapes", ThisKey="Id", OtherKey="PageId")]
		public EntitySet<Shape> Shapes
		{
			get
			{
				return this._Shapes;
			}
			set
			{
				this._Shapes.Assign(value);
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
		
		private void attach_Shapes(Shape entity)
		{
			this.SendPropertyChanging();
			entity.Page = this;
		}
		
		private void detach_Shapes(Shape entity)
		{
			this.SendPropertyChanging();
			entity.Page = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shape")]
	public partial class Shape : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Width;
		
		private int _Color;
		
		private int _PageId;
		
		private EntitySet<Point> _Points;
		
		private EntityRef<Page> _Page;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWidthChanging(int value);
    partial void OnWidthChanged();
    partial void OnColorChanging(int value);
    partial void OnColorChanged();
    partial void OnPageIdChanging(int value);
    partial void OnPageIdChanged();
    #endregion
		
		public Shape()
		{
			this._Points = new EntitySet<Point>(new Action<Point>(this.attach_Points), new Action<Point>(this.detach_Points));
			this._Page = default(EntityRef<Page>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Int NOT NULL")]
		public int Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="Int NOT NULL")]
		public int Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageId", DbType="Int NOT NULL")]
		public int PageId
		{
			get
			{
				return this._PageId;
			}
			set
			{
				if ((this._PageId != value))
				{
					if (this._Page.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPageIdChanging(value);
					this.SendPropertyChanging();
					this._PageId = value;
					this.SendPropertyChanged("PageId");
					this.OnPageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shape_Point", Storage="_Points", ThisKey="Id", OtherKey="ShapeId")]
		public EntitySet<Point> Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				this._Points.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Page_Shape", Storage="_Page", ThisKey="PageId", OtherKey="Id", IsForeignKey=true)]
		public Page Page
		{
			get
			{
				return this._Page.Entity;
			}
			set
			{
				Page previousValue = this._Page.Entity;
				if (((previousValue != value) 
							|| (this._Page.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Page.Entity = null;
						previousValue.Shapes.Remove(this);
					}
					this._Page.Entity = value;
					if ((value != null))
					{
						value.Shapes.Add(this);
						this._PageId = value.Id;
					}
					else
					{
						this._PageId = default(int);
					}
					this.SendPropertyChanged("Page");
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
		
		private void attach_Points(Point entity)
		{
			this.SendPropertyChanging();
			entity.Shape = this;
		}
		
		private void detach_Points(Point entity)
		{
			this.SendPropertyChanging();
			entity.Shape = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Point")]
	public partial class Point : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _X;
		
		private int _Y;
		
		private int _ShapeId;
		
		private EntityRef<Shape> _Shape;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnXChanging(int value);
    partial void OnXChanged();
    partial void OnYChanging(int value);
    partial void OnYChanged();
    partial void OnShapeIdChanging(int value);
    partial void OnShapeIdChanged();
    #endregion
		
		public Point()
		{
			this._Shape = default(EntityRef<Shape>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_X", DbType="Int NOT NULL")]
		public int X
		{
			get
			{
				return this._X;
			}
			set
			{
				if ((this._X != value))
				{
					this.OnXChanging(value);
					this.SendPropertyChanging();
					this._X = value;
					this.SendPropertyChanged("X");
					this.OnXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Y", DbType="Int NOT NULL")]
		public int Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				if ((this._Y != value))
				{
					this.OnYChanging(value);
					this.SendPropertyChanging();
					this._Y = value;
					this.SendPropertyChanged("Y");
					this.OnYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShapeId", DbType="Int NOT NULL")]
		public int ShapeId
		{
			get
			{
				return this._ShapeId;
			}
			set
			{
				if ((this._ShapeId != value))
				{
					if (this._Shape.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnShapeIdChanging(value);
					this.SendPropertyChanging();
					this._ShapeId = value;
					this.SendPropertyChanged("ShapeId");
					this.OnShapeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shape_Point", Storage="_Shape", ThisKey="ShapeId", OtherKey="Id", IsForeignKey=true)]
		public Shape Shape
		{
			get
			{
				return this._Shape.Entity;
			}
			set
			{
				Shape previousValue = this._Shape.Entity;
				if (((previousValue != value) 
							|| (this._Shape.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Shape.Entity = null;
						previousValue.Points.Remove(this);
					}
					this._Shape.Entity = value;
					if ((value != null))
					{
						value.Points.Add(this);
						this._ShapeId = value.Id;
					}
					else
					{
						this._ShapeId = default(int);
					}
					this.SendPropertyChanged("Shape");
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
