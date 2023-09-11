﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Sra.P2rmis.WebModels.SummaryStatement
{
    public interface ISummaryStatementApplicationModel
    {
        /// <summary>
        /// Applications unique identifier (Application Log Number)
        /// </summary>
        string ApplicationId { get; set; }
        /// <summary>
        /// Panel application identifier
        /// </summary>
        int PanelApplicationId { get; set; }
        /// <summary>
        /// the applications mechanism
        /// </summary>
        string MechanismAbbreviation { get; set; }
        /// <summary>
        /// the applications overall score
        /// </summary>
        string OverallScore { get; set; }
        /// <summary>
        /// the date the application was concatenated
        /// </summary>
        DateTime? ConcatenatedDate { get; set; }
        /// <summary>
        /// the applications PI
        /// </summary>
        string PiFirstName { get; set; }
        /// <summary>
        /// the applications PI
        /// </summary>
        string PiLastName { get; set; }
        /// <summary>
        /// the application's cycle
        /// </summary>
        int? Cycle { get; set; }
        /// <summary>
        /// The panel's panelId when the application was evaluated
        /// </summary>
        int? PanelId { get; set; }
        /// <summary>
        /// The application's fiscal year
        /// </summary>
        string FY { get; set; }
        /// <summary>
        /// The application's program abbreviation
        /// </summary>
        string ProgramAbbreviation { get; set; }
        /// <summary>
        /// The panel abbreviation that evaluated the application
        /// </summary>
        string PanelAbbreviation { get; set; }
        /// <summary>
        /// Whether or not the application has been flagged as command draft
        /// </summary>
        bool IsCommandDraft { get; set; }
        /// <summary>
        /// Whether or not the application has been flagged as qualifying
        /// </summary>
        bool IsQualifying { get; set; }
        /// <summary>
        /// The workflow the application is using
        /// </summary>
        string Workflow { get; set; }
        /// <summary>
        /// The workflows unique identifier
        /// </summary>
        int? WorkflowId { get; set; }
        /// <summary>
        /// The id for the application's instance of a summary workflow, if started
        /// </summary>
        int? ApplicationWorkflowId { get; set; }
        /// <summary>
        /// Priority value
        /// </summary>
        string Priority { get; set; }
        /// <summary>
        /// Priority 2 value
        /// </summary>
        string Priority2 { get; set; }
        string Order { get; set; }
    }
}
