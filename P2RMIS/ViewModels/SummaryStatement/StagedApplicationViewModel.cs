﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sra.P2rmis.WebModels.SummaryStatement;
using Newtonsoft.Json;
using Sra.P2rmis.CrossCuttingServices;
using Sra.P2rmis.Web.Common;

namespace Sra.P2rmis.Web.ViewModels.SummaryStatement
{
    /// <summary>
    /// Signature of delegate used to format the overall score.
    /// </summary>
    /// <remarks>
    /// Why is a delegate needed to format the score?  The summary statement
    /// listed on the display are retrieved by an AJAX call and the display is 
    /// constructed with JQuery.  The formatting method cannot be called from 
    /// within JQuery.  Only properties on the object can be referenced.  The
    /// object is to keep this layer independent of other layers so that is 
    /// cross cutting.  But we can declare a delegate and set the delegate anywhere.
    /// </remarks>
    /// <param name="number">Number to format</param>
    /// <returns>Number formatted as string in standard way</returns>
    public delegate string OverallScoreFormatter(decimal? number);

    public class StagedApplicationViewModel
    {
        public StagedApplicationViewModel(ISummaryStatementApplicationModel application) {
            ApplicationId = application.ApplicationId;
            PanelApplicationId = application.PanelApplicationId;
            MechanismAbbreviation = application.MechanismAbbreviation;
            OverallScore = application.OverallScore;
            ConcatenatedDate = application.ConcatenatedDate;
            CheckboxEnabled = ConcatenatedDate == null;
            PiFirstName = application.PiFirstName;
            PiLastName = application.PiLastName;
            Cycle = application.Cycle;
            PanelId = application.PanelId;
            FY = application.FY;
            ProgramAbbreviation = application.ProgramAbbreviation;
            PanelAbbreviation = application.PanelAbbreviation;
            Workflow = application.Workflow;
            WorkflowId = application.WorkflowId;
            ApplicationWorkflowId = application.ApplicationWorkflowId;
            Priority = ViewHelpers.FormatBoolean(application.IsCommandDraft);
            Priority2 = ViewHelpers.FormatBoolean(application.IsQualifying);
        }

        /// <summary>
        /// Applications unique identifier (Application Log Number)
        /// </summary>
        [JsonProperty("appId")]
        public string ApplicationId { get; private set; }
        /// <summary>
        /// Panel application identifier
        /// </summary>
        [JsonProperty("panel")]
        public int PanelApplicationId { get; private set; }
        /// <summary>
        /// the applications mechanism
        /// </summary>
        [JsonProperty("awardMechanism")]
        public string MechanismAbbreviation { get; private set; }
        /// <summary>
        /// the applications overall score
        /// </summary>
        [JsonProperty("score")]
        public string OverallScore { get; private set; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="StagedApplicationViewModel"/> is checkbox.
        /// </summary>
        /// <value>
        ///   <c>true</c> if checkbox; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("checkboxEnabled")]
        public bool CheckboxEnabled { get; private set; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="StagedApplicationViewModel"/> is checkbox.
        /// </summary>
        /// <value>
        ///   <c>true</c> if checkbox; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("checkbox")]
        public bool Checkbox { get; private set; }
        /// <summary>
        /// the date the application was concatenated
        /// </summary>
        public DateTime? ConcatenatedDate { get; set; }
        /// <summary>
        /// the applications PI
        /// </summary>
        public string PiFirstName { get; set; }
        /// <summary>
        /// the applications PI
        /// </summary>
        public string PiLastName { get; set; }
        /// <summary>
        /// the application's cycle
        /// </summary>
        [JsonProperty("cycle")]
        public int? Cycle { get; private set; }
        /// <summary>
        /// The panel's panelId when the application was evaluated
        /// </summary>
        public int? PanelId { get; set; }
        /// <summary>
        /// The application's fiscal year
        /// </summary>
        public string FY { get; set; }
        /// <summary>
        /// The application's program abbreviation
        /// </summary>
        public string ProgramAbbreviation { get; set; }
        /// <summary>
        /// The panel abbreviation that evaluated the application
        /// </summary>
        public string PanelAbbreviation { get; set; }
        /// <summary>
        /// Whether or not the application has been flagged as command draft
        /// </summary>
        public bool IsCommandDraft { get; set; }
        /// <summary>
        /// Whether or not the application has been flagged as qualifying
        /// </summary>
        public bool IsQualifying { get; set; }
        /// <summary>
        /// The workflow the application is using
        /// </summary>
        [JsonProperty("workflow")]
        public string Workflow { get; set; }
        /// <summary>
        /// The workflows unique identifier
        /// </summary>
        public int? WorkflowId { get; set; }
        /// <summary>
        /// delegate used to format the overall score
        /// </summary>
        public static OverallScoreFormatter ScoreFormatter { get; set; }
        /// <summary>
        /// Overall score formatted by specific business rules.  If no formatting delegate is defined
        /// an unformatted score is returned.
        /// </summary>
        public string FormattedScore
        {
            get { return (ScoreFormatter != null) ? ScoreFormatter(Convert.ToDecimal(OverallScore)) : OverallScore; }
        }
        /// <summary>
        /// The id for the application's instance of a summary workflow, if started
        /// </summary>
        public int? ApplicationWorkflowId { get; set; }
        /// <summary>
        /// Priority value
        /// </summary>
        [JsonProperty("priorityOne")]
        public string Priority { get; private set; }
        /// <summary>
        /// Priority value
        /// </summary>
        [JsonProperty("priorityTwo")]
        public string Priority2 { get; private set; }
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        [JsonProperty("index")]
        public int Index { get; set; }
    }
}