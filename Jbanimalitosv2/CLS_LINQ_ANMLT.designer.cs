﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jbanimalitosv2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="animalitos")]
	public partial class CLS_LINQ_ANMLTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTBL_ANIMALITOS(TBL_ANIMALITOS instance);
    partial void UpdateTBL_ANIMALITOS(TBL_ANIMALITOS instance);
    partial void DeleteTBL_ANIMALITOS(TBL_ANIMALITOS instance);
    partial void InsertTBL_HORARIOS(TBL_HORARIOS instance);
    partial void UpdateTBL_HORARIOS(TBL_HORARIOS instance);
    partial void DeleteTBL_HORARIOS(TBL_HORARIOS instance);
    partial void InsertTbl_SORTEO(Tbl_SORTEO instance);
    partial void UpdateTbl_SORTEO(Tbl_SORTEO instance);
    partial void DeleteTbl_SORTEO(Tbl_SORTEO instance);
    #endregion
		
		public CLS_LINQ_ANMLTDataContext() : 
				base(global::Jbanimalitosv2.Properties.Settings.Default.animalitosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CLS_LINQ_ANMLTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CLS_LINQ_ANMLTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CLS_LINQ_ANMLTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CLS_LINQ_ANMLTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_ANIMALITOS> TBL_ANIMALITOS
		{
			get
			{
				return this.GetTable<TBL_ANIMALITOS>();
			}
		}
		
		public System.Data.Linq.Table<TBL_HORARIOS> TBL_HORARIOS
		{
			get
			{
				return this.GetTable<TBL_HORARIOS>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_SORTEO> Tbl_SORTEO
		{
			get
			{
				return this.GetTable<Tbl_SORTEO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_ANIMALITOS")]
	public partial class TBL_ANIMALITOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDANIMALITOS;
		
		private System.Nullable<int> _IDSORTEOAN;
		
		private string _CODIGO;
		
		private string _NOMBRE_ANIMALITO;
		
		private string _COLOR;
		
		private string _COLUMNA;
		
		private string _ESTATUS;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDANIMALITOSChanging(int value);
    partial void OnIDANIMALITOSChanged();
    partial void OnIDSORTEOANChanging(System.Nullable<int> value);
    partial void OnIDSORTEOANChanged();
    partial void OnCODIGOChanging(string value);
    partial void OnCODIGOChanged();
    partial void OnNOMBRE_ANIMALITOChanging(string value);
    partial void OnNOMBRE_ANIMALITOChanged();
    partial void OnCOLORChanging(string value);
    partial void OnCOLORChanged();
    partial void OnCOLUMNAChanging(string value);
    partial void OnCOLUMNAChanged();
    partial void OnESTATUSChanging(string value);
    partial void OnESTATUSChanged();
    #endregion
		
		public TBL_ANIMALITOS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDANIMALITOS", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDANIMALITOS
		{
			get
			{
				return this._IDANIMALITOS;
			}
			set
			{
				if ((this._IDANIMALITOS != value))
				{
					this.OnIDANIMALITOSChanging(value);
					this.SendPropertyChanging();
					this._IDANIMALITOS = value;
					this.SendPropertyChanged("IDANIMALITOS");
					this.OnIDANIMALITOSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSORTEOAN", DbType="Int")]
		public System.Nullable<int> IDSORTEOAN
		{
			get
			{
				return this._IDSORTEOAN;
			}
			set
			{
				if ((this._IDSORTEOAN != value))
				{
					this.OnIDSORTEOANChanging(value);
					this.SendPropertyChanging();
					this._IDSORTEOAN = value;
					this.SendPropertyChanged("IDSORTEOAN");
					this.OnIDSORTEOANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO", DbType="VarChar(2)")]
		public string CODIGO
		{
			get
			{
				return this._CODIGO;
			}
			set
			{
				if ((this._CODIGO != value))
				{
					this.OnCODIGOChanging(value);
					this.SendPropertyChanging();
					this._CODIGO = value;
					this.SendPropertyChanged("CODIGO");
					this.OnCODIGOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE_ANIMALITO", DbType="VarChar(50)")]
		public string NOMBRE_ANIMALITO
		{
			get
			{
				return this._NOMBRE_ANIMALITO;
			}
			set
			{
				if ((this._NOMBRE_ANIMALITO != value))
				{
					this.OnNOMBRE_ANIMALITOChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE_ANIMALITO = value;
					this.SendPropertyChanged("NOMBRE_ANIMALITO");
					this.OnNOMBRE_ANIMALITOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COLOR", DbType="VarChar(1)")]
		public string COLOR
		{
			get
			{
				return this._COLOR;
			}
			set
			{
				if ((this._COLOR != value))
				{
					this.OnCOLORChanging(value);
					this.SendPropertyChanging();
					this._COLOR = value;
					this.SendPropertyChanged("COLOR");
					this.OnCOLORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COLUMNA", DbType="VarChar(1)")]
		public string COLUMNA
		{
			get
			{
				return this._COLUMNA;
			}
			set
			{
				if ((this._COLUMNA != value))
				{
					this.OnCOLUMNAChanging(value);
					this.SendPropertyChanging();
					this._COLUMNA = value;
					this.SendPropertyChanged("COLUMNA");
					this.OnCOLUMNAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS", DbType="VarChar(1)")]
		public string ESTATUS
		{
			get
			{
				return this._ESTATUS;
			}
			set
			{
				if ((this._ESTATUS != value))
				{
					this.OnESTATUSChanging(value);
					this.SendPropertyChanging();
					this._ESTATUS = value;
					this.SendPropertyChanged("ESTATUS");
					this.OnESTATUSChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_HORARIOS")]
	public partial class TBL_HORARIOS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDHORA;
		
		private System.Nullable<int> _IDSORTEOHR;
		
		private System.Nullable<System.TimeSpan> _HORA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDHORAChanging(int value);
    partial void OnIDHORAChanged();
    partial void OnIDSORTEOHRChanging(System.Nullable<int> value);
    partial void OnIDSORTEOHRChanged();
    partial void OnHORAChanging(System.Nullable<System.TimeSpan> value);
    partial void OnHORAChanged();
    #endregion
		
		public TBL_HORARIOS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDHORA", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDHORA
		{
			get
			{
				return this._IDHORA;
			}
			set
			{
				if ((this._IDHORA != value))
				{
					this.OnIDHORAChanging(value);
					this.SendPropertyChanging();
					this._IDHORA = value;
					this.SendPropertyChanged("IDHORA");
					this.OnIDHORAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSORTEOHR", DbType="Int")]
		public System.Nullable<int> IDSORTEOHR
		{
			get
			{
				return this._IDSORTEOHR;
			}
			set
			{
				if ((this._IDSORTEOHR != value))
				{
					this.OnIDSORTEOHRChanging(value);
					this.SendPropertyChanging();
					this._IDSORTEOHR = value;
					this.SendPropertyChanged("IDSORTEOHR");
					this.OnIDSORTEOHRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HORA", DbType="Time")]
		public System.Nullable<System.TimeSpan> HORA
		{
			get
			{
				return this._HORA;
			}
			set
			{
				if ((this._HORA != value))
				{
					this.OnHORAChanging(value);
					this.SendPropertyChanging();
					this._HORA = value;
					this.SendPropertyChanged("HORA");
					this.OnHORAChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_SORTEO")]
	public partial class Tbl_SORTEO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_SORTEO;
		
		private string _NOMBRE_SORTEO;
		
		private System.Nullable<double> _MINIMO;
		
		private System.Nullable<double> _MAXIMO;
		
		private System.Nullable<double> _PAGARE;
		
		private string _ESTATUS;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_SORTEOChanging(int value);
    partial void OnID_SORTEOChanged();
    partial void OnNOMBRE_SORTEOChanging(string value);
    partial void OnNOMBRE_SORTEOChanged();
    partial void OnMINIMOChanging(System.Nullable<double> value);
    partial void OnMINIMOChanged();
    partial void OnMAXIMOChanging(System.Nullable<double> value);
    partial void OnMAXIMOChanged();
    partial void OnPAGAREChanging(System.Nullable<double> value);
    partial void OnPAGAREChanged();
    partial void OnESTATUSChanging(string value);
    partial void OnESTATUSChanged();
    #endregion
		
		public Tbl_SORTEO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_SORTEO", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_SORTEO
		{
			get
			{
				return this._ID_SORTEO;
			}
			set
			{
				if ((this._ID_SORTEO != value))
				{
					this.OnID_SORTEOChanging(value);
					this.SendPropertyChanging();
					this._ID_SORTEO = value;
					this.SendPropertyChanged("ID_SORTEO");
					this.OnID_SORTEOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE_SORTEO", DbType="VarChar(50)")]
		public string NOMBRE_SORTEO
		{
			get
			{
				return this._NOMBRE_SORTEO;
			}
			set
			{
				if ((this._NOMBRE_SORTEO != value))
				{
					this.OnNOMBRE_SORTEOChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE_SORTEO = value;
					this.SendPropertyChanged("NOMBRE_SORTEO");
					this.OnNOMBRE_SORTEOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MINIMO", DbType="Float")]
		public System.Nullable<double> MINIMO
		{
			get
			{
				return this._MINIMO;
			}
			set
			{
				if ((this._MINIMO != value))
				{
					this.OnMINIMOChanging(value);
					this.SendPropertyChanging();
					this._MINIMO = value;
					this.SendPropertyChanged("MINIMO");
					this.OnMINIMOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAXIMO", DbType="Float")]
		public System.Nullable<double> MAXIMO
		{
			get
			{
				return this._MAXIMO;
			}
			set
			{
				if ((this._MAXIMO != value))
				{
					this.OnMAXIMOChanging(value);
					this.SendPropertyChanging();
					this._MAXIMO = value;
					this.SendPropertyChanged("MAXIMO");
					this.OnMAXIMOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAGARE", DbType="Float")]
		public System.Nullable<double> PAGARE
		{
			get
			{
				return this._PAGARE;
			}
			set
			{
				if ((this._PAGARE != value))
				{
					this.OnPAGAREChanging(value);
					this.SendPropertyChanging();
					this._PAGARE = value;
					this.SendPropertyChanged("PAGARE");
					this.OnPAGAREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS", DbType="VarChar(1)")]
		public string ESTATUS
		{
			get
			{
				return this._ESTATUS;
			}
			set
			{
				if ((this._ESTATUS != value))
				{
					this.OnESTATUSChanging(value);
					this.SendPropertyChanging();
					this._ESTATUS = value;
					this.SendPropertyChanged("ESTATUS");
					this.OnESTATUSChanged();
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
