﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentScoreInfoManager.LinqClass
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Student_Score_Info")]
	public partial class MessageDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    #endregion
		
		public MessageDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Student_Score_InfoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MessageDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MessageDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Message> Message
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Message")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _Time;
		
		private string _Content;
		
		private int _SenderId;
		
		private int _RecipientId;
		
		private int _SenderType;
		
		private int _RecipientType;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnSenderIdChanging(int value);
    partial void OnSenderIdChanged();
    partial void OnRecipientIdChanging(int value);
    partial void OnRecipientIdChanged();
    partial void OnSenderTypeChanging(int value);
    partial void OnSenderTypeChanged();
    partial void OnRecipientTypeChanging(int value);
    partial void OnRecipientTypeChanged();
    #endregion
		
		public Message()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime NOT NULL")]
		public System.DateTime Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(MAX)")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderId", DbType="Int NOT NULL")]
		public int SenderId
		{
			get
			{
				return this._SenderId;
			}
			set
			{
				if ((this._SenderId != value))
				{
					this.OnSenderIdChanging(value);
					this.SendPropertyChanging();
					this._SenderId = value;
					this.SendPropertyChanged("SenderId");
					this.OnSenderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipientId", DbType="Int NOT NULL")]
		public int RecipientId
		{
			get
			{
				return this._RecipientId;
			}
			set
			{
				if ((this._RecipientId != value))
				{
					this.OnRecipientIdChanging(value);
					this.SendPropertyChanging();
					this._RecipientId = value;
					this.SendPropertyChanged("RecipientId");
					this.OnRecipientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderType", DbType="Int NOT NULL")]
		public int SenderType
		{
			get
			{
				return this._SenderType;
			}
			set
			{
				if ((this._SenderType != value))
				{
					this.OnSenderTypeChanging(value);
					this.SendPropertyChanging();
					this._SenderType = value;
					this.SendPropertyChanged("SenderType");
					this.OnSenderTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipientType", DbType="Int NOT NULL")]
		public int RecipientType
		{
			get
			{
				return this._RecipientType;
			}
			set
			{
				if ((this._RecipientType != value))
				{
					this.OnRecipientTypeChanging(value);
					this.SendPropertyChanging();
					this._RecipientType = value;
					this.SendPropertyChanged("RecipientType");
					this.OnRecipientTypeChanged();
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
