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

namespace bootstrap.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DefensiveBack")]
	public partial class DingerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DingerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefensiveBackConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DingerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DingerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DingerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DingerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getPlayersWithTeam")]
		public ISingleResult<getPlayersWithTeamResult> getPlayersWithTeam()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<getPlayersWithTeamResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LoginCheck")]
		public ISingleResult<LoginCheckResult> LoginCheck([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Login", DbType="VarChar(20)")] string login, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), login, password);
			return ((ISingleResult<LoginCheckResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ShowTeamList")]
		public ISingleResult<ShowTeamListResult> ShowTeamList()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ShowTeamListResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PlayerSearch")]
		public ISingleResult<PlayerSearchResult> PlayerSearch([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlayerName", DbType="VarChar(50)")] string playerName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), playerName);
			return ((ISingleResult<PlayerSearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BasicInfo")]
		public ISingleResult<BasicInfoResult> BasicInfo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlayerID", DbType="Int")] System.Nullable<int> playerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), playerID);
			return ((ISingleResult<BasicInfoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BatterPlayerPage")]
		public ISingleResult<BatterPlayerPageResult> BatterPlayerPage([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlayerID", DbType="Int")] System.Nullable<int> playerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), playerID);
			return ((ISingleResult<BatterPlayerPageResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PitcherPlayerPage")]
		public ISingleResult<PitcherPlayerPageResult> PitcherPlayerPage([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlayerID", DbType="Int")] System.Nullable<int> playerID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), playerID);
			return ((ISingleResult<PitcherPlayerPageResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LeagueLeaders")]
		public ISingleResult<LeagueLeadersResult> LeagueLeaders()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<LeagueLeadersResult>)(result.ReturnValue));
		}
	}
	
	public partial class getPlayersWithTeamResult
	{
		
		private int _PlayerID;
		
		private string _Name;
		
		private System.Nullable<int> _TeamID;
		
		private string _TeamName;
		
		public getPlayersWithTeamResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int NOT NULL")]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this._PlayerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamID", DbType="Int")]
		public System.Nullable<int> TeamID
		{
			get
			{
				return this._TeamID;
			}
			set
			{
				if ((this._TeamID != value))
				{
					this._TeamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
	}
	
	public partial class LoginCheckResult
	{
		
		private System.Nullable<bool> _LoginSuccess;
		
		public LoginCheckResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginSuccess", DbType="Bit")]
		public System.Nullable<bool> LoginSuccess
		{
			get
			{
				return this._LoginSuccess;
			}
			set
			{
				if ((this._LoginSuccess != value))
				{
					this._LoginSuccess = value;
				}
			}
		}
	}
	
	public partial class ShowTeamListResult
	{
		
		private int _TeamID;
		
		private string _TeamName;
		
		public ShowTeamListResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamID", DbType="Int NOT NULL")]
		public int TeamID
		{
			get
			{
				return this._TeamID;
			}
			set
			{
				if ((this._TeamID != value))
				{
					this._TeamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
	}
	
	public partial class PlayerSearchResult
	{
		
		private int _PlayerID;
		
		private int _TeamID;
		
		private string _Name;
		
		private System.Nullable<int> _Age;
		
		private string _TeamName;
		
		private string _PositionAbbr;
		
		private string _PositionName;
		
		public PlayerSearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int NOT NULL")]
		public int PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					this._PlayerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamID", DbType="Int NOT NULL")]
		public int TeamID
		{
			get
			{
				return this._TeamID;
			}
			set
			{
				if ((this._TeamID != value))
				{
					this._TeamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionAbbr", DbType="NVarChar(2)")]
		public string PositionAbbr
		{
			get
			{
				return this._PositionAbbr;
			}
			set
			{
				if ((this._PositionAbbr != value))
				{
					this._PositionAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(20)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this._PositionName = value;
				}
			}
		}
	}
	
	public partial class BasicInfoResult
	{
		
		private string _Name;
		
		private System.Nullable<int> _Age;
		
		private string _TeamName;
		
		private string _PositionAbbr;
		
		private string _PositionName;
		
		public BasicInfoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionAbbr", DbType="NVarChar(2)")]
		public string PositionAbbr
		{
			get
			{
				return this._PositionAbbr;
			}
			set
			{
				if ((this._PositionAbbr != value))
				{
					this._PositionAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(20)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this._PositionName = value;
				}
			}
		}
	}
	
	public partial class BatterPlayerPageResult
	{
		
		private string _Name;
		
		private System.Nullable<int> _Age;
		
		private string _TeamName;
		
		private string _PositionAbbr;
		
		private string _PositionName;
		
		private System.Nullable<int> _G;
		
		private System.Nullable<double> _AB;
		
		private System.Nullable<double> _H;
		
		private System.Nullable<int> _HR;
		
		private System.Nullable<int> _RBI;
		
		private System.Nullable<decimal> _AVG;
		
		private System.Nullable<decimal> _OBP;
		
		private System.Nullable<decimal> _SLG;
		
		private System.Nullable<decimal> _OPS;
		
		private System.Nullable<decimal> _ISO;
		
		private System.Nullable<decimal> _BABIP;
		
		private System.Nullable<decimal> _K_;
		
		private System.Nullable<decimal> _BB_;
		
		public BatterPlayerPageResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionAbbr", DbType="NVarChar(2)")]
		public string PositionAbbr
		{
			get
			{
				return this._PositionAbbr;
			}
			set
			{
				if ((this._PositionAbbr != value))
				{
					this._PositionAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(20)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this._PositionName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_G", DbType="Int")]
		public System.Nullable<int> G
		{
			get
			{
				return this._G;
			}
			set
			{
				if ((this._G != value))
				{
					this._G = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AB", DbType="Float")]
		public System.Nullable<double> AB
		{
			get
			{
				return this._AB;
			}
			set
			{
				if ((this._AB != value))
				{
					this._AB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_H", DbType="Float")]
		public System.Nullable<double> H
		{
			get
			{
				return this._H;
			}
			set
			{
				if ((this._H != value))
				{
					this._H = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HR", DbType="Int")]
		public System.Nullable<int> HR
		{
			get
			{
				return this._HR;
			}
			set
			{
				if ((this._HR != value))
				{
					this._HR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RBI", DbType="Int")]
		public System.Nullable<int> RBI
		{
			get
			{
				return this._RBI;
			}
			set
			{
				if ((this._RBI != value))
				{
					this._RBI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AVG", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> AVG
		{
			get
			{
				return this._AVG;
			}
			set
			{
				if ((this._AVG != value))
				{
					this._AVG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OBP", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> OBP
		{
			get
			{
				return this._OBP;
			}
			set
			{
				if ((this._OBP != value))
				{
					this._OBP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLG", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> SLG
		{
			get
			{
				return this._SLG;
			}
			set
			{
				if ((this._SLG != value))
				{
					this._SLG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OPS", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> OPS
		{
			get
			{
				return this._OPS;
			}
			set
			{
				if ((this._OPS != value))
				{
					this._OPS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISO", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> ISO
		{
			get
			{
				return this._ISO;
			}
			set
			{
				if ((this._ISO != value))
				{
					this._ISO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BABIP", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> BABIP
		{
			get
			{
				return this._BABIP;
			}
			set
			{
				if ((this._BABIP != value))
				{
					this._BABIP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[K%]", Storage="_K_", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> K_
		{
			get
			{
				return this._K_;
			}
			set
			{
				if ((this._K_ != value))
				{
					this._K_ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BB%]", Storage="_BB_", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> BB_
		{
			get
			{
				return this._BB_;
			}
			set
			{
				if ((this._BB_ != value))
				{
					this._BB_ = value;
				}
			}
		}
	}
	
	public partial class PitcherPlayerPageResult
	{
		
		private string _Name;
		
		private System.Nullable<int> _Age;
		
		private string _TeamName;
		
		private string _PositionAbbr;
		
		private string _PositionName;
		
		private System.Nullable<int> _G;
		
		private System.Nullable<double> _IP;
		
		private System.Nullable<int> _W;
		
		private System.Nullable<int> _L;
		
		private System.Nullable<int> _SV;
		
		private System.Nullable<int> _BS;
		
		private System.Nullable<decimal> _ERA;
		
		private System.Nullable<decimal> _WHIP;
		
		private System.Nullable<double> _AVG;
		
		private System.Nullable<decimal> _K_9;
		
		private System.Nullable<decimal> _BB_9;
		
		private System.Nullable<decimal> _K_BB;
		
		private System.Nullable<decimal> _K_;
		
		private System.Nullable<decimal> _BB_;
		
		public PitcherPlayerPageResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(256)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionAbbr", DbType="NVarChar(2)")]
		public string PositionAbbr
		{
			get
			{
				return this._PositionAbbr;
			}
			set
			{
				if ((this._PositionAbbr != value))
				{
					this._PositionAbbr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="NVarChar(20)")]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this._PositionName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_G", DbType="Int")]
		public System.Nullable<int> G
		{
			get
			{
				return this._G;
			}
			set
			{
				if ((this._G != value))
				{
					this._G = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IP", DbType="Float")]
		public System.Nullable<double> IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				if ((this._IP != value))
				{
					this._IP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_W", DbType="Int")]
		public System.Nullable<int> W
		{
			get
			{
				return this._W;
			}
			set
			{
				if ((this._W != value))
				{
					this._W = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_L", DbType="Int")]
		public System.Nullable<int> L
		{
			get
			{
				return this._L;
			}
			set
			{
				if ((this._L != value))
				{
					this._L = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SV", DbType="Int")]
		public System.Nullable<int> SV
		{
			get
			{
				return this._SV;
			}
			set
			{
				if ((this._SV != value))
				{
					this._SV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BS", DbType="Int")]
		public System.Nullable<int> BS
		{
			get
			{
				return this._BS;
			}
			set
			{
				if ((this._BS != value))
				{
					this._BS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERA", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> ERA
		{
			get
			{
				return this._ERA;
			}
			set
			{
				if ((this._ERA != value))
				{
					this._ERA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WHIP", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> WHIP
		{
			get
			{
				return this._WHIP;
			}
			set
			{
				if ((this._WHIP != value))
				{
					this._WHIP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AVG", DbType="Float")]
		public System.Nullable<double> AVG
		{
			get
			{
				return this._AVG;
			}
			set
			{
				if ((this._AVG != value))
				{
					this._AVG = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[K/9]", Storage="_K_9", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> K_9
		{
			get
			{
				return this._K_9;
			}
			set
			{
				if ((this._K_9 != value))
				{
					this._K_9 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BB/9]", Storage="_BB_9", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> BB_9
		{
			get
			{
				return this._BB_9;
			}
			set
			{
				if ((this._BB_9 != value))
				{
					this._BB_9 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[K/BB]", Storage="_K_BB", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> K_BB
		{
			get
			{
				return this._K_BB;
			}
			set
			{
				if ((this._K_BB != value))
				{
					this._K_BB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[K%]", Storage="_K_", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> K_
		{
			get
			{
				return this._K_;
			}
			set
			{
				if ((this._K_ != value))
				{
					this._K_ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BB%]", Storage="_BB_", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> BB_
		{
			get
			{
				return this._BB_;
			}
			set
			{
				if ((this._BB_ != value))
				{
					this._BB_ = value;
				}
			}
		}
	}
	
	public partial class LeagueLeadersResult
	{
		
		private string _Name;
		
		private System.Nullable<decimal> _AVG;
		
		public LeagueLeadersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AVG", DbType="Decimal(10,3)")]
		public System.Nullable<decimal> AVG
		{
			get
			{
				return this._AVG;
			}
			set
			{
				if ((this._AVG != value))
				{
					this._AVG = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
