﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// The DPoW project stage that this workpackage is delivering part of
/// </summary>
public interface IProjectStage 
{
	/// <summary>
	/// Name of the stage
	/// </summary>
	string ProjectStageName { get;set; }

	/// <summary>
	/// Typically the RIBA stage 0-7
	/// </summary>
	string ProjectStageCode { get;set; }

	/// <summary>
	/// Description of the stage
	/// </summary>
	string ProjectStageDescription { get;set; }

	/// <summary>
	/// The work that is being delivered, i.e. Station requirements
	/// </summary>
	IEnumerable<IJob> Jobs { get;set; }

}
