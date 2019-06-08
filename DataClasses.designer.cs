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

namespace AdvancedLoginSystem
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBLoginSystem")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::AdvancedLoginSystem.Properties.Settings.Default.DBLoginSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSearchViewUsers")]
		public ISingleResult<spSearchViewUsersResult> spSearchViewUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Search", DbType="VarChar(50)")] string search)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), search);
			return ((ISingleResult<spSearchViewUsersResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spChangePassword")]
		public int spChangePassword([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CurrentPassword", DbType="VarChar(50)")] string currentPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NewPassword", DbType="VarChar(50)")] string newPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ConfNewPassword", DbType="VarChar(50)")] string confNewPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="VarChar(MAX)")] ref string result)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, currentPassword, newPassword, confNewPassword, result);
			result = ((string)(result1.GetParameterValue(4)));
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spCheckEmail")]
		public int spCheckEmail([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Action", DbType="VarChar(50)")] string action, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="VarChar(50)")] ref string result, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuestionOut", DbType="VarChar(50)")] ref string questionOut, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AnswerIn", DbType="VarChar(50)")] string answerIn, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangePassword", DbType="VarChar(50)")] string changePassword)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, action, result, questionOut, answerIn, changePassword);
			result = ((string)(result1.GetParameterValue(2)));
			questionOut = ((string)(result1.GetParameterValue(3)));
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spManageUsers")]
		public int spManageUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Role", DbType="Int")] System.Nullable<int> role, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> isActive, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="VarChar(MAX)")] ref string result)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, role, isActive, result);
			result = ((string)(result1.GetParameterValue(3)));
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spReadUsers")]
		public int spReadUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="VarChar(50)")] ref string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] ref string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Role", DbType="VarChar(50)")] ref string role, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string isActivated)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, userName, email, role, isActivated);
			userName = ((string)(result.GetParameterValue(1)));
			email = ((string)(result.GetParameterValue(2)));
			role = ((string)(result.GetParameterValue(3)));
			isActivated = ((string)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spRegister")]
		public int spRegister([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="VarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleId", DbType="Int")] System.Nullable<int> roleId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Question", DbType="VarChar(50)")] string question, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Answer", DbType="VarChar(50)")] string answer, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="VarChar(MAX)")] ref string result)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password, email, roleId, question, answer, result);
			result = ((string)(result1.GetParameterValue(6)));
			return ((int)(result1.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spAuthentication")]
		public int spAuthentication([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Result", DbType="VarChar(100)")] ref string result, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Role", DbType="VarChar(50)")] ref string role, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] ref string userName)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, password, result, role, userName);
			result = ((string)(result1.GetParameterValue(2)));
			role = ((string)(result1.GetParameterValue(3)));
			userName = ((string)(result1.GetParameterValue(4)));
			return ((int)(result1.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _UserName;
		
		private string _Password;
		
		private string _Email;
		
		private System.Nullable<int> _RetryAttempts;
		
		private System.Nullable<bool> _IsActivated;
		
		private System.Nullable<bool> _IsLocked;
		
		private System.Nullable<System.DateTime> _DeactivatedDateTime;
		
		private System.Nullable<System.DateTime> _LockedDateTime;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private System.Nullable<System.DateTime> _LastLogin;
		
		private int _RoleID;
		
		private string _SecretQuestion;
		
		private string _SecretAnswer;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnRetryAttemptsChanging(System.Nullable<int> value);
    partial void OnRetryAttemptsChanged();
    partial void OnIsActivatedChanging(System.Nullable<bool> value);
    partial void OnIsActivatedChanged();
    partial void OnIsLockedChanging(System.Nullable<bool> value);
    partial void OnIsLockedChanged();
    partial void OnDeactivatedDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDeactivatedDateTimeChanged();
    partial void OnLockedDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLockedDateTimeChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnLastLoginChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginChanged();
    partial void OnRoleIDChanging(int value);
    partial void OnRoleIDChanged();
    partial void OnSecretQuestionChanging(string value);
    partial void OnSecretQuestionChanged();
    partial void OnSecretAnswerChanging(string value);
    partial void OnSecretAnswerChanged();
    #endregion
		
		public User()
		{
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RetryAttempts", DbType="Int")]
		public System.Nullable<int> RetryAttempts
		{
			get
			{
				return this._RetryAttempts;
			}
			set
			{
				if ((this._RetryAttempts != value))
				{
					this.OnRetryAttemptsChanging(value);
					this.SendPropertyChanging();
					this._RetryAttempts = value;
					this.SendPropertyChanged("RetryAttempts");
					this.OnRetryAttemptsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActivated", DbType="Bit")]
		public System.Nullable<bool> IsActivated
		{
			get
			{
				return this._IsActivated;
			}
			set
			{
				if ((this._IsActivated != value))
				{
					this.OnIsActivatedChanging(value);
					this.SendPropertyChanging();
					this._IsActivated = value;
					this.SendPropertyChanged("IsActivated");
					this.OnIsActivatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLocked", DbType="Bit")]
		public System.Nullable<bool> IsLocked
		{
			get
			{
				return this._IsLocked;
			}
			set
			{
				if ((this._IsLocked != value))
				{
					this.OnIsLockedChanging(value);
					this.SendPropertyChanging();
					this._IsLocked = value;
					this.SendPropertyChanged("IsLocked");
					this.OnIsLockedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeactivatedDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeactivatedDateTime
		{
			get
			{
				return this._DeactivatedDateTime;
			}
			set
			{
				if ((this._DeactivatedDateTime != value))
				{
					this.OnDeactivatedDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DeactivatedDateTime = value;
					this.SendPropertyChanged("DeactivatedDateTime");
					this.OnDeactivatedDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockedDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LockedDateTime
		{
			get
			{
				return this._LockedDateTime;
			}
			set
			{
				if ((this._LockedDateTime != value))
				{
					this.OnLockedDateTimeChanging(value);
					this.SendPropertyChanging();
					this._LockedDateTime = value;
					this.SendPropertyChanged("LockedDateTime");
					this.OnLockedDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLogin
		{
			get
			{
				return this._LastLogin;
			}
			set
			{
				if ((this._LastLogin != value))
				{
					this.OnLastLoginChanging(value);
					this.SendPropertyChanging();
					this._LastLogin = value;
					this.SendPropertyChanged("LastLogin");
					this.OnLastLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int NOT NULL")]
		public int RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecretQuestion", DbType="VarChar(50)")]
		public string SecretQuestion
		{
			get
			{
				return this._SecretQuestion;
			}
			set
			{
				if ((this._SecretQuestion != value))
				{
					this.OnSecretQuestionChanging(value);
					this.SendPropertyChanging();
					this._SecretQuestion = value;
					this.SendPropertyChanged("SecretQuestion");
					this.OnSecretQuestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecretAnswer", DbType="NChar(10)")]
		public string SecretAnswer
		{
			get
			{
				return this._SecretAnswer;
			}
			set
			{
				if ((this._SecretAnswer != value))
				{
					this.OnSecretAnswerChanging(value);
					this.SendPropertyChanging();
					this._SecretAnswer = value;
					this.SendPropertyChanged("SecretAnswer");
					this.OnSecretAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="RoleID", OtherKey="RoleID", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._RoleID = value.RoleID;
					}
					else
					{
						this._RoleID = default(int);
					}
					this.SendPropertyChanged("Role");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleID;
		
		private string _RoleName;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIDChanging(int value);
    partial void OnRoleIDChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this.OnRoleNameChanging(value);
					this.SendPropertyChanging();
					this._RoleName = value;
					this.SendPropertyChanged("RoleName");
					this.OnRoleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="RoleID", OtherKey="RoleID")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	public partial class spSearchViewUsersResult
	{
		
		private int _ID;
		
		private string _UserName;
		
		private string _Email;
		
		private System.Nullable<int> _RetryAttempts;
		
		private System.Nullable<bool> _isActivated;
		
		private System.Nullable<bool> _isLocked;
		
		private System.Nullable<System.DateTime> _DeactivatedDateTime;
		
		private System.Nullable<System.DateTime> _LockedDateTime;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private System.Nullable<System.DateTime> _LastLogin;
		
		private string _RoleName;
		
		public spSearchViewUsersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RetryAttempts", DbType="Int")]
		public System.Nullable<int> RetryAttempts
		{
			get
			{
				return this._RetryAttempts;
			}
			set
			{
				if ((this._RetryAttempts != value))
				{
					this._RetryAttempts = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isActivated", DbType="Bit")]
		public System.Nullable<bool> isActivated
		{
			get
			{
				return this._isActivated;
			}
			set
			{
				if ((this._isActivated != value))
				{
					this._isActivated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isLocked", DbType="Bit")]
		public System.Nullable<bool> isLocked
		{
			get
			{
				return this._isLocked;
			}
			set
			{
				if ((this._isLocked != value))
				{
					this._isLocked = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeactivatedDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DeactivatedDateTime
		{
			get
			{
				return this._DeactivatedDateTime;
			}
			set
			{
				if ((this._DeactivatedDateTime != value))
				{
					this._DeactivatedDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockedDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LockedDateTime
		{
			get
			{
				return this._LockedDateTime;
			}
			set
			{
				if ((this._LockedDateTime != value))
				{
					this._LockedDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this._CreatedDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLogin
		{
			get
			{
				return this._LastLogin;
			}
			set
			{
				if ((this._LastLogin != value))
				{
					this._LastLogin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this._RoleName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
